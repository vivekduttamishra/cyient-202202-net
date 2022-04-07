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
    public partial class BookMainForm : Form
    {
        Book book;
        BookManager manager=new BookManager();
        List<string> isbns;
        string path = null;
        string filter = "Books Data Base|*.bdb|All Files|*.*||";
        int index = 0;
        bool modified = false;

        public BookMainForm()
        {
            InitializeComponent();
            isbns = manager.GetIsbns();

            UpdateUI();

        }

        private void ShowBookInfo()
        {
            

            if (isbns.Count > 0)
            {
                var isbn = isbns[index];
                book = manager.GetBookByIsbn(isbn);
            } else
            {
                book = new Book();
            }
                
            bookTitleLabel.Text = book.Title;
            authorTextBox.Text = book.Author;
            priceTextBox.Text = book.Price.ToString();
            ratingTextBox.Text = book.Rating.ToString();
            descriptionTextBox.Text = book.Description;
            isbnTextBox.Text = book.Isbn;
            coverImage.ImageLocation = book.Cover;
        }

       
        private void UpdateUI()
        {
           

            ShowBookInfo();

            if (isbns.Count == 0)
            {
                statusLabel.Text = "No Books Available.";                
            } else
            {
                statusLabel.Text = $"{index + 1} of {isbns.Count}";
            }

            
            moveToFirstButton.Enabled = index > 0;
            moveToPreviousButton.Enabled = index > 0;
            moveToNextButton.Enabled = index < isbns.Count-1;
            moveToLastButton.Enabled = index < isbns.Count - 1;

        }

        private void moveToFirstButton_Click(object sender, EventArgs e)
        {
            index = 0;
            UpdateUI();
        }


        private void moveToPreviousButton_Click(object sender, EventArgs e)
        {
            if(index>0)
            {
                index--;
                UpdateUI();
            }
        }

        private void moveTonextButton_Click(object sender, EventArgs e)
        {
           //update UI if you are not already on the last book
           if(index< isbns.Count-1)
            {
                index++;
                UpdateUI();
            }
        }

        private void moveToLastButton_Click(object sender, EventArgs e)
        {
            index = isbns.Count - 1;
            UpdateUI();

        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            var editor = new BookEditor();
            var result= editor.ShowDialog();
            if (result == DialogResult.OK)
            {
                statusLabel.Text = "Book Saved";
                manager.AddBook(editor.Book);
                isbns = manager.GetIsbns();
                UpdateUI();
                modified = true;

            }
            else
                statusLabel.Text = "Book Add Cancelled";
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Book Manager\nv:1.00", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private bool Save()
        {
            if (path == null)
                path = GetSavePath();

            if (path != null)
            {
                manager.Save(path);
                statusLabel.Text = "Saved to: " + path;
                modified = false;
                return true;
            }
            else
                return false;
        }

        private string GetSavePath()
        {
            var dlg = new SaveFileDialog();
            dlg.Filter =filter;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                path= dlg.FileName;
                return path;
            }
            else
                return null;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = filter;

            if (dlg.ShowDialog() != DialogResult.OK)
                return;

            path = dlg.FileName;

            manager.Load(path);
            index = 0;
            isbns = manager.GetIsbns();
            modified = false;
            UpdateUI();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manager = new BookManager();
            index = 1;
            isbns = manager.GetIsbns();
            modified = false;
            path = null;
            UpdateUI();
        }

        private void BookMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(modified)
            {
                var result = MessageBox.Show("You have unsaved books.\nSave Them Now", "Confirm Quit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (Save())
                    {
                        return; //now we can quite
                    }

                }
                else if (result == DialogResult.No)
                    return; //user don't want to save. let us quit

                //user is not sure. we will not exit
                e.Cancel = true; //cancel exit plan

            }
        }
    }
}
