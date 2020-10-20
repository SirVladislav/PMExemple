using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathLib;



namespace WinForm01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double a, b, x;
            int check = MyLib.CheckToDouble(textBoxA.Text + textBoxB.Text + textBoxX.Text);
           if(check == 0)
            {
                a = Convert.ToDouble(textBoxA.Text);
                b = Convert.ToDouble(textBoxB.Text);
                x = Convert.ToDouble(textBoxX.Text);
                textBoxRes.Text = Convert.ToString(MyLib.Res(a, b, x));

            }
            else
            {
                string mess = "Введіть лише числа!!!";
                string caption = "ERROR";
                MessageBox.Show(mess, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }
    }
}
