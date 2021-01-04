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
            UpdateListBox("All books :",library.GetAllBooks());
        }

        private void btnShowBooksThatAre_Click(object sender, EventArgs e)
        {
            
            if (rbtnAvailable.Checked)
            {
                UpdateListBox("Books that are avaivable :",library.GetAllAvailableBooks());
            }
            else if(rbtnBorrowed.Checked)
            {
                UpdateListBox("Books that are borrowed :",library.GetAllBorrowedBooks());
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!library.RemoveBook(Convert.ToInt32(tbId.Text)))
            {
                MessageBox.Show("Sorry, no book with the specified id");
            }
            else
            {
                UpdateListBox("All Books :",library.GetAllBooks());
                MessageBox.Show("sucessfully removed!");
            }
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Book book = library.GetBookById(Convert.ToInt32(tbId.Text));

            if(book == null)
            {
                MessageBox.Show("Sorry, no book with the specified id");
            }
            else
            {
                book.Borrowed = false;
                book.BorrowerInfo = "";
            }

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            Book book = library.GetBookById(Convert.ToInt32(tbId.Text));

            if (book == null)
            {
                MessageBox.Show("Sorry, no book with the specified id");
            }
            else
            {
                if(book.Borrowed == false)
                {
                    string bookInfo = book.GetInfo();
                    BorrowForm borrowform = new BorrowForm(this, bookInfo);
                    borrowform.Show();
                }
                else
                {
                    MessageBox.Show("Book already borrowed");
                }

            }

        }

        public void UpdateListBox(string message,List<Book> books)
        {
            lbLibrary.Items.Clear();
            lbLibrary.Items.Add(message);
            foreach (Book b in books)
            {
                lbLibrary.Items.Add(b.GetInfo());
            }
        }
        public void SetBorrowerInfo(string borrower)
        {
            Book book = library.GetBookById(Convert.ToInt32(tbId.Text));
            book.Borrowed = true;
            book.BorrowerInfo = borrower;

            UpdateListBox("All Books :",library.GetAllBooks());
        }
    }
}
