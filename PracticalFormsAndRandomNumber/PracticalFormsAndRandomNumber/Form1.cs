using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalFormsAndRandomNumber
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnterGrade_Click(object sender, EventArgs e)
        {
            Student student = new Student(tbStudentName.Text, (Grade)cbStudentGrade.SelectedItem);
            foreach(Student s in students)
            {
                if (s.GetName().Equals(student.GetName()))
                {
                    s.AddGrade((Grade)cbStudentGrade.SelectedItem);   
                }
                else
                {
                    students.Add(student);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbStudentGrade.DataSource = Enum.GetValues(typeof(Grade));
        }
    }
}
