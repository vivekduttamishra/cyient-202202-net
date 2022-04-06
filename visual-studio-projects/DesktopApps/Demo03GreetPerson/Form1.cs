using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo03GreetPerson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void greetEnglishButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;

            string greeting = $"Hello {name}, Welcome to Our App";

            MessageBox.Show(greeting, "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frenchGreetButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;

            string greeting = $"Bonjour {name}, Bienvenue dans notre service";

            MessageBox.Show(greeting, "Bienvenue", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void hindiGreetButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;

            string greeting = $"नमस्ते  {name}, हमारी सेवा में आपका स्वागत है";

            MessageBox.Show(greeting, "स्वागत", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
