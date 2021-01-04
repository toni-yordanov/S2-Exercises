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
    public partial class EditForm : Form
    {
        NewsItem newsItem;
        Form1 magazineForm;
        public EditForm()
        {
            InitializeComponent();
            cbNewstype.DataSource = Enum.GetValues(typeof(NewsType));
        }

        public EditForm(Form1 ParentForm, NewsItem newsItem)
        {
            InitializeComponent();
            cbNewstype.DataSource = Enum.GetValues(typeof(NewsType));
            this.newsItem = newsItem;
            magazineForm = ParentForm;
        }

        private void btnUpdateNewsItem_Click(object sender, EventArgs e)
        {
            string title = tbTitle.Text;
            string author = tbAuthor.Text;
            NewsType type = (NewsType)cbNewstype.SelectedItem;
            string content = richTextBoxContent.Text;

            magazineForm.EditItem(title,author,type,content, newsItem.ID);

            this.Hide();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            tbAuthor.Text = newsItem.Author;
            tbTitle.Text = newsItem.Title;
            cbNewstype.SelectedItem = newsItem.Type;
            richTextBoxContent.Text = newsItem.Content;
        }
    }
}
