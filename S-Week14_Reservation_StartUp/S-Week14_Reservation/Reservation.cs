using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_Week14_Reservation
{
    public class Reservation
    {
        private int nrSeeder;
        private string name;
        private int numberOfNights;
        List<Room> rooms;
        Room room;

        public Reservation(string name, int numberOfNights)
        {
            this.name = name;
            this.numberOfNights = numberOfNights;
        }

        public void AddRoom()
        {
            nrSeeder++;
            room = new Room(nrSeeder);
            rooms.Add(room);
        }

        public void AddRoom(RoomType type, bool isSmoking)
        {
            nrSeeder++;
            room = new Room(nrSeeder, type, isSmoking);
            rooms.Add(room);
        }

        public double GetTotalPrice()
        {
            return (numberOfNights * room.GetPriceOneNight());
        }

        public string GetInfo()
        {
            return $"Reservation of {name}, whit {nrSeeder} room(s)";
        }
    }
}
