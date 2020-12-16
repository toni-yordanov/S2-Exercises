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
    public partial class Form1 : Form
    {
        Library library;
        public Form1()
        {
            InitializeComponent();
            library = new Library("The Amazing Fontys Library");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book book;
            if (rbtnProgramming.Checked)
            {
                book = new Book(tbTitle.Text, tbAuthor.Text, (BookType)0);
            }
            else if (rbtnDatabase.Checked)
            {
                book = new Book(tbTitle.Text, tbAuthor.Text, (BookType)1);
            }
            else if (rbtnMiscellaneous.Checked)
            {
                book = new Book(tbTitle.Text, tbAuthor.Text, (BookType)2);
            }
            else
            {
                book = null;
            }
            library.AddBook(book);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            UpdateListBox(library.GetAllBooks());
        }

        private void btnShowBooksThatAre_Click(object sender, EventArgs e)
        {
            
            if (rbtnAvailable.Checked)
            {
                UpdateListBox(library.GetAllAvailableBooks());
            }
            else if(rbtnBorrowed.Checked)
            {
                UpdateListBox(library.GetAllBorrowedBooks());
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            library.RemoveBook(Convert.ToInt32(tbId.Text));
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            foreach (Book b in library.GetAllBorrowedBooks())
            {
                if (b.ID == Convert.ToInt32(tbId.Text) && b.Borrowed == true)
                {
                    b.Borrowed = false;
                }
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            foreach (Book b in library.GetAllAvailableBooks())
            {
                if (b.ID == Convert.ToInt32(tbId.Text) && !b.Borrowed == true)
                {
                    b.Borrowed = true;
                }
            }
            
        }

        public void UpdateListBox(List<Book> books)
        {
            lbLibrary.Items.Clear();
            foreach (Book b in books)
            {
                lbLibrary.Items.Add(b.GetInfo());
            }
        }
    }
}
