using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHelloWorld_Click(object sender, EventArgs e)
        {
            lblDisplayInfo.Text = "Hello World!";
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is my edited button!");
        }

        private void btnGoodbye_Click(object sender, EventArgs e)
        {
            lblDisplayInfo.Text = "Goodbye Cruel World!";
        }

        private void btnShowPic_Click(object sender, EventArgs e)
        {
            picPC.Visible = true;
        }

        private void btnHidePic_Click(object sender, EventArgs e)
        {
            picPC.Visible = false;
        }

        private void picPC_Click(object sender, EventArgs e)
        {
            picPC.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
