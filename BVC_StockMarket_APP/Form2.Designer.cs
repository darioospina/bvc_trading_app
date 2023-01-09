
namespace BVC_StockMarket_APP
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.btn_ok = new System.Windows.Forms.Button();
            this.lblHelpbtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Location = new System.Drawing.Point(344, 586);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(236, 75);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "Okay!";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lblHelpbtn
            // 
            this.lblHelpbtn.BackColor = System.Drawing.Color.Transparent;
            this.lblHelpbtn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelpbtn.Location = new System.Drawing.Point(6, 9);
            this.lblHelpbtn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHelpbtn.Name = "lblHelpbtn";
            this.lblHelpbtn.Size = new System.Drawing.Size(918, 571);
            this.lblHelpbtn.TabIndex = 1;
            this.lblHelpbtn.Text = "label1";
            this.lblHelpbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHelpbtn.Click += new System.EventHandler(this.lblHelpbtn_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(941, 673);
            this.Controls.Add(this.lblHelpbtn);
            this.Controls.Add(this.btn_ok);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "HelpForm";
            this.Text = "Help";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lblHelpbtn;
    }
}