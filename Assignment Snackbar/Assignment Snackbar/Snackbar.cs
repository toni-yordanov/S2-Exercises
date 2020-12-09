using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Snackbar
{
    public class Snackbar
    {
        private double revenue;

        Snack snack1;
        Snack snack2;
        Snack snack3;
        public Snackbar(Snack snack1, Snack snack2, Snack snack3)
        {
            this.snack1 = snack1;
            this.snack2 = snack2;
            this.snack3 = snack3;
        }

        public bool ProcesOrder(int samount1, int samount2, int samount3)// samount stands for snack amount
        {
            if (this.snack1.DecreaseStock(samount1) && this.snack2.DecreaseStock(samount2) && this.snack3.DecreaseStock(samount3))
            {
                revenue += (snack1.GetPrice() * samount1) + (snack2.GetPrice() * samount2) + (snack3.GetPrice() * samount3);
                return true;                
            }
            else
            {
                return false;
            }
        }

        public double GetRevenue()
        {
            return this.revenue;
        }
    }
}
