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
        Payment payment = new Payment();
        Drinkvendor drinkvendor = new Drinkvendor();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void AmountToPay()
        {
            lblTotalCost.Text = payment.SumOfDrinks().ToString();
            lblPayAmount.Text = payment.AmountToPay().ToString();
        }

        public void UpdateChange()
        {
            lblChange.Text = payment.CalcChange().ToString();
            lblPaid.Text = payment.AmountPaid.ToString();
            lblPayAmount.Text = payment.AmountToPay().ToString();
        }

        private void btnCoke_Click(object sender, EventArgs e)
        {
            drinkvendor.AddCoke();
            AmountToPay();
            UpdateChange();
        }

        private void btnFanta_Click(object sender, EventArgs e)
        {
            drinkvendor.AddFanta();
            AmountToPay();
            UpdateChange();
        }

        private void btnSprite_Click(object sender, EventArgs e)
        {
            drinkvendor.AddSprite();
            AmountToPay();
            UpdateChange();
        }

        private void btnKaffe_Click(object sender, EventArgs e)
        {
            drinkvendor.AddKaffe();
            AmountToPay();
            UpdateChange();
        }

        private void btnJuice_Click(object sender, EventArgs e)
        {
            drinkvendor.AddJuice();
            AmountToPay();
            UpdateChange();
        }

        private void btnVatten_Click(object sender, EventArgs e)
        {
            drinkvendor.AddVatten();
            AmountToPay();
            UpdateChange();
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            
            payment.AmountPaid += 10;
            countPaid10++;
            lblPay10.Text = countPaid10.ToString();
            UpdateChange();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            payment.AmountPaid += 5;
            countPaid5++;
            lblPay5.Text = countPaid5.ToString();
            UpdateChange();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            payment.AmountPaid += 1;
            countPaid1++;
            lblPay1.Text = countPaid1.ToString();
            UpdateChange();
        }

        private void btn50c_Click(object sender, EventArgs e)
        {
            payment.AmountPaid += .5m;
            countPaid50c++;
            lblPay50c.Text = countPaid50c.ToString();
            UpdateChange();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
