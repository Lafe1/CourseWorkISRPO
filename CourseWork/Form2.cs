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

            


        }

        public double functionOne(double x)
        {
            double y = Math.Round(Math.Pow(Math.E, (-x)));
            return y;
        }

        private void myChart_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myChart.Series[0].Points.Clear();

            for (double x = Convert.ToDouble(textBox1.Text); x <= Convert.ToDouble(textBox2.Text); x += 1)
            {
                myChart.Series[0].Points.AddXY(x, functionOne(x));
            }

            for (double x = Convert.ToDouble(textBox3.Text); x <= Convert.ToDouble(textBox4.Text); x += 1)
            {
                myChart.Series[1].Points.AddXY(x, x);

            }
        }
    }
}
