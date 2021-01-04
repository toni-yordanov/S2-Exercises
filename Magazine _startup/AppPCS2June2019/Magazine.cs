using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14_MagazineApp
{
    public class Magazine
    {
        private string name;

        private List<NewsItem> newsItems;

        public Magazine(string name)
        {
            this.name = name;
            newsItems = new List<NewsItem>();
        }

        public void AddNewsItem(string title, string author, NewsType type)
        {
            NewsItem newsItem = new NewsItem(title, author, type);
            newsItems.Add(newsItem);
        }

        public void AddNewsItem(string title, string author, NewsType type,string content)
        {
            NewsItem newsItem = new NewsItem(title, author, type, content);
            newsItems.Add(newsItem);
        }

        public bool RemoveNewsItem(int id)
        {
            for(int i = 0; i < newsItems.Count; i++)
            {
                if (newsItems.ElementAt(i).ID.Equals(id))
                {
                    newsItems.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public bool EdditNewsITem(int id)
        {
            for (int i = 0; i < newsItems.Count; i++)
            {
                if (newsItems.ElementAt(i).ID.Equals(id))
                {
                    newsItems.ElementAt(i);
                    return true;
                }
            }
            return false;
        }

        public List<NewsItem> GetNewsItems()
        {
            return this.newsItems;
        }

        public string GetRandomNewsItem()
        {
            Random random = new Random();
            int number = random.Next(0, newsItems.Count);
            return newsItems.ElementAt(number).Content;
        }
    }
}
