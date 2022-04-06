namespace Demo04BooksApp
{
    partial class BooksMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksMainForm));
            this.bookTitleLabel = new System.Windows.Forms.Label();
            this.coverImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.moveToFirstButton = new System.Windows.Forms.ToolStripButton();
            this.moveToPreviousButton = new System.Windows.Forms.ToolStripButton();
            this.moveTonextButton = new System.Windows.Forms.ToolStripButton();
            this.moveToLastButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.coverImage)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookTitleLabel
            // 
            this.bookTitleLabel.AutoSize = true;
            this.bookTitleLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookTitleLabel.Location = new System.Drawing.Point(59, 44);
            this.bookTitleLabel.Name = "bookTitleLabel";
            this.bookTitleLabel.Size = new System.Drawing.Size(222, 44);
            this.bookTitleLabel.TabIndex = 0;
            this.bookTitleLabel.Text = "Book Title";
            // 
            // coverImage
            // 
            this.coverImage.Location = new System.Drawing.Point(67, 104);
            this.coverImage.Name = "coverImage";
            this.coverImage.Size = new System.Drawing.Size(180, 270);
            this.coverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverImage.TabIndex = 1;
            this.coverImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "ISBN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rating";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(326, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(326, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 29);
            this.label9.TabIndex = 10;
            this.label9.Text = "Description";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorTextBox.Location = new System.Drawing.Point(501, 101);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.ReadOnly = true;
            this.authorTextBox.Size = new System.Drawing.Size(315, 35);
            this.authorTextBox.TabIndex = 12;
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnTextBox.Location = new System.Drawing.Point(501, 152);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.ReadOnly = true;
            this.isbnTextBox.Size = new System.Drawing.Size(148, 35);
            this.isbnTextBox.TabIndex = 13;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingTextBox.Location = new System.Drawing.Point(501, 204);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.ReadOnly = true;
            this.ratingTextBox.Size = new System.Drawing.Size(94, 35);
            this.ratingTextBox.TabIndex = 14;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(501, 249);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(94, 35);
            this.priceTextBox.TabIndex = 15;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionTextBox.Location = new System.Drawing.Point(501, 298);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(354, 106);
            this.descriptionTextBox.TabIndex = 16;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveToFirstButton,
            this.moveToPreviousButton,
            this.moveTonextButton,
            this.moveToLastButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(867, 34);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // moveToFirstButton
            // 
            this.moveToFirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.moveToFirstButton.Image = ((System.Drawing.Image)(resources.GetObject("moveToFirstButton.Image")));
            this.moveToFirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moveToFirstButton.Name = "moveToFirstButton";
            this.moveToFirstButton.Size = new System.Drawing.Size(44, 29);
            this.moveToFirstButton.Text = "|<<";
            this.moveToFirstButton.Click += new System.EventHandler(this.moveToFirstButton_Click);
            // 
            // moveToPreviousButton
            // 
            this.moveToPreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.moveToPreviousButton.Image = ((System.Drawing.Image)(resources.GetObject("moveToPreviousButton.Image")));
            this.moveToPreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moveToPreviousButton.Name = "moveToPreviousButton";
            this.moveToPreviousButton.Size = new System.Drawing.Size(40, 29);
            this.moveToPreviousButton.Text = "<<";
            this.moveToPreviousButton.Click += new System.EventHandler(this.moveToPreviousButton_Click);
            // 
            // moveTonextButton
            // 
            this.moveTonextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.moveTonextButton.Image = ((System.Drawing.Image)(resources.GetObject("moveTonextButton.Image")));
            this.moveTonextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moveTonextButton.Name = "moveTonextButton";
            this.moveTonextButton.Size = new System.Drawing.Size(40, 29);
            this.moveTonextButton.Text = ">>";
            this.moveTonextButton.Click += new System.EventHandler(this.moveTonextButton_Click);
            // 
            // moveToLastButton
            // 
            this.moveToLastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.moveToLastButton.Image = ((System.Drawing.Image)(resources.GetObject("moveToLastButton.Image")));
            this.moveToLastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moveToLastButton.Name = "moveToLastButton";
            this.moveToLastButton.Size = new System.Drawing.Size(44, 29);
            this.moveToLastButton.Text = ">>|";
            this.moveToLastButton.Click += new System.EventHandler(this.moveToLastButton_Click);
            // 
            // BooksMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(this.isbnTextBox);
            this.Controls.Add(this.authorTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coverImage);
            this.Controls.Add(this.bookTitleLabel);
            this.Name = "BooksMainForm";
            this.Text = "Book\'s World";
            ((System.ComponentModel.ISupportInitialize)(this.coverImage)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bookTitleLabel;
        private System.Windows.Forms.PictureBox coverImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton moveToFirstButton;
        private System.Windows.Forms.ToolStripButton moveToPreviousButton;
        private System.Windows.Forms.ToolStripButton moveTonextButton;
        private System.Windows.Forms.ToolStripButton moveToLastButton;
    }
}

