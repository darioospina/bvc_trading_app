﻿
namespace BVC_StockMarket_APP
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.btn_ok2 = new System.Windows.Forms.Button();
            this.lblInfobtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ok2
            // 
            this.btn_ok2.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ok2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ok2.Location = new System.Drawing.Point(366, 600);
            this.btn_ok2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_ok2.Name = "btn_ok2";
            this.btn_ok2.Size = new System.Drawing.Size(236, 75);
            this.btn_ok2.TabIndex = 1;
            this.btn_ok2.Text = "Okay!";
            this.btn_ok2.UseVisualStyleBackColor = false;
            this.btn_ok2.Click += new System.EventHandler(this.btn_ok2_Click_1);
            // 
            // lblInfobtn
            // 
            this.lblInfobtn.BackColor = System.Drawing.Color.Transparent;
            this.lblInfobtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfobtn.Location = new System.Drawing.Point(15, 9);
            this.lblInfobtn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInfobtn.Name = "lblInfobtn";
            this.lblInfobtn.Size = new System.Drawing.Size(918, 571);
            this.lblInfobtn.TabIndex = 2;
            this.lblInfobtn.Text = "label1";
            this.lblInfobtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 703);
            this.Controls.Add(this.lblInfobtn);
            this.Controls.Add(this.btn_ok2);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "InfoForm";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ok2;
        private System.Windows.Forms.Label lblInfobtn;
    }
}