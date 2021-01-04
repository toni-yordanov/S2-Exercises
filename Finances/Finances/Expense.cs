using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
    public class Expense
    {
        
        public string Name { get; set; }
        public double Amount { get; set; }

        public Expense(string name, double amount)
        {
            Name = name;
            Amount = amount;
        }

        public string ToString()
        {
            return $"{Name} - {Amount}$";
        }

    }
}
