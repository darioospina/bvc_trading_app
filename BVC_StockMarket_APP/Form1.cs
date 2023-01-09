using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BVC_StockMarket_APP
{
    public partial class Form1 : Form
    {
        private string symbol { get; set; }
        private string time_series { get; set; }
        private string time_series_formatted { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            panelChart.Controls.Clear();

            symbol = companySelection1.selectedSymbol;
            //symbol = "IBM";

            lblSymbol.Text = "Symbol: " + symbol + " - " + time_series_formatted;
            MainChart mainChartX = new MainChart(symbol, time_series);
            panelChart.Controls.Add(mainChartX);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioBtnDaily.Checked = true;
            panelChart.BackColor = Color.White;
        }

        private void radioBtnDaily_CheckedChanged(object sender, EventArgs e)
        {
            time_series = "TIME_SERIES_DAILY_ADJUSTED";
            time_series_formatted = "Daily Series";
        }

        private void radioBtnMonthly_CheckedChanged(object sender, EventArgs e)
        {
            time_series = "TIME_SERIES_MONTHLY";
            time_series_formatted = "Monthly Series";
        }

        private void picBoxInfo_Click(object sender, EventArgs e)
        {
            InfoForm popup = new InfoForm();
            DialogResult dialogResult = popup.ShowDialog();
        }

        private void picBoxHelp_Click(object sender, EventArgs e)
        {
            HelpForm popup = new HelpForm();
            DialogResult dialogResult = popup.ShowDialog();
        }

        private void panelChart_Paint(object sender, PaintEventArgs e)
        {
            Label newLbl = new Label();
            newLbl.Text = "Find information on more than 100,000 shares.";
            newLbl.Font = new Font(newLbl.Font.FontFamily, 15);
            newLbl.Width = 5400;
            newLbl.Location = new Point(20, 150);
            panelChart.Controls.Add(newLbl);
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            panelChart.Controls.Clear();
            lblSymbol.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.dario-ospina.com");
        }
    }
}
