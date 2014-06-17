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

			for(int i=0; i<chartHandshape.Series.Count; i++) {
				Series series = chartHandshape.Series[i];
				series.Points.Clear();

				foreach(DataRow r in tableHandShape.Rows) {
					DataPoint point = new DataPoint(0D, new double[] { 
						Convert.ToDouble(r["Lower whisker"]), 
						Convert.ToDouble(r["Upper whisker"]), 
						Convert.ToDouble(r["Lower box"]), 
						Convert.ToDouble(r["Upper box"]), 
						Convert.ToDouble(r["Current"]), 
						Convert.ToDouble(r["Average"])
					});
					series.Points.Add(point);
				}
			}
		}
	}
}
