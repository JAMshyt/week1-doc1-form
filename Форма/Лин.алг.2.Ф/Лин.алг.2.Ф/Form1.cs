using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лин.алг._2.Ф
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public char[] a;
        public char[] check;
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("число не введено");
                return;
            }

            try
            {
                int b = Convert.ToInt32(textBox1.Text);
                string c = Convert.ToString(b);
                check = c.ToCharArray();
                if (check.Length == 2)
                {
                    a = check;
                }
                else if(check.Length < 2)
                {
                    MessageBox.Show("к вашему числу был добавлен'0' , так как вы ввели не двузначное число");
                    textBox1.Text += 0;
                }

                if (check.Length == 3)
                {
                    if (check[0] == '-')
                    {
                        a = check;
                    }
                    else if (check.Length == 2)
                    {
                        a = check;
                    }
                    else
                    {
                        MessageBox.Show("Не двухзначное");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Только цифры");
                return;
            }

            try
            {
                if (a.Length == 3 && -(int.Parse(a[1].ToString()) + int.Parse(a[2].ToString())) % 3 == 0) textBox2.Text = "кратно";
                else if (a.Length == 3) textBox2.Text = "не кратно";
                else if (a.Length == 2 && (int.Parse(a[0].ToString()) + int.Parse(a[1].ToString()) % 3 == 3)) textBox2.Text = "кратно";
                else if (a.Length == 2) textBox2.Text = "не кратно";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
            }
        }

    }
}
