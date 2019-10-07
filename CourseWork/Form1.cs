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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // //создаем элемент Chart

           // //кладем его на форму и растягиваем на все окно.
           //// myChart.Parent = this;
           //// myChart.Dock = DockStyle.Fill;
           // //добавляем в Chart область для рисования графиков, их может быть
           // //много, поэтому даем ей имя.
           // myChart.ChartAreas.Add(new ChartArea("Math functions"));
            
           // //Создаем и настраиваем набор точек для рисования графика, в том
           // //не забыв указать имя области на которой хотим отобразить этот
           // //набор точек.
           // Series mySeriesOfPoint = new Series("function one");
           // Series mySeriesOfPoint2 = new Series("function two");

           // mySeriesOfPoint.ChartType = SeriesChartType.Line;
           // mySeriesOfPoint.ChartArea = "Math functions";
           // mySeriesOfPoint.BorderWidth = 3;
           // mySeriesOfPoint.Color = Color.Blue;

           // mySeriesOfPoint2.ChartType = SeriesChartType.Line;
           // mySeriesOfPoint2.ChartArea = "Math functions";
           // mySeriesOfPoint2.BorderWidth = 3;
           // mySeriesOfPoint2.Color = Color.Red;


           // for (double x = -15; x <= 15; x += 1)
           // {
           //     mySeriesOfPoint.Points.AddXY(x, functionOne(x));
           // }

           // for (double x = -15; x <= 15; x += 1)
           // {
           //     mySeriesOfPoint2.Points.AddXY(x, x);
                
           // }
           // //Добавляем созданный набор точек в Chart
           // myChart.Series.Add(mySeriesOfPoint);
           // myChart.Series.Add(mySeriesOfPoint2);
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
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }
    }
}
