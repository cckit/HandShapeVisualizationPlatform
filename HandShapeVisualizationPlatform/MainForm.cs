using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HandShapeVisualizationPlatform {
	public partial class MainForm : Form {

		private RandomDataSetModel dataSetModel;

		public MainForm() {
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e) {
			dataSetModel = new RandomDataSetModel();

			//chartHandshape.DataBindTable(((System.ComponentModel.IListSource)dataSetModel.DataSet.Tables["HandShape"]).GetList());

			dataSetModel.update();
			updateChart();
		}

		private void btnUpdate_Click(object sender, EventArgs e) {
			dataSetModel.update();
			updateChart();
		}

		private void updateChart() {
			DataTable tableHandShape = dataSetModel.DataSet.Tables["HandShape"];
			Series series = chartHandshape.Series[0];
			int maximumIndex = 0;
			double maximumValue = -1.0D;
			series.Points.Clear();

			for(int i = 0; i < tableHandShape.Rows.Count; i++) {
				DataRow r = tableHandShape.Rows[i];
				DataPoint point = new DataPoint(0D, new double[] { 
						Convert.ToDouble(r["Lower whisker"]), 
						Convert.ToDouble(r["Upper whisker"]), 
						Convert.ToDouble(r["Lower box"]), 
						Convert.ToDouble(r["Upper box"]), 
						Convert.ToDouble(r["Current"]), 
						Convert.ToDouble(r["Average"])
					});
				series.Points.Add(point);

				if(Convert.ToDouble(r["Current"]) > maximumValue) {
					maximumIndex = i;
					maximumValue = Convert.ToDouble(r["Current"]);
				}
			}

			if(tableHandShape.Rows.Count > 0) {
				series.Points[maximumIndex].Color = Color.Red;
			}


			DataTable tableTrajectory = dataSetModel.DataSet.Tables["Trajectory"];
			for(int i = 0; i < chartTrajectory.Series.Count; i++) {
				series = chartTrajectory.Series[i];
				series.Points.Clear();

				foreach(DataRow r in tableTrajectory.Rows) {
					//string xValue = Convert.ToString(tableTrajectory.Rows[tableTrajectory.Rows.Count-1]);
					series.Points.AddY(r[i]);
				}
			}
		}
	}
}
