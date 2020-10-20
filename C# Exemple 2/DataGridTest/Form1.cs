using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridTest
{
    public partial class Form1 : Form
    {
        public static int SearchForMax(ref int[] arr, int a = int.MinValue)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (a < arr[i]) a = arr[i];
            }
            return a;
        }
        public static int SearchForMin(ref int[] arr, int a = int.MaxValue)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (a > arr[i]) a = arr[i];
            }
            return a;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelMaxSum.Visible = false;
            buttonSearch.Enabled = false;
            buttonMax.Enabled = false;
            labelFindMax.Visible = false;
            labelFindMin.Visible = false;

        }

        private void ButtonN_Click(object sender, EventArgs e)
        {
        }

        private void ButtonRand_Click(object sender, EventArgs e)
        {
            // dataGridViewMain.BackgroundColor = System.Drawing.Color.Gray;
            for(int i = 0; i < dataGridViewMain.Columns.Count; i++)
            {
                dataGridViewMain.Rows[0].Cells[i].Style.BackColor = System.Drawing.Color.White;
            }

            Random rand = new Random();

            for (int i = 0; i < dataGridViewMain.Columns.Count; i++)
            {
                dataGridViewMain[i, 0].Value = rand.Next(-100, 100);
                dataGridViewMain.ClearSelection();
            }

            labelMaxSum.Visible = false;
            labelFindMax.Visible = false;
            labelFindMin.Visible = false;

        }

        

        private void DataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {

            int[] arr = new int[dataGridViewMain.ColumnCount];
            try
            {

                for (int i = 0; i < dataGridViewMain.ColumnCount; i++)
                {
                    arr[i] = int.Parse(dataGridViewMain[i, 0].Value.ToString());
                }

            }
            catch
            {

                MessageBox.Show("Введіть  лише цифри...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            int index=0;
            int sum = int.MinValue;
            for(int i = 0; i < arr.Length-1; i++)
            {
                if (sum < arr[i] + arr[i + 1])
                {
                    sum = arr[i] + arr[i + 1];
                    index = i;
                }

            }
            labelMaxSum.Text = "Max Summ  = " + Convert.ToString(sum);
            labelMaxSum.ForeColor = System.Drawing.Color.Blue;
            labelMaxSum.Visible = true;
            dataGridViewMain.ClearSelection();
            dataGridViewMain[index, 0].Selected = true;
            dataGridViewMain[index+1, 0].Selected = true;
            

        }

        private void ButtonMax_Click(object sender, EventArgs e)
        {
            int[] arr = new int[dataGridViewMain.ColumnCount + 1];
            try
            {


                for (int i = 0; i < dataGridViewMain.ColumnCount; i++)
                {
                    arr[i] = int.Parse(dataGridViewMain[i, 0].Value.ToString());

                }
            }
            catch
            {
                MessageBox.Show("Будь ласка введіть цифри", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int FindMax = int.MinValue;
            int FindMin = int.MaxValue;
            
            FindMax = SearchForMax(ref arr);
            FindMin = SearchForMin(ref arr);

            labelFindMin.ForeColor = Color.Red;
            labelFindMax.ForeColor = Color.Green;

            labelFindMax.Text ="Max Value = " + Convert.ToString(FindMax);
            labelFindMin.Text ="Min Value = " + Convert.ToString(FindMin);

            labelFindMin.Visible = true;
            labelFindMax.Visible = true;

            for(int i = 0; i < dataGridViewMain.ColumnCount; i++)
            {
                if(Convert.ToInt32(dataGridViewMain[i, 0].Value) == FindMax)  dataGridViewMain.Rows[0].Cells[i].Style.BackColor = System.Drawing.Color.Green;
                if(Convert.ToInt32(dataGridViewMain[i, 0].Value) == FindMin)  dataGridViewMain.Rows[0].Cells[i].Style.BackColor = System.Drawing.Color.Red;
            }

        }

        private void ButtonMin_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDownN_ValueChanged(object sender, EventArgs e)
        {
            buttonSearch.Enabled = true;
            buttonMax.Enabled = true;

            int n = Convert.ToInt32(numericUpDownN.Value);


            dataGridViewMain.ColumnCount = n;
            dataGridViewMain.RowCount = 1;

            for (int i = 0; i < dataGridViewMain.ColumnCount; i++)
            {
                dataGridViewMain.Columns[i].HeaderText = i.ToString();
                dataGridViewMain.Columns[i].Width = 37;

            }
        }
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            dataGridViewMain.Rows.Clear();
            dataGridViewMain.Columns.Clear();

            labelMaxSum.Visible = false;
            buttonSearch.Enabled = false;
            buttonMax.Enabled = false;
            labelFindMax.Visible = false;
            labelFindMin.Visible = false;

            numericUpDownN.Value = 1;
        }
    }
}
