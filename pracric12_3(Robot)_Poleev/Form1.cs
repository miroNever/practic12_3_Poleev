using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pracric12_3_Robot__Poleev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Robot robot1 = new Robot();
            Robot robot2 = new Robot();
            Robot robot3 = new Robot();
            Random rn = new Random();
            int b = rn.Next(0, 100);
            robot1.min(b);
            robot1.kollife = Convert.ToInt32(textBox1.Text);
            label1.Text = $" оличество жизней робота робота1 в начале игры: " + robot1.kollife;
            robot2.kollife = Convert.ToInt32(textBox2.Text);
            label3.Text = $" оличество жизней робота робота2 в начале игры: " + robot2.kollife;
            robot3.kollife = Convert.ToInt32(textBox3.Text);
            label5.Text = $" оличество жизней робота робота3 в начале игры: " + robot3.kollife;
            int a = robot1.kollife;
            robot1.min(robot1.kollife);
            label2.Text = $" оличество жизней робота робота1 после игры: " + Convert.ToString(robot1.GetLife());
            robot2.kol(a, robot1.kollife);
            label4.Text = $" оличество жизней робота робота2 после игры: " + Convert.ToString(robot2.GetLife());
            robot3.kol(a, robot1.kollife);
            label6.Text = $" оличество жизней робота робота3 после игры: " + Convert.ToString(robot3.GetLife());
        }
    }
}