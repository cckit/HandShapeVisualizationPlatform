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
		private const int TRAJECTORY_COUNT = 8;
		private const int TRAJECTORY_LAYER = 3;

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
				DataRow r = handShapeDataTable.NewRow();

				handShapeDataTable.Rows.Add(handShapeDataTable.NewRow());
			}

			DataTable trajectoryDataTable = DataSet.Tables.Add("Trajectory");
			for(int i = 0; i < TRAJECTORY_LAYER; i++) {
				for(int j = 0; j < TRAJECTORY_COUNT; j++) {
					trajectoryDataTable.Columns.Add(i + " " + j);
				}
			}
		}

		public override void initDataSet() {
			
		}

		public override void update() {
			DataTable handShapeDataTable = DataSet.Tables["HandShape"];
			DataTable trajectoryDataTable = DataSet.Tables["Trajectory"];
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
		}
	}
}