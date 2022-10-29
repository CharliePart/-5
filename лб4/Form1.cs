using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лб4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        double minimum_maximum(double[,] a, out double max)
        {
            double min = max = a[0, 0];
            foreach (double x in a)
            {
                if (max < x) max = x;
                if (min > x) min = x;
            }
            return min;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[,] a = new double[5, 5]; double min, max;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    a[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);

            min = minimum_maximum(a, out max);

            textBox1.Text = min.ToString();
            textBox2.Text = max.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(3);
            for (int i = 0; i < 4; i++) dataGridView2.Columns[i].Width = 70;
            dataGridView2.Width = 285;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double[,] a = new double[3, 4];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    a[i, j] = Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value);
            double max, min;
            min = minimum_maximum(a, out max);
            textBox3.Text = min.ToString();
            textBox4.Text = max.ToString();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


            Random zn = new Random();
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    dataGridView2.Rows[i].Cells[j].Value = Convert.ToString(zn.Next(-100, 100) / 10.0); ;


        }
        void vektor(double[,] a, double[] b)
        {
            for (int i = 0; i < 3; i++)
            {
                b[i] = 0;
                for (int j = 0; j < 4; j++) b[i] += a[i, j];
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            double[,] a = new double[3, 4]; double[] b = new double[3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++) a[i, j] = Convert.ToDouble(dataGridView2.Rows[i].Cells[j].Value);
            richTextBox1.Clear();
            vektor(a, b);
            for (int i = 0; i < 3; i++)
            {
                richTextBox1.Text += b[i].ToString() + "\n";
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); dataGridView3.Rows.Clear();
            dataGridView1.Rows.Add(5); dataGridView3.Rows.Add(5);
            Random zn = new Random();
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(zn.Next(-100, 100) / 10.0);
        }

        void swap(double[,] a)
        {
            double min, max;
            min = minimum_maximum(a, out max);
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    if (a[i, j] == max) a[i, j] = min;
                    else
                        if (a[i, j] == min) a[i, j] = max;
                }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double[,] a = new double[5, 5];
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    a[i, j] = Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);

            swap(a);

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    dataGridView3.Rows[i].Cells[j].Value = a[i, j].ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        double fun(double[] a, out double min)
        {
            double max = min = a[0];
            foreach (int x in a)
            {
                if (x > max) max = x;
                if (x < min) min = x;
            }
            return max;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            double[] mass = new double[11];
            for (int i = 0; i < 11; i++) mass[i] = Convert.ToDouble(richTextBox2.Lines[i]);
            double min, max;
            min = fun(mass, out max);
            textBox5.Text = min.ToString();
            textBox6.Text = max.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox3.Clear();
            int n = 11;
            double[] a = new double[n];
            for (int i = 0; i < n; i++)
                a[i] = Convert.ToDouble(richTextBox2.Lines[i]);
            Array.Sort(a);
            for (int i = 0; i < n; i++)
                richTextBox3.Text += a[i].ToString() + Environment.NewLine;
        }

        int new_mass(double[] a, int n, double[] b)
        {
            double sum = 0;
            int kol = 0;
            for (int i = 0; i < n; i++)
            {
                a[i] = Double.Parse(richTextBox2.Lines[i]);
                sum += a[i];

            }
            sum /= n;

            for (int i = 0; i < n; i++)
            { if (a[i] > sum) kol++; }

            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > sum)
                {
                    b[k] = a[i];
                    k++;
                }
            }

            return kol;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int n = richTextBox2.Lines.GetLength(0);
            int kol;
            double[] a = new double[n], b = new double[n];

            kol = new_mass(a, n, b);
            dataGridView4.Rows.Clear();
            if (kol > 0) dataGridView4.Rows.Add(kol);
            else { MessageBox.Show("Масив пустий"); return; }

            for (int i = 0; i < kol; i++)
                dataGridView4.Rows[i].Cells[0].Value = b[i];

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
