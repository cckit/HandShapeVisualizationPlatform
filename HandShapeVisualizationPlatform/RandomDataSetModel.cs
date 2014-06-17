// author：      Tommy
// created time：6/14/2014 10:02:41 PM
// organizatioin:CURE lab, CUHK
// copyright：   2014-2015
// CLR：         4.0.30319.17929
// project link：https://github.com/huangfuyang/Sign-Language-with-Kinect

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HandShapeVisualizationPlatform {
	/// <summary>
	/// add summary here
	/// </summary>
	public class RandomDataSetModel : AbstractDataSetModel {

		private const int HAND_SHAPE_COUNT = 15;

		private int frameCount = 0;
		private double[] Ms;
		private double[] Ss;

		public RandomDataSetModel() {

		}

		public override void loadRawData() {
			DataTable handShapeDataTable = DataSet.Tables.Add("HandShape");

			handShapeDataTable.Columns.Add("Lower whisker");
			handShapeDataTable.Columns.Add("Upper whisker");
			handShapeDataTable.Columns.Add("Lower box");
			handShapeDataTable.Columns.Add("Upper box");
			handShapeDataTable.Columns.Add("Current");
			handShapeDataTable.Columns.Add("Average");

			Ms = new double[HAND_SHAPE_COUNT];
			Ss = new double[HAND_SHAPE_COUNT];

			for(int i = 0; i < HAND_SHAPE_COUNT; i++) {
				handShapeDataTable.Rows.Add(handShapeDataTable.NewRow());
			}


			DataTable trajectoryDataTable = DataSet.Tables.Add("Trajectory");
			trajectoryDataTable.Columns.Add("All");
			trajectoryDataTable.Columns.Add("1st Half");
			trajectoryDataTable.Columns.Add("2nd Half");
			trajectoryDataTable.Columns.Add("1st Quarter");
			trajectoryDataTable.Columns.Add("2nd Quarter");
			trajectoryDataTable.Columns.Add("3rd Quarter");
			trajectoryDataTable.Columns.Add("4th Quarter");

			for(int i = 0; i < 8; i++) {
				trajectoryDataTable.Rows.Add(trajectoryDataTable.NewRow());
			}
		}

		public override void initDataSet() {
			
		}

		public override void update() {
			DataTable handShapeDataTable = DataSet.Tables["HandShape"];
			Random random = new Random();
			double total = 0.0D;

			frameCount++;

			foreach(DataRow row in handShapeDataTable.Rows) {
				double d = random.NextDouble();
				row["Current"] = d;
				total += d;
			}

			for(int i=0; i<handShapeDataTable.Rows.Count; i++) {
				DataRow row = handShapeDataTable.Rows[i];
				double d = Convert.ToDouble(row["Current"]) / total;
				
				row["Current"] = d;

				if(frameCount == 1) {
					row["Lower whisker"] = d;
					row["Upper whisker"] = d;
					row["Lower box"] = d;
					row["Upper box"] = d;
					row["Average"] = d;
					
					Ms[i] = d;
					Ss[i] = 0.0D;

				} else {
					if(d < Convert.ToDouble(row["Lower whisker"]))
						row["Lower whisker"] = d;
					if(d > Convert.ToDouble(row["Upper whisker"]))
						row["Upper whisker"] = d;

					double average = (Convert.ToDouble(row["Average"]) * frameCount + d) / (frameCount + 1);
					row["Average"] = average;

					double oldMs = Ms[i];
					Ms[i] = Ms[i] + (d - Ms[i]) / frameCount;
					Ss[i] = Ss[i] + (d - oldMs) * (d - Ms[i]);
					double sd = Math.Sqrt(Ss[i] / (frameCount - 1));
					row["Lower box"] = average - sd;
					row["Upper box"] = average + sd;
				}
			}

			handShapeDataTable.AcceptChanges();


			DataTable trajectoryDataTable = DataSet.Tables["Trajectory"];
			for(int c = 0; c < trajectoryDataTable.Columns.Count; c++) {
				total = 0.0D;

				foreach(DataRow row in trajectoryDataTable.Rows){
					double d = random.NextDouble();
					row[c] = d;
					total += d;
				}

				foreach(DataRow row in trajectoryDataTable.Rows) {
					row[c] = Convert.ToDouble(row[c]) / total;
				}
			}

			trajectoryDataTable.AcceptChanges();
		}
	}
}