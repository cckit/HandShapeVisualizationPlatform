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

		private int givenDataIndex = -1;
		public int GivenDataIndex {
			get { return givenDataIndex; }
			set { this.givenDataIndex = value; }
		}

		private int compareDataIndex = -1;
		public int CompareDataIndex {
			get { return compareDataIndex; }
			set { this.compareDataIndex = value; }
		}

		private const string RAW_DATA_TABLE_NAME = "Raw Data Table";

		public CSVDataSetModel(string pathName) {
			this.pathName = pathName;
		}

		public override void loadRawData() {
			DataLoader.loadFromCSV(pathName, false, DataSet.Tables.Add(RAW_DATA_TABLE_NAME));
			Console.WriteLine("Row: " + DataSet.Tables[RAW_DATA_TABLE_NAME].Rows.Count + "\tCol: " + DataSet.Tables[RAW_DATA_TABLE_NAME].Columns.Count);
		}

		public override void initDataSet() {
			DataSet.Tables[RAW_DATA_TABLE_NAME].Columns[0].ColumnName = "Class";
		}

		public override void update() {

		}

		public DataTable getRawDataTable() {
			return DataSet.Tables[RAW_DATA_TABLE_NAME];
		}
	}
}