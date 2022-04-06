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
    }
}
