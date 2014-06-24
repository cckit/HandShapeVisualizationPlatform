// author：      Tommy
// created time：6/24/2014 11:27:15 PM
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
	public class CSVDataSetModel : AbstractDataSetModel {

		string pathName;

		private const string rawDataTableName = "Raw Data Table";

		public CSVDataSetModel(string pathName) {
			this.pathName = pathName;
		}

		public override void loadRawData() {
			DataLoader.loadFromCSV(pathName, false, DataSet.Tables.Add(rawDataTableName));
			Console.WriteLine("Row: " + DataSet.Tables[rawDataTableName].Rows.Count + "\tCol: " + DataSet.Tables[rawDataTableName].Columns.Count);
		}

		public override void initDataSet() {
			DataSet.Tables[rawDataTableName].Columns[0].ColumnName = "Class";
		}

		public override void update() {

		}

		public DataTable getRawDataTable() {
			return DataSet.Tables[rawDataTableName];
		}
	}
}