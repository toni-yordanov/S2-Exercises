using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14_Practice
{
    public class Car
    {
        private string model;
        private int topSpeed;
        private int speed;

        public Car(string model, int topSpeed, int speed)
        {
            this.model = model;
            this.topSpeed = topSpeed;
            this.speed = speed;
        }

        public string GetModel()
        {
            return this.model;
        }
        public void SetModel(string model)
        {
            this.model = model;
        }

        public void SetTopSpeed(int topSpeed)
        {
            this.topSpeed = topSpeed;
        }

        public void SetSpeed(int speed)
        {
            this.speed = speed;
        }

        public int GetSpeed()
        {
            return this.speed;
        }

        public void Accelerate(int increaseBy)
        {
            if((speed + increaseBy) > topSpeed)
            {
                speed = topSpeed;
            }
            else
            {
                speed += increaseBy;
            }
        }

        public void Break()
        {
            speed = 0;
        }

        public string GetInfo()
        {
            return $"Car model: {model} , is driving with {speed}/{topSpeed} kmh";
        }
    }
}
