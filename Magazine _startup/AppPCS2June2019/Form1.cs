using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week14_MagazineApp
{
    public partial class Form1 : Form
    {
        Magazine m;
        public Form1()
        {
            InitializeComponent();
            this.cbNewstype.SelectedIndex = 4;
            m = new Magazine("Magazine");
            cbNewstype.DataSource = Enum.GetValues(typeof(NewsType));
        }

        private void btnFillMagazineWithSomeNewsItems_Click(object sender, EventArgs e)
        {
            this.m.AddNewsItem("Elton John back in town", "Georgiana Manolache", NewsType.CULTURE); 
            this.m.AddNewsItem("Drinks by Proxy", "Kalina Petrova", NewsType.GOSSIP);   
            this.m.AddNewsItem("More ES stduents, please!", "Gerald Hilderink", NewsType.GOSSIP);           
            this.m.AddNewsItem("New Fontys-building build in 2019? Make it 2020", "Bert van Gestel", NewsType.REGIONAL);            
            this.btnFillMagazineWithSomeNewsItems.Enabled = false;
        }


        private void btnAddNewsitem_Click(object sender, EventArgs e)
        {
            string title = tbTitle.Text;
            string author = tbAuthor.Text;
            NewsType type = (NewsType)cbNewstype.SelectedItem;
            m.AddNewsItem(title, author, type);
        }

        private void btnRemoveNewsItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbIdNewsItem.Text))
            {
                int id = Convert.ToInt32(tbIdNewsItem.Text);
                if (m.RemoveNewsItem(id))
                {
                    MessageBox.Show("Removed Item!");
                }
                else
                {
                    MessageBox.Show("No such item!");
                }
            }
            else
            {
                MessageBox.Show("Enter ID");
            }
            
            
            
        }

        private void btnEditNewsItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbIdNewsItem.Text))
            {
                int id = Convert.ToInt32(tbIdNewsItem.Text);
                if (m.EdditNewsITem(id))
                {
                    foreach (NewsItem n in m.GetNewsItems())
                    {
                        if (n.ID.Equals(id))
                        {
                            EditForm editForm = new EditForm(this, n);
                            editForm.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No such item!");
                }
            }
            else
            {
                MessageBox.Show("Enter ID");
            }
            

        }

        private void btnShowGeneralInfoOfAllNewsItems_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();
            foreach(NewsItem n in m.GetNewsItems())
            {
                lbInfo.Items.Add(n.GetGeneralInfo());
            }  
        }

        private void btnShowRandomNewsItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(m.GetRandomNewsItem());
        }

        public void EditItem(string title, string author, NewsType type, string content, int id)
        {
            foreach(NewsItem n in m.GetNewsItems())
            {
                if (n.ID.Equals(id))
                {
                    n.Title = title;
                    n.Author = author;
                    n.Type = type;
                    n.Content = content;
                }
            }
        }

    }
}
