// author：      Tommy
// created time：6/14/2014 9:50:33 PM
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
	public abstract class AbstractDataSetModel {

		private DataSet dataSet;

		public DataSet DataSet {
			get { return dataSet; }
		}

		public AbstractDataSetModel() {
			dataSet = new DataSet();
		}

		public void start() {
			loadRawData();
			initDataSet();
			update();
		}

		public abstract void loadRawData();
		public abstract void initDataSet();
		public abstract void update();
	}
}