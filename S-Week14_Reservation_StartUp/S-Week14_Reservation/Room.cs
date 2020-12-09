using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_Week14_Reservation
{
    public class Room
    {
        private int number;
        private RoomType type;
        private bool isSmoking;

        public Room(int nr)
        {
            this.number = nr;
        }
        public Room(int nr, RoomType type, bool isSmoking)
        {
            this.number = nr;
            this.type = type;
            this.isSmoking = isSmoking;
        }

        public double GetPriceOneNight()
        {
            double price = 0;
            if (type.Equals("Single"))
            {
                price = 75;
                if (isSmoking)
                {
                    price += 9.95;
                }
            }
            else if (type.Equals("Normal"))
            {
                price = 100;

            }
            else if (type.Equals("Family"))
            {
                price = 150;

            }
            if (isSmoking)
            {
                price += 9.95;
            }
            return price;
        }

        public string GetInfo()
        {
            if (!isSmoking)
            {
                return $"Room type {type}.";
            }
            else
            {
                return $"Room type + smoking: {type}.";
            }
        }
    }
}
