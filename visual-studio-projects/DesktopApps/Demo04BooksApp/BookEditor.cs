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
    public partial class BookEditor : Form
    {

        public Book Book { get; set; }

        public BookEditor()
        {
            InitializeComponent();
            ratingList.Items.Clear();
            for (double i = 1; i <= 5; i += 0.5)
                ratingList.Items.Add(i);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            GetBookInfo();
            this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void BookEditor_Load(object sender, EventArgs e)
        {
            if (Book == null)
                Book = new Book();

            UpdateUI();
        }

        private void UpdateUI()
        {
            titleTextBox.Text = Book.Title;
            authorTextBox.Text = Book.Author;
            priceTextBox.Text = Book.Price.ToString();
            ratingList.SelectedItem = Book.Rating;            
            isbnTextBox.Text = Book.Isbn;
            descriptionTextBox.Text = Book.Description;
            coverTextBox.Text = Book.Cover;
            if (!string.IsNullOrEmpty(Book.Cover))
                coverImage.ImageLocation = Book.Cover;
        }

        public void GetBookInfo()
        {
            Book.Title = titleTextBox.Text;
            Book.Author = authorTextBox.Text;
            Book.Isbn = isbnTextBox.Text;
            Book.Cover = coverTextBox.Text;
            Book.Description = descriptionTextBox.Text;
            Book.Price = int.Parse(priceTextBox.Text);
            if (ratingList.SelectedItem != null)
                Book.Rating = (double)ratingList.SelectedItem;
            else
                Book.Rating = 4;
        }

    }
}
