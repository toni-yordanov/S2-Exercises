using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finances
{
    public partial class Form1 : Form
    {
        FinancialManager manager;
        public Form1()
        {
            InitializeComponent();
            manager = new FinancialManager();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            double amount = Convert.ToDouble(nudAmount.Value);
            Expense expense = new Expense(name, amount);
            manager.AddExpense(expense);
        }

        

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            lbShow.Items.Clear();
            foreach (Expense ex in manager.Expenses)
            {
                lbShow.Items.Add(ex.ToString());
            }
        }

        private void btnShowSameAmount_Click(object sender, EventArgs e)
        {
            lbShow.Items.Clear();
            double amount = Convert.ToDouble(nudShowAmounnt.Value);
            foreach(Expense ex in manager.ShowAmount(amount))
            {
                lbShow.Items.Add(ex.ToString());
            }
        }
    }
}
