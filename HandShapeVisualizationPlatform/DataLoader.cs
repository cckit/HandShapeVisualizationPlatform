// author：      Tommy
// created time：6/24/2014 1:00:57 PM
// organizatioin:CURE lab, CUHK
// copyright：   2014-2015
// CLR：         4.0.30319.17929
// project link：https://github.com/huangfuyang/Sign-Language-with-Kinect

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumenWorks.Framework.IO.Csv;


namespace HandShapeVisualizationPlatform {
	/// <summary>
	/// add summary here
	/// </summary>
	public class DataLoader {

		public static DataTable loadFromCSV(string pathName, bool isHeader) {
			DataTable table = new DataTable();
			using(CachedCsvReader csv = new CachedCsvReader (new StreamReader(pathName), false)) {
				table.Load(csv);
			}
			return table;
		}
	}
}