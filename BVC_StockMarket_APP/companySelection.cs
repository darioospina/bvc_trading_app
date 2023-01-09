using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BVC_StockMarket_APP
{
    public partial class companySelection : UserControl
    {
        InformationAPI alphaVantage = new InformationAPI();

        ErrorProvider errorProvider = new ErrorProvider();
        public string selectedSymbol { get; set; }

        public companySelection()
        {
            InitializeComponent();
        }

        private void listBoxBestMatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSymbol = listBoxBestMatches.SelectedItem.ToString();   
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            listBoxBestMatches.Items.Clear();
            string inputSymbol = tboxSearch.Text;
            List<string> bestMatches = alphaVantage.getBestMatches(inputSymbol);
            foreach (var result in bestMatches)
            {
                listBoxBestMatches.Items.Add(result);
            }
        }

        private void tboxSearch_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^\D $");
            if (!Regex.Match(tboxSearch.Text, "^[a-zA-Z]*$").Success)
            {
                MessageBox.Show("Only letters are allowed", "Message");
                tboxSearch.Focus();
                return;
            }
        }
    }
}
