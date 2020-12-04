using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Aplication
{
    public partial class Form1 : Form
    {
        bool accelerate;
        Car car;
        public Form1()
        {
            InitializeComponent();
            car = new Car("Ferary", 0, 300) ;
        }

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            accelerate = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            accelerate = false;
        }
        public void UpdateLabel()
        {
            lblInfo.Text = car.GetInfo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (accelerate)
            {
                car.Accelerate();
            }
            else
            {
                car.Stop();
            }
            UpdateLabel();
        }
    }
}
