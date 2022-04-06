using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo02DesktopAppCode
{
    public class GreetForm : Form
    {
        Button surveyButton;
        public GreetForm()
        {
            this.Text = "Survey App";

            surveyButton = new Button()
            {
                Text = "Survey",
                Size=new Size(200,40),
                Location=new Point(40,130)
            };

            surveyButton.Click += HandleSurvey;

            this.Resize += GreetForm_Resize;

            this.Controls.Add(surveyButton);
            CentralizeButton();
        }

        private void GreetForm_Resize(object sender, EventArgs e)
        {
            CentralizeButton();
        }

        void CentralizeButton()
        {
            int width = Width / 2;
            int height = Height / 2;

            int x = Width / 4;
            int y = Height / 4;

            surveyButton.Location = new Point(x, y);
            surveyButton.Size = new Size(width, height);


        }

        private void HandleSurvey(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World", "Do you Like C#", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
