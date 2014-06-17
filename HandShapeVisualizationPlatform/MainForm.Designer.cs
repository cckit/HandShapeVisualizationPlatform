namespace HandShapeVisualizationPlatform {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
			this.chartTrajectory = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartHandshape = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.btnUpdate = new System.Windows.Forms.Button();
			mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			mainTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartTrajectory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartHandshape)).BeginInit();
			this.SuspendLayout();
			// 
			// mainTableLayoutPanel
			// 
			mainTableLayoutPanel.ColumnCount = 2;
			mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			mainTableLayoutPanel.Controls.Add(this.chartTrajectory, 0, 1);
			mainTableLayoutPanel.Controls.Add(this.chartHandshape, 0, 1);
			mainTableLayoutPanel.Controls.Add(this.btnUpdate, 0, 0);
			mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			mainTableLayoutPanel.Name = "mainTableLayoutPanel";
			mainTableLayoutPanel.RowCount = 2;
			mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			mainTableLayoutPanel.Size = new System.Drawing.Size(1118, 542);
			mainTableLayoutPanel.TabIndex = 0;
			// 
			// chartTrajectory
			// 
			this.chartTrajectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(193)))));
			this.chartTrajectory.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			this.chartTrajectory.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(64)))), ((int)(((byte)(1)))));
			this.chartTrajectory.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			this.chartTrajectory.BorderlineWidth = 2;
			this.chartTrajectory.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
			chartArea1.Area3DStyle.Inclination = 15;
			chartArea1.Area3DStyle.IsClustered = true;
			chartArea1.Area3DStyle.IsRightAngleAxes = false;
			chartArea1.Area3DStyle.Perspective = 10;
			chartArea1.Area3DStyle.Rotation = 10;
			chartArea1.Area3DStyle.WallWidth = 0;
			chartArea1.AxisX.LabelAutoFitMaxFontSize = 8;
			chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisX.LabelStyle.IsEndLabelVisible = false;
			chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			chartArea1.AxisY.LabelAutoFitMaxFontSize = 8;
			chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			chartArea1.BackColor = System.Drawing.Color.OldLace;
			chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea1.BackSecondaryColor = System.Drawing.Color.White;
			chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			chartArea1.InnerPlotPosition.Auto = false;
			chartArea1.InnerPlotPosition.Height = 92.5401F;
			chartArea1.InnerPlotPosition.Width = 49.07648F;
			chartArea1.InnerPlotPosition.X = 0.46175F;
			chartArea1.InnerPlotPosition.Y = 2.93321F;
			chartArea1.Name = "charAreaLayer12";
			chartArea1.Position.Auto = false;
			chartArea1.Position.Height = 74.64147F;
			chartArea1.Position.Width = 67.31341F;
			chartArea1.Position.X = 4.358696F;
			chartArea1.Position.Y = 18.09717F;
			chartArea1.ShadowColor = System.Drawing.Color.Transparent;
			chartArea2.Area3DStyle.Inclination = 15;
			chartArea2.Area3DStyle.IsClustered = true;
			chartArea2.Area3DStyle.IsRightAngleAxes = false;
			chartArea2.Area3DStyle.Perspective = 10;
			chartArea2.Area3DStyle.Rotation = 10;
			chartArea2.Area3DStyle.WallWidth = 0;
			chartArea2.AxisX.LabelAutoFitMaxFontSize = 8;
			chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea2.AxisX.LabelStyle.IsEndLabelVisible = false;
			chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			chartArea2.AxisY.LabelAutoFitMaxFontSize = 8;
			chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			chartArea2.BackColor = System.Drawing.Color.OldLace;
			chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea2.BackSecondaryColor = System.Drawing.Color.White;
			chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			chartArea2.InnerPlotPosition.Auto = false;
			chartArea2.InnerPlotPosition.Height = 92.5401F;
			chartArea2.InnerPlotPosition.Width = 49.07648F;
			chartArea2.InnerPlotPosition.X = 50.46175F;
			chartArea2.InnerPlotPosition.Y = 2.93321F;
			chartArea2.Name = "charAreaLayer3";
			chartArea2.Position.Auto = false;
			chartArea2.Position.Height = 74.64147F;
			chartArea2.Position.Width = 67.31341F;
			chartArea2.Position.X = 4.358696F;
			chartArea2.Position.Y = 18.09717F;
			chartArea2.ShadowColor = System.Drawing.Color.Transparent;
			this.chartTrajectory.ChartAreas.Add(chartArea1);
			this.chartTrajectory.ChartAreas.Add(chartArea2);
			this.chartTrajectory.Dock = System.Windows.Forms.DockStyle.Fill;
			legend1.BackColor = System.Drawing.Color.Transparent;
			legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend1.IsTextAutoFit = false;
			legend1.Name = "Default";
			this.chartTrajectory.Legends.Add(legend1);
			this.chartTrajectory.Location = new System.Drawing.Point(562, 274);
			this.chartTrajectory.Name = "chartTrajectory";
			series1.ChartArea = "charAreaLayer12";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
			series1.CustomProperties = "RadarDrawingStyle=Line, EmptyPointValue=Zero";
			series1.Legend = "Default";
			series1.Name = "All";
			series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series2.ChartArea = "charAreaLayer12";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
			series2.CustomProperties = "RadarDrawingStyle=Line, EmptyPointValue=Zero";
			series2.Legend = "Default";
			series2.Name = "1st Half";
			series3.ChartArea = "charAreaLayer12";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
			series3.CustomProperties = "RadarDrawingStyle=Line, EmptyPointValue=Zero";
			series3.Legend = "Default";
			series3.Name = "2nd Half";
			series4.ChartArea = "charAreaLayer3";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
			series4.CustomProperties = "RadarDrawingStyle=Line, EmptyPointValue=Zero";
			series4.Legend = "Default";
			series4.Name = "1st Quarter";
			series5.ChartArea = "charAreaLayer3";
			series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
			series5.CustomProperties = "RadarDrawingStyle=Line, EmptyPointValue=Zero";
			series5.Legend = "Default";
			series5.Name = "2nd Quarter";
			series6.ChartArea = "charAreaLayer3";
			series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
			series6.CustomProperties = "RadarDrawingStyle=Line, EmptyPointValue=Zero";
			series6.Legend = "Default";
			series6.Name = "3rd Quarter";
			series7.ChartArea = "charAreaLayer3";
			series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
			series7.CustomProperties = "RadarDrawingStyle=Line, EmptyPointValue=Zero";
			series7.Legend = "Default";
			series7.Name = "4th Quarter";
			this.chartTrajectory.Series.Add(series1);
			this.chartTrajectory.Series.Add(series2);
			this.chartTrajectory.Series.Add(series3);
			this.chartTrajectory.Series.Add(series4);
			this.chartTrajectory.Series.Add(series5);
			this.chartTrajectory.Series.Add(series6);
			this.chartTrajectory.Series.Add(series7);
			this.chartTrajectory.Size = new System.Drawing.Size(553, 265);
			this.chartTrajectory.TabIndex = 4;
			title1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
			title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
			title1.Name = "Title1";
			title1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			title1.ShadowOffset = 3;
			title1.Text = "Trajectory Probability Distrbution";
			this.chartTrajectory.Titles.Add(title1);
			// 
			// chartHandshape
			// 
			this.chartHandshape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(193)))));
			this.chartHandshape.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			this.chartHandshape.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(64)))), ((int)(((byte)(1)))));
			this.chartHandshape.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			this.chartHandshape.BorderlineWidth = 2;
			this.chartHandshape.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Emboss;
			chartArea3.Area3DStyle.Inclination = 15;
			chartArea3.Area3DStyle.IsClustered = true;
			chartArea3.Area3DStyle.IsRightAngleAxes = false;
			chartArea3.Area3DStyle.Perspective = 10;
			chartArea3.Area3DStyle.Rotation = 10;
			chartArea3.Area3DStyle.WallWidth = 0;
			chartArea3.AxisX.LabelAutoFitMaxFontSize = 8;
			chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea3.AxisX.LabelStyle.IsEndLabelVisible = false;
			chartArea3.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			chartArea3.AxisY.LabelAutoFitMaxFontSize = 8;
			chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			chartArea3.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			chartArea3.BackColor = System.Drawing.Color.OldLace;
			chartArea3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			chartArea3.BackSecondaryColor = System.Drawing.Color.White;
			chartArea3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			chartArea3.Name = "Default";
			chartArea3.ShadowColor = System.Drawing.Color.Transparent;
			this.chartHandshape.ChartAreas.Add(chartArea3);
			this.chartHandshape.Dock = System.Windows.Forms.DockStyle.Fill;
			legend2.BackColor = System.Drawing.Color.Transparent;
			legend2.Enabled = false;
			legend2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
			legend2.IsTextAutoFit = false;
			legend2.Name = "Default";
			this.chartHandshape.Legends.Add(legend2);
			this.chartHandshape.Location = new System.Drawing.Point(3, 274);
			this.chartHandshape.Name = "chartHandshape";
			series8.ChartArea = "Default";
			series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
			series8.Legend = "Default";
			series8.Name = "Series3";
			series8.YValuesPerPoint = 6;
			series8.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			this.chartHandshape.Series.Add(series8);
			this.chartHandshape.Size = new System.Drawing.Size(553, 265);
			this.chartHandshape.TabIndex = 3;
			title2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold);
			title2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
			title2.Name = "Title1";
			title2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			title2.ShadowOffset = 3;
			title2.Text = "Handshape Probability Distrbution";
			this.chartHandshape.Titles.Add(title2);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(3, 3);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 5;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1118, 542);
			this.Controls.Add(mainTableLayoutPanel);
			this.Name = "MainForm";
			this.Text = "Hand Shape Visualization Plaform";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			mainTableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartTrajectory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartHandshape)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chartHandshape;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartTrajectory;
		private System.Windows.Forms.Button btnUpdate;
	}
}

