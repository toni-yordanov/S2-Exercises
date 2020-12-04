using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Aplication
{
    public class Car
    {
        private string brand;
        private int currentSpeed;
        private int maxSpeed;


        public int GetCurrentSpeed()
        {
            return currentSpeed;
        }

        public int GetMaxSpeed()
        {
            return maxSpeed;
        }

        public void Accelerate()
        {
            if((currentSpeed + 7) < maxSpeed)
            {
                currentSpeed += 7;
            }
            else
            {
                currentSpeed = maxSpeed;
            }
        }

        public void Stop()
        {   
            if((currentSpeed - 10) < 0)
            {
                currentSpeed = 0;
            }
            else
            {
                currentSpeed -= 10;
            }
        }

        public string GetInfo()
        {
            return $"The {brand} current speed is {currentSpeed} kmh and its max speed is {maxSpeed} kmh";
        }
        public Car(string brand, int currentSpeed, int maxSpeed)
        {
            this.brand = brand;
            this.currentSpeed = currentSpeed;
            this.maxSpeed = maxSpeed;
        }

    }
}
