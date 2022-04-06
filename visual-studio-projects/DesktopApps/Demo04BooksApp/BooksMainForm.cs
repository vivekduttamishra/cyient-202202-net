using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo04BooksApp
{
    public partial class BooksMainForm : Form
    {
        Book book;
        BookManager manager=new BookManager();
        List<string> isbns;
        int index = 0;
        public BooksMainForm()
        {
            InitializeComponent();
            isbns = manager.GetIsbns();

            ShowBookInfo();

        }

        private void ShowBookInfo()
        {
            var isbn = isbns[index];
            book = manager.GetBookByIsbn(isbn);


            bookTitleLabel.Text = book.Title;
            authorTextBox.Text = book.Author;
            priceTextBox.Text = book.Price.ToString();
            ratingTextBox.Text = book.Rating.ToString();
            descriptionTextBox.Text = book.Description;
            isbnTextBox.Text = book.Isbn;
            coverImage.ImageLocation = book.Cover;
        }

        private void moveToFirstButton_Click(object sender, EventArgs e)
        {

        }

        private void moveToPreviousButton_Click(object sender, EventArgs e)
        {

        }

        private void moveTonextButton_Click(object sender, EventArgs e)
        {
            if (index < isbns.Count - 1)
            {
                index++;
                ShowBookInfo();
            }
            else
                Console.Beep(); //emit a beep sound
        }

        private void moveToLastButton_Click(object sender, EventArgs e)
        {

        }
    }
}
