using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseWork
{
    public partial class Form3 : Form
    {
        List<string[]> Memory = new List<string[]>();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.ColumnHeadersVisible = true;


            dataGridView1.Columns[0].Width = 500;
            dataGridView1.Columns[1].Width = 300;

            dataGridView1.Columns[0].HeaderText = "Фамилия И.О.";
            dataGridView1.Columns[1].HeaderText = "Класс";

            //string path = @"C:\Users\la7el\Desktop\все папки\Учеба\4_курс\ИСРПО\Курсовая\CourseWork\CourseWork\bd.txt";
            //string line;
            //using (StreamReader sr = new StreamReader(path))
            //{
            //    line = sr.ReadToEnd();
            //}

            string[] lines = File.ReadAllLines("bd.txt");


            foreach (var str in lines)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                for (int i = 0; i < str.Split(';').Count(); i++)
                    row.Cells[i].Value = str.Split(';')[i];
                dataGridView1.Rows.Add(row);
            }

            
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Memory.Add(new string[2]);
                Memory[Memory.Count - 1][0] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                Memory[Memory.Count - 1][1] = dataGridView1.Rows[i].Cells[1].Value.ToString();
            }

            //MessageBox.Show(line);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (string[] s in Memory)
                dataGridView1.Rows.Add(s);
            

            List<string[]> Student = new List<string[]>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == textBox1.Text)
                {
                    Student.Add(new string[2]);
                    Student[Student.Count - 1][0] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    Student[Student.Count - 1][1] = textBox1.Text;
                }
            }
            //var row = new DataGridViewRow();
            //row.CreateCells(dataGridView1);
            dataGridView1.Rows.Clear();

            //for (int j = 0; j < 2; j++)
            //{
            //    dataGridView1.Rows[j].Cells[0].Value = lines[j];
            //    dataGridView1.Rows[j].Cells[1].Value = textBox1.Text;
            //}

            foreach (string[] s in Student)
                dataGridView1.Rows.Add(s);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Clear();

            dataGridView1.ColumnCount = 2;
            dataGridView1.ColumnHeadersVisible = true;


            dataGridView1.Columns[0].Width = 500;
            dataGridView1.Columns[1].Width = 300;

            dataGridView1.Columns[0].HeaderText = "Название класса";
            dataGridView1.Columns[1].HeaderText = "Кол-во учеников";
            
        }

        private void вывестиСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 2;
            dataGridView1.ColumnHeadersVisible = true;


            dataGridView1.Columns[0].Width = 500;
            dataGridView1.Columns[1].Width = 300;

            dataGridView1.Columns[0].HeaderText = "Фамилия И.О.";
            dataGridView1.Columns[1].HeaderText = "Класс";

            string[] lines = File.ReadAllLines("bd.txt");


            foreach (var str in lines)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridView1);
                for (int i = 0; i < str.Split(';').Count(); i++)
                    row.Cells[i].Value = str.Split(';')[i];
                dataGridView1.Rows.Add(row);
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                Memory.Add(new string[2]);
                Memory[Memory.Count - 1][0] = dataGridView1.Rows[i].Cells[0].Value.ToString();
                Memory[Memory.Count - 1][1] = dataGridView1.Rows[i].Cells[1].Value.ToString();
            }
        }
    }
}
