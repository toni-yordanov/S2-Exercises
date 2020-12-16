using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_App
{
    public class Book
    {
        private static int seederID = 100;


        private int id;
        private string title;
        private string author;
        private BookType bookType;
        private string borrowerInfo;
        private bool borrowed;

        public Book(string title, string author, BookType bookType)
        {
            this.title = title;
            this.author = author;
            this.bookType = bookType;
            borrowed = false;
            id = seederID++;
        }

        public int ID
        {
            get { return this.id; }
        }

        public bool Borrowed
        {
            get { return this.borrowed; }
            set { this.borrowed = value; }
        }

        public string BorrowerInfo
        {
            get { return this.borrowerInfo; }
            set
            {
                if (Borrowed)
                {
                    borrowerInfo = value;
                }
                else
                {
                    borrowerInfo = "No info";
                }
            }
        }

        public string GetInfo()
        {
            if (borrowed)
            {
                return $"ID:{id}, Title:{title}, Author:{author}, BookType: {bookType}, Borrowed by:{borrowerInfo}";
            }
            else
            {
                return $"ID: {id}, Title: {title}, Author:{author},BookType:{bookType}"; 
            }
            
        }
    }
}
