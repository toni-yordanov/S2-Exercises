using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Snackbar
{
    public class Snack
    {
        private string name;
        private double price;
        private int amountInStock;

        public Snack(string name, double price, int amountInStock)
        {
            this.name = name;
            this.price = price;
            this.amountInStock = amountInStock;
        }

        public bool DecreaseStock(int amount)
        {
            if (amountInStock - amount >= 0)
            {
                amountInStock -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetName()
        {
            return this.name;
        }

        public double GetPrice()
        {
            return this.price;
        }

        public int GetAmountInStock()
        {
            return this.amountInStock;
        }
    }
}
