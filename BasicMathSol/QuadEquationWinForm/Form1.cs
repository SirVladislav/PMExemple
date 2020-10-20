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


namespace QuadEquationWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int check = MyLib.CheckToDouble(textBoxA.Text + textBoxB.Text + textBoxC.Text);
            if (check == 0)
            {
                double a;
                double b;
                double c;


                
                a = Convert.ToDouble(textBoxA.Text);
                b = Convert.ToDouble(textBoxB.Text);
                c = Convert.ToDouble(textBoxC.Text);
                
                double d, x1, x2;

                int res = MyLib.Fun(a, b, c, out d, out x1, out x2);

                labelD.Text = "D = " + d;

                if (res == 0)
                {
                    labelRes1.Visible = false;
                    labelRes2.Visible = false;
                    textBoxRes1.Visible = false;
                    textBoxRes2.Visible = false;
                    labelKorenivNema.Visible = true;
                    labelKoreni.Visible = false;
                }
                else if (res == 1)
                {
                    labelRes1.Visible = true;
                    labelRes2.Visible = false;
                    textBoxRes1.Visible = true;
                    textBoxRes2.Visible = false;
                    labelKorenivNema.Visible = false;
                    textBoxRes1.Text = Convert.ToString(x1);
                    labelKoreni.Visible = true;

                }
                else if (res == 2)
                {
                    labelRes1.Visible = true;
                    labelRes2.Visible = true;
                    textBoxRes1.Visible = true;
                    textBoxRes2.Visible = true;
                    labelKorenivNema.Visible = false;
                    textBoxRes1.Text = Convert.ToString(x1);
                    textBoxRes2.Text = Convert.ToString(x2);
                    labelKoreni.Visible = true;
                } 
            }
            else
            {
                string mess = "Введіть лише числа!!!";
                string caption = "ERROR";
                MessageBox.Show(mess, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
                labelKoreni.Visible = false;
            }
            
        }

        private void LabelRes_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxA_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
