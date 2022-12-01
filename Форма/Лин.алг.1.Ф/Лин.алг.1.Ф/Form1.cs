using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лин.алг._1.Ф
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            double x1 = 0, y1 = 0, x2 = 0, y2 = 0, x3 = 0, y3 = 0, P = 0, a = 0, b = 0, c = 0;
            try
            {
                x1 = Convert.ToDouble(textBox1.Text);
                y1 = Convert.ToDouble(textBox2.Text);
                x2 = Convert.ToDouble(textBox3.Text);
                y2 = Convert.ToDouble(textBox4.Text);
                x3 = Convert.ToDouble(textBox5.Text);
                y3 = Convert.ToDouble(textBox6.Text);

                a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                b = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
                c = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
                P = a + b + c;

                textBox7.Text = "Периметр: " + P;
            }
            catch (Exception ex)
            {
                textBox7.Text = "Только цифры";
            }
        }
    }
}
