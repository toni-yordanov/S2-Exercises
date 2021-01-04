using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14_MagazineApp
{
   public class NewsItem
    {
        private static int seederID = 100;
        private int id;
        private string title;
        private string author;
        private NewsType type;
        private string content;

        public NewsItem(string title, string author, NewsType type)
        {
            this.title = title;
            this.author = author;
            this.type = type;
            this.content = "";
            this.id = seederID++;
        }
        public NewsItem(string title, string author, NewsType type, string content)
        {
            this.title = title;
            this.author = author;
            this.type = type;
            this.content = content;
            this.id = seederID++;
        }

        public int ID
        {
            get { return this.id; }
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }

        public string Content
        {
            get { return this.content; }
            set { this.content = value; }
        }

        public NewsType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string GetContent()
        {
            return this.content;
        }

        public string GetGeneralInfo()
        {
            return $"{ID} - {Title} - {Author} - {Content.Split('\n').Count()}";
        }
    }
}
