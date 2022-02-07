using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity2_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Activity # 2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // FOR SUM
            txtToTal.Text = (Convert.ToDouble(txtFirstNum.Text) + Convert.ToDouble(txtSecondNum.Text)).ToString();
        }

        private void btnDiff_Click(object sender, EventArgs e)
        {
            // FOR DIFFERENCE
            txtToTal.Text = (Convert.ToDouble(txtFirstNum.Text) - Convert.ToDouble(txtSecondNum.Text)).ToString();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            // FOR PRODUCT
            txtToTal.Text = (Convert.ToDouble(txtFirstNum.Text) * Convert.ToDouble(txtSecondNum.Text)).ToString();
        }

        private void btnQoutient_Click(object sender, EventArgs e)
        {
            // FOR QOUTIENT
            txtToTal.Text = (Convert.ToDouble(txtFirstNum.Text) / Convert.ToDouble(txtSecondNum.Text)).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // FOR CLEAR
            txtFirstNum.Clear();
            txtSecondNum.Clear();
            txtToTal.Clear();
        }
    }
}
