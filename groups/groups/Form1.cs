using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groups
{
    public partial class Form1 : Form
    {
        Group group = new Group("Group");
        Member member = new Member("name", 9);
        
        public Form1()
        {
            InitializeComponent();
            group.members.Add(member);
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            group.AddMember(tbName.Text);
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            lblInfo.Text = group.GetInfo();
        }
    }
}
