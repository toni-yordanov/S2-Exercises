using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Snackbar
{
    public partial class Form1 : Form
    {
        Snackbar snackbar;
        Snack snack1;
        Snack snack2;
        Snack snack3;
        public Form1()
        {
            InitializeComponent();
            snack1 = new Snack("Hamburger", 3.5, 10);
            snack2 = new Snack("Chiken Nugets", 2.6, 100);
            snack3 = new Snack("Fries", 3, 70);
            snackbar = new Snackbar(snack1, snack2, snack3);
            lblSnack1.Text = snack1.GetName();
            lblSnack2.Text = snack2.GetName();
            lblSnack3.Text = snack3.GetName();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int samount1, samount2, samount3;
            samount1 = Convert.ToInt32(tbSnack1.Text);
            samount2 = Convert.ToInt32(tbSnack2.Text);
            samount3 = Convert.ToInt32(tbSnack3.Text);
            double totalPrice;

            if (snackbar.ProcesOrder(samount1, samount2, samount3))
            {
                totalPrice = (samount1 * snack1.GetPrice()) + (samount2 * snack2.GetPrice()) + (samount3 * snack3.GetPrice());
                lblTotalPrice.Text = $"The total price of the order is {totalPrice} €"; 
            }
            else
            {
                MessageBox.Show("Insuficient Stock");
            }
        }

        private void btnGetRevenue_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The total revenue is {snackbar.GetRevenue()} €");
        }
    }
}
