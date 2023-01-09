
namespace BVC_StockMarket_APP
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblSymbol = new System.Windows.Forms.Label();
            this.btnWatch = new System.Windows.Forms.Button();
            this.panelChart = new System.Windows.Forms.Panel();
            this.lblHelp2 = new System.Windows.Forms.LinkLabel();
            this.lblHelp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBtnDaily = new System.Windows.Forms.RadioButton();
            this.radioBtnMonthly = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picBoxHelp = new System.Windows.Forms.PictureBox();
            this.picBoxInfo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.companySelection1 = new BVC_StockMarket_APP.companySelection();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.panelChart.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInfo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSymbol
            // 
            this.lblSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol.Location = new System.Drawing.Point(4, 4);
            this.lblSymbol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(0, 46);
            this.lblSymbol.TabIndex = 2;
            this.lblSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWatch
            // 
            this.btnWatch.BackColor = System.Drawing.Color.White;
            this.btnWatch.Location = new System.Drawing.Point(154, 627);
            this.btnWatch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnWatch.Name = "btnWatch";
            this.btnWatch.Size = new System.Drawing.Size(114, 42);
            this.btnWatch.TabIndex = 3;
            this.btnWatch.Text = "Watch";
            this.btnWatch.UseVisualStyleBackColor = false;
            this.btnWatch.Click += new System.EventHandler(this.btnWatch_Click);
            // 
            // panelChart
            // 
            this.panelChart.BackColor = System.Drawing.Color.White;
            this.panelChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChart.Controls.Add(this.lblHelp2);
            this.panelChart.Controls.Add(this.lblHelp);
            this.panelChart.Location = new System.Drawing.Point(408, 79);
            this.panelChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(898, 800);
            this.panelChart.TabIndex = 4;
            this.panelChart.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChart_Paint);
            // 
            // lblHelp2
            // 
            this.lblHelp2.AutoSize = true;
            this.lblHelp2.Location = new System.Drawing.Point(56, 606);
            this.lblHelp2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHelp2.Name = "lblHelp2";
            this.lblHelp2.Size = new System.Drawing.Size(0, 25);
            this.lblHelp2.TabIndex = 1;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Location = new System.Drawing.Point(56, 556);
            this.lblHelp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(0, 25);
            this.lblHelp.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblSymbol);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(408, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 56);
            this.panel1.TabIndex = 7;
            // 
            // radioBtnDaily
            // 
            this.radioBtnDaily.AutoSize = true;
            this.radioBtnDaily.Location = new System.Drawing.Point(46, 12);
            this.radioBtnDaily.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioBtnDaily.Name = "radioBtnDaily";
            this.radioBtnDaily.Size = new System.Drawing.Size(91, 29);
            this.radioBtnDaily.TabIndex = 8;
            this.radioBtnDaily.TabStop = true;
            this.radioBtnDaily.Text = "Daily";
            this.radioBtnDaily.UseVisualStyleBackColor = true;
            this.radioBtnDaily.CheckedChanged += new System.EventHandler(this.radioBtnDaily_CheckedChanged);
            // 
            // radioBtnMonthly
            // 
            this.radioBtnMonthly.AutoSize = true;
            this.radioBtnMonthly.Location = new System.Drawing.Point(46, 56);
            this.radioBtnMonthly.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioBtnMonthly.Name = "radioBtnMonthly";
            this.radioBtnMonthly.Size = new System.Drawing.Size(119, 29);
            this.radioBtnMonthly.TabIndex = 9;
            this.radioBtnMonthly.TabStop = true;
            this.radioBtnMonthly.Text = "Monthly";
            this.radioBtnMonthly.UseVisualStyleBackColor = true;
            this.radioBtnMonthly.CheckedChanged += new System.EventHandler(this.radioBtnMonthly_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioBtnDaily);
            this.panel2.Controls.Add(this.radioBtnMonthly);
            this.panel2.Location = new System.Drawing.Point(96, 513);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 100);
            this.panel2.TabIndex = 10;
            // 
            // picBoxHelp
            // 
            this.picBoxHelp.Image = global::BVC_StockMarket_APP.Properties.Resources.help;
            this.picBoxHelp.Location = new System.Drawing.Point(196, 10);
            this.picBoxHelp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picBoxHelp.Name = "picBoxHelp";
            this.picBoxHelp.Size = new System.Drawing.Size(40, 38);
            this.picBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxHelp.TabIndex = 11;
            this.picBoxHelp.TabStop = false;
            this.picBoxHelp.Click += new System.EventHandler(this.picBoxHelp_Click);
            // 
            // picBoxInfo
            // 
            this.picBoxInfo.Image = global::BVC_StockMarket_APP.Properties.Resources.info;
            this.picBoxInfo.Location = new System.Drawing.Point(144, 10);
            this.picBoxInfo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picBoxInfo.Name = "picBoxInfo";
            this.picBoxInfo.Size = new System.Drawing.Size(40, 38);
            this.picBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxInfo.TabIndex = 5;
            this.picBoxInfo.TabStop = false;
            this.picBoxInfo.Click += new System.EventHandler(this.picBoxInfo_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(142)))), ((int)(((byte)(36)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.picBoxInfo);
            this.panel3.Controls.Add(this.picBoxHelp);
            this.panel3.Location = new System.Drawing.Point(18, 823);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 56);
            this.panel3.TabIndex = 12;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(466, 358);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 25);
            this.lblInfo.TabIndex = 0;
            // 
            // companySelection1
            // 
            this.companySelection1.BackColor = System.Drawing.Color.White;
            this.companySelection1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companySelection1.Location = new System.Drawing.Point(18, 15);
            this.companySelection1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.companySelection1.Name = "companySelection1";
            this.companySelection1.selectedSymbol = null;
            this.companySelection1.Size = new System.Drawing.Size(374, 864);
            this.companySelection1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(195, 766);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(177, 25);
            this.linkLabel1.TabIndex = 27;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "dario-ospina.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.White;
            this.lblAuthor.Location = new System.Drawing.Point(53, 766);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(150, 25);
            this.lblAuthor.TabIndex = 26;
            this.lblAuthor.Text = "Developed by ";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1326, 894);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelChart);
            this.Controls.Add(this.btnWatch);
            this.Controls.Add(this.companySelection1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "BVC Trading App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelChart.ResumeLayout(false);
            this.panelChart.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private companySelection companySelection1;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Button btnWatch;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.PictureBox picBoxInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBtnDaily;
        private System.Windows.Forms.RadioButton radioBtnMonthly;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBoxHelp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.LinkLabel lblHelp2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblAuthor;
    }
}

