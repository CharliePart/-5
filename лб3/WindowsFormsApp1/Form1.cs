using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //реалізує сортування елементів масиву за зростанням
        {
            richTextBox2.Clear();
            int n = 11;
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
                a[i] = Convert.ToDouble(richTextBox1.Lines[i]);
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (a[i] > a[j])
                    {
                        double tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
            for (int i = 0; i < n; i++)
                richTextBox2.Text += a[i].ToString() + Environment.NewLine;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = richTextBox1.Lines.GetLength(0);
            double sum = 0;
            int kol = 0;
            int[] a = new int[n], b = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(richTextBox1.Lines[i]);
                sum += a[i];

            }
            sum /= n;

            for (int i = 0; i < n; i++)
            {
                if (a[i] > sum)
                {
                    kol++;
                }
            }
            dataGridView1.Rows.Clear();
            if (kol > 0) dataGridView1.Rows.Add(kol);
            else { MessageBox.Show("Масив пустий"); return; }
            dataGridView1.Rows[0].Cells[0].Value = sum;
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                    if (a[i] > sum)
                    {
                        b[k] = a[i];
                        dataGridView1.Rows[k].Cells[0].Value = b[k];
                        k++;
                    }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
          
                double[] a = new double[11];
                for (int i = 0; i < 11; i++) a[i] = Convert.ToDouble(richTextBox1.Lines[i]);
                double min = a[0], max = a[0];
                for (int i = 0; i < 11; i++)
                {
                    if (a[i] > max) max = a[i];
                    if (a[i] < min) min = a[i];
                }
            richTextBox4.Text = min.ToString();
            richTextBox5.Text = max.ToString();
            }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
