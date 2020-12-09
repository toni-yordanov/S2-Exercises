using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_Week14_Reservation
{
    public partial class Form1 : Form
    {
        List<Reservation> reservations = new List<Reservation>();
        Reservation reservation;
        Room room;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cbxType.DataSource = Enum.GetValues(typeof(RoomType));
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            reservation = new Reservation(tbName.Text, Convert.ToInt32(tbNrNights.Text));
            if (cbSmoker.Checked)
            {
               room = reservation.AddRoom((RoomType)cbxType.SelectedItem , true);
            }
            else
            {
                room = reservation.AddRoom((RoomType)cbxType.SelectedItem, false);
            }
            reservations.Add(reservation);
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            reservation.GetInfo();
        }

        private void btnShowRoom_Click(object sender, EventArgs e)
        {
            room.GetInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reservation.GetTotalPrice();
        }


    }
}
