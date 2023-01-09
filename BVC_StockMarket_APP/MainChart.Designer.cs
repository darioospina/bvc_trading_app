﻿
namespace BVC_StockMarket_APP
{
    partial class MainChart
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartSeries = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblOverview = new System.Windows.Forms.Label();
            this.dataGridMain = new System.Windows.Forms.DataGridView();
            this.col1_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2_open = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3_high = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4_low = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5_close = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col6_volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chBoxType = new System.Windows.Forms.CheckBox();
            this.btnMaxChart = new System.Windows.Forms.Button();
            this.picBoxXLS = new System.Windows.Forms.PictureBox();
            this.lblExportXLS = new System.Windows.Forms.Label();
            this.panelExport = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chartSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxXLS)).BeginInit();
            this.panelExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartSeries
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSeries.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSeries.Legends.Add(legend1);
            this.chartSeries.Location = new System.Drawing.Point(14, 21);
            this.chartSeries.Margin = new System.Windows.Forms.Padding(0);
            this.chartSeries.Name = "chartSeries";
            this.chartSeries.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Close";
            this.chartSeries.Series.Add(series1);
            this.chartSeries.Size = new System.Drawing.Size(406, 128);
            this.chartSeries.TabIndex = 27;
            this.chartSeries.Text = "chart1";
            // 
            // lblOverview
            // 
            this.lblOverview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOverview.Location = new System.Drawing.Point(14, 156);
            this.lblOverview.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOverview.Name = "lblOverview";
            this.lblOverview.Size = new System.Drawing.Size(407, 95);
            this.lblOverview.TabIndex = 28;
            this.lblOverview.Click += new System.EventHandler(this.lblOverview_Click);
            // 
            // dataGridMain
            // 
            this.dataGridMain.AllowUserToAddRows = false;
            this.dataGridMain.AllowUserToDeleteRows = false;
            this.dataGridMain.BackgroundColor = System.Drawing.Color.White;
            this.dataGridMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col1_date,
            this.col2_open,
            this.col3_high,
            this.col4_low,
            this.col5_close,
            this.col6_volume});
            this.dataGridMain.Location = new System.Drawing.Point(14, 252);
            this.dataGridMain.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridMain.Name = "dataGridMain";
            this.dataGridMain.ReadOnly = true;
            this.dataGridMain.RowHeadersVisible = false;
            this.dataGridMain.RowHeadersWidth = 82;
            this.dataGridMain.RowTemplate.Height = 33;
            this.dataGridMain.Size = new System.Drawing.Size(406, 135);
            this.dataGridMain.TabIndex = 29;
            // 
            // col1_date
            // 
            this.col1_date.HeaderText = "Date";
            this.col1_date.MinimumWidth = 10;
            this.col1_date.Name = "col1_date";
            this.col1_date.ReadOnly = true;
            this.col1_date.Width = 65;
            // 
            // col2_open
            // 
            this.col2_open.HeaderText = "Open";
            this.col2_open.MinimumWidth = 10;
            this.col2_open.Name = "col2_open";
            this.col2_open.ReadOnly = true;
            this.col2_open.Width = 65;
            // 
            // col3_high
            // 
            this.col3_high.HeaderText = "High";
            this.col3_high.MinimumWidth = 10;
            this.col3_high.Name = "col3_high";
            this.col3_high.ReadOnly = true;
            this.col3_high.Width = 65;
            // 
            // col4_low
            // 
            this.col4_low.HeaderText = "Low";
            this.col4_low.MinimumWidth = 10;
            this.col4_low.Name = "col4_low";
            this.col4_low.ReadOnly = true;
            this.col4_low.Width = 65;
            // 
            // col5_close
            // 
            this.col5_close.HeaderText = "Close";
            this.col5_close.MinimumWidth = 10;
            this.col5_close.Name = "col5_close";
            this.col5_close.ReadOnly = true;
            this.col5_close.Width = 65;
            // 
            // col6_volume
            // 
            this.col6_volume.HeaderText = "Volume";
            this.col6_volume.MinimumWidth = 10;
            this.col6_volume.Name = "col6_volume";
            this.col6_volume.ReadOnly = true;
            this.col6_volume.Width = 65;
            // 
            // chBoxType
            // 
            this.chBoxType.AutoSize = true;
            this.chBoxType.Location = new System.Drawing.Point(17, 3);
            this.chBoxType.Name = "chBoxType";
            this.chBoxType.Size = new System.Drawing.Size(78, 17);
            this.chBoxType.TabIndex = 30;
            this.chBoxType.Text = "Chart Type";
            this.chBoxType.UseVisualStyleBackColor = true;
            this.chBoxType.CheckedChanged += new System.EventHandler(this.chBoxType_CheckedChanged);
            // 
            // btnMaxChart
            // 
            this.btnMaxChart.Location = new System.Drawing.Point(101, 0);
            this.btnMaxChart.Name = "btnMaxChart";
            this.btnMaxChart.Size = new System.Drawing.Size(96, 20);
            this.btnMaxChart.TabIndex = 31;
            this.btnMaxChart.Text = "Maximize chart";
            this.btnMaxChart.UseVisualStyleBackColor = true;
            this.btnMaxChart.Click += new System.EventHandler(this.btnMaxChart_Click);
            // 
            // picBoxXLS
            // 
            this.picBoxXLS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxXLS.Image = global::BVC_StockMarket_APP.Properties.Resources.excel;
            this.picBoxXLS.Location = new System.Drawing.Point(3, -1);
            this.picBoxXLS.Name = "picBoxXLS";
            this.picBoxXLS.Size = new System.Drawing.Size(20, 20);
            this.picBoxXLS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxXLS.TabIndex = 33;
            this.picBoxXLS.TabStop = false;
            // 
            // lblExportXLS
            // 
            this.lblExportXLS.AutoSize = true;
            this.lblExportXLS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExportXLS.Location = new System.Drawing.Point(26, 3);
            this.lblExportXLS.Name = "lblExportXLS";
            this.lblExportXLS.Size = new System.Drawing.Size(104, 13);
            this.lblExportXLS.TabIndex = 34;
            this.lblExportXLS.Text = "Export Data to Excel";
            this.lblExportXLS.Click += new System.EventHandler(this.lblExportXLS_Click);
            // 
            // panelExport
            // 
            this.panelExport.Controls.Add(this.picBoxXLS);
            this.panelExport.Controls.Add(this.lblExportXLS);
            this.panelExport.Location = new System.Drawing.Point(17, 392);
            this.panelExport.Name = "panelExport";
            this.panelExport.Size = new System.Drawing.Size(143, 19);
            this.panelExport.TabIndex = 35;
            // 
            // MainChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelExport);
            this.Controls.Add(this.btnMaxChart);
            this.Controls.Add(this.chBoxType);
            this.Controls.Add(this.dataGridMain);
            this.Controls.Add(this.lblOverview);
            this.Controls.Add(this.chartSeries);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainChart";
            this.Size = new System.Drawing.Size(452, 419);
            this.Load += new System.EventHandler(this.MainChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxXLS)).EndInit();
            this.panelExport.ResumeLayout(false);
            this.panelExport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSeries;
        private System.Windows.Forms.Label lblOverview;
        private System.Windows.Forms.DataGridView dataGridMain;
        private System.Windows.Forms.CheckBox chBoxType;
        private System.Windows.Forms.Button btnMaxChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2_open;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3_high;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4_low;
        private System.Windows.Forms.DataGridViewTextBoxColumn col5_close;
        private System.Windows.Forms.DataGridViewTextBoxColumn col6_volume;
        private System.Windows.Forms.PictureBox picBoxXLS;
        private System.Windows.Forms.Label lblExportXLS;
        private System.Windows.Forms.Panel panelExport;
    }
}
