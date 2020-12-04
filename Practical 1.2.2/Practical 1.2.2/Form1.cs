using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_1._2._2
{
    public partial class Form1 : Form
    {
        Course course;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            course = new Course();
            course.SetName(tbCourseName.Text);
            course.SetEc(Convert.ToInt32(tbCourseEC.Text));
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            lblShowInfo.Text = $"Course {course.GetName()} with EC {course.GetEc()}";
        }
    }
}
