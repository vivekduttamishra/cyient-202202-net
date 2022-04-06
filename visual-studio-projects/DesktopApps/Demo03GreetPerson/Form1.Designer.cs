namespace Demo03GreetPerson
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.greetEnglishButton = new System.Windows.Forms.Button();
            this.frenchGreetButton = new System.Windows.Forms.Button();
            this.hindiGreetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter your Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(270, 99);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(279, 60);
            this.nameTextBox.TabIndex = 1;
            // 
            // greetEnglishButton
            // 
            this.greetEnglishButton.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetEnglishButton.Location = new System.Drawing.Point(50, 205);
            this.greetEnglishButton.Name = "greetEnglishButton";
            this.greetEnglishButton.Size = new System.Drawing.Size(195, 71);
            this.greetEnglishButton.TabIndex = 2;
            this.greetEnglishButton.Text = "Welcome";
            this.greetEnglishButton.UseVisualStyleBackColor = true;
            this.greetEnglishButton.Click += new System.EventHandler(this.greetEnglishButton_Click);
            // 
            // frenchGreetButton
            // 
            this.frenchGreetButton.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frenchGreetButton.Location = new System.Drawing.Point(532, 205);
            this.frenchGreetButton.Name = "frenchGreetButton";
            this.frenchGreetButton.Size = new System.Drawing.Size(195, 71);
            this.frenchGreetButton.TabIndex = 3;
            this.frenchGreetButton.Text = "Bienvenue";
            this.frenchGreetButton.UseVisualStyleBackColor = true;
            this.frenchGreetButton.Click += new System.EventHandler(this.frenchGreetButton_Click);
            // 
            // hindiGreetButton
            // 
            this.hindiGreetButton.Font = new System.Drawing.Font("Impact", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hindiGreetButton.Location = new System.Drawing.Point(302, 205);
            this.hindiGreetButton.Name = "hindiGreetButton";
            this.hindiGreetButton.Size = new System.Drawing.Size(195, 71);
            this.hindiGreetButton.TabIndex = 4;
            this.hindiGreetButton.Text = "स्वागत";
            this.hindiGreetButton.UseVisualStyleBackColor = true;
            this.hindiGreetButton.Click += new System.EventHandler(this.hindiGreetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hindiGreetButton);
            this.Controls.Add(this.frenchGreetButton);
            this.Controls.Add(this.greetEnglishButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button greetEnglishButton;
        private System.Windows.Forms.Button frenchGreetButton;
        private System.Windows.Forms.Button hindiGreetButton;
    }
}

