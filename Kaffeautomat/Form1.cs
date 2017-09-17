using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaffeautomat
{
    public partial class Form1 : Form
    {
        private int countPaid10 = 0;
        private int countPaid5 = 0;
        private int countPaid1 = 0;
        private int countPaid50c = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void AmountToPay()
        {
            lblTotalCost.Text = Payment.SumOfDrinks().ToString();
            lblPayAmount.Text = Payment.AmountToPay().ToString();
        }

        public void UpdateChange()
        {
            lblChange.Text = Payment.CalcChange().ToString();
            lblPaid.Text = Payment.AmountPaid.ToString();
            lblPayAmount.Text = Payment.AmountToPay().ToString();
        }

        private void btnCoke_Click(object sender, EventArgs e)
        {
            AddDrinks.AddCola();
            AmountToPay();
            UpdateChange();
        }

        private void btnFanta_Click(object sender, EventArgs e)
        {
            AddDrinks.AddFanta();
            AmountToPay();
            UpdateChange();
        }

        private void btnSprite_Click(object sender, EventArgs e)
        {
            AddDrinks.AddSprite();
            AmountToPay();
            UpdateChange();
        }

        private void btnKaffe_Click(object sender, EventArgs e)
        {
            AddDrinks.AddCoffe();
            AmountToPay();
            UpdateChange();
        }

        private void btnJuice_Click(object sender, EventArgs e)
        {
            AddDrinks.AddJuice();
            AmountToPay();
            UpdateChange();
        }

        private void btnVatten_Click(object sender, EventArgs e)
        {
            AddDrinks.AddWater();
            AmountToPay();
            UpdateChange();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            
            Payment.AmountPaid += 10;
            countPaid10++;
            lblPay10.Text = countPaid10.ToString();
            UpdateChange();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Payment.AmountPaid += 5;
            countPaid5++;
            lblPay5.Text = countPaid5.ToString();
            UpdateChange();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Payment.AmountPaid += 1;
            countPaid1++;
            lblPay1.Text = countPaid1.ToString();
            UpdateChange();
        }

        private void btn50c_Click(object sender, EventArgs e)
        {
            Payment.AmountPaid += .5;
            countPaid50c++;
            lblPay50c.Text = countPaid50c.ToString();
            UpdateChange();
            
        }
      
    }
}
