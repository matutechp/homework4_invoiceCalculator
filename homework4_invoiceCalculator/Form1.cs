using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework4_invoiceCalculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            txtDiscAmo.Clear();
            txtDiscPer.Clear();
            txtTotal.Clear();
            float num1;
            if (txtPrice.Text != "")
            {
                if (!float.TryParse(txtPrice.Text, out num1))
                { 
                    MessageBox.Show("Please enter a valid imput");
                    txtPrice.Clear();
                    return;
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPrice.Clear();
            txtDiscAmo.Clear();
            txtDiscPer.Clear();
            txtTotal.Clear();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            float price, percent, discAmo, total;
            string sPercent, sDiscAmo, sTotal;
            price = float.Parse(txtPrice.Text);
            if (price < 0)
            {
                MessageBox.Show("Please enter a valid input");
            }
            else {
                if (price == 0)
                {
                    percent = 0;
                }
                else if (price <= 99)
                {
                    percent = 1;

                }
                else if (price <= 199)
                {
                    percent = 2;
                }
                else if (price <= 299)
                {
                    percent = 3;
                }
                else
                {
                    percent = 4;
                }
                sPercent = percent.ToString();
                percent = percent / 100;
                discAmo = price * percent;
                total = price - discAmo;
                sTotal = total.ToString();
                sDiscAmo = discAmo.ToString();
                txtTotal.Text = "$" + sTotal;
                txtDiscPer.Text = sPercent + ".00%";
                txtDiscAmo.Text = "$" + sDiscAmo;
            }
        }
    }
}
