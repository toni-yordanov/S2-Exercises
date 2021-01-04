using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_App
{
    public partial class BorrowForm : Form
    {
        Form1 libraryForm;

        public BorrowForm()
        {
            InitializeComponent();
        }

        public BorrowForm(Form1 ParentForm, string bookInfo)
        {
            InitializeComponent();
            libraryForm = ParentForm;
            lblBookInfo.Text = bookInfo;

        }
        private void btnBorrowToBorrower_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(tbBorrowerInfo.Text)))
            {
                libraryForm.SetBorrowerInfo(tbBorrowerInfo.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter the borrowers name");
            }

        }
    }
}