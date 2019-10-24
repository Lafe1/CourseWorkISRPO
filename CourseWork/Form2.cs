using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CourseWork
{
    public partial class Form2 : Form
    {
        const double n = 23;
        const double b = 2000;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            myChart.BringToFront();



            myChart.Series[0].ChartType = SeriesChartType.Line;
            myChart.Series[0].ChartArea = "ChartArea1";
            myChart.Series[0].BorderWidth = 3;
            myChart.Series[0].Color = Color.Blue;

            myChart.Series[1].ChartType = SeriesChartType.Line;
            myChart.Series[1].ChartArea = "ChartArea1";
            myChart.Series[1].BorderWidth = 3;
            myChart.Series[1].Color = Color.Red;

            myChart.Series[0].Points.AddXY(10,10);


        }

        public double functionOne(double x)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += (Math.Pow(-1, i) * Math.Pow(x, i)) / fact(i);
            }
            //double y = 1 - sum;
            return Math.Pow(Math.E, -x);   //заменил функцию по формуле
        }

        public double functionTwo(double x)
        {
            double z = Math.Pow(Math.E, -x) - b;
            return z;
        }

        public double fact(int n)
        {
            
            int factorial = 1;   // значение факториала

            for (int i = 1; i <= n; i++) 
            {
                factorial *= i;
            }
            return factorial;
        }

        private void myChart_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                myChart.Series[0].Points.Clear();
                myChart.Series[1].Points.Clear();

                for (double x = Convert.ToDouble(textBox1.Text); x <= Convert.ToDouble(textBox2.Text); x += 1)
                {
                    if (x<20) myChart.Series[0].Points.AddXY(x, functionOne(x));
                    else label7.Visible = true;
                }

                for (double x = Convert.ToDouble(textBox3.Text); x <= Convert.ToDouble(textBox4.Text); x += 1)
                {
                    if (x < 20) myChart.Series[1].Points.AddXY(x, functionTwo(x));
                    else label7.Visible = true;
                    

                }
            }
            catch (OverflowException)
            {
                label7.Visible = true;
            }

        }
    }
}
