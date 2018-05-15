using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void OnFormClick(object sender, EventArgs args)
        {
            //If cursur is on button do stuff
            if (button.CheckClick())
            {
                textBox1.Text = MousePosition.ToString();
            }
            else
            {
                textBox1.Text = "Button not clicked.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button = new Button(300,300,150);
        }
    }
}
