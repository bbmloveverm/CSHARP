using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyPicture.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyPicture.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MyPicture.Visible == true)
            {
                MyPicture.Visible = false;
                button3.Text = "Open";
            }
            else
            {
                MyPicture.Visible = true;
                button3.Text = "close";
            }
        }
    }
}
