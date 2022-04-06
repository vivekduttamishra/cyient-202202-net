namespace Demo01HelloWorld
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
            this.greetEnglish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // greetEnglish
            // 
            this.greetEnglish.Location = new System.Drawing.Point(318, 177);
            this.greetEnglish.Name = "greetEnglish";
            this.greetEnglish.Size = new System.Drawing.Size(186, 73);
            this.greetEnglish.TabIndex = 0;
            this.greetEnglish.Text = "Greet";
            this.greetEnglish.UseVisualStyleBackColor = true;
            this.greetEnglish.Click += new System.EventHandler(this.greetEnglish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.greetEnglish);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button greetEnglish;
    }
}

