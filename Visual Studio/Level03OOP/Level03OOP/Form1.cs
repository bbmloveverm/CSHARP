using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level03OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StringBuilder stroutput = new StringBuilder("");

            //human Tom = new human();

            //Tom.Age = 200;
            //stroutput.AppendLine("Tom_age =" + Tom.Age);

            human Tom = new human();
            stroutput.AppendLine("Tom_age = "+ Tom.Age );
            Tom.Age = 10;
            stroutput.AppendLine("Tom_age = "+Tom.Age);

            Tom.IncreateAge();
            stroutput.AppendLine("Tom_age = " + Tom.Age);

            int i = 0;
            while (i < 5)
            {
                Tom.IncreateAge();
                stroutput.AppendLine("Tom_age = " + Tom.Age);
                i++;
            }


            loutput.Text= stroutput.ToString();


        }
    }

}
