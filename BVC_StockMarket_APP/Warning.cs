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
    public partial class Warning : Form
    {

        int i = 60;
        public Warning()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCounter.Text = i + " seconds";
            i--;
            if(i<10)
            {
                lblCounter.ForeColor = Color.Red;
            }
            if(i<=0)
            {
                i = 0;
                this.Close();
            }
        }

        private void Warning_Load(object sender, EventArgs e)
        {
            i = 60;
        }
    }
}
