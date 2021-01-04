using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
    public class FinancialManager
    {
        public List<Expense> Expenses { get; set; }

        public FinancialManager()
        {
            
        }

        

        public void AddExpense(Expense expense)
        {
            Expenses.Add(expense);
        }

        public List<Expense> ShowAmount(double amount)
        {
            List<Expense> expenses = new List<Expense>();
            foreach(Expense e in Expenses)
            {
                if (e.Amount.Equals(amount))
                {
                    expenses.Add(e);
                }
            }
            return expenses;
        }
    }
}
