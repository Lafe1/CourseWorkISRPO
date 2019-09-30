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
             //создаем элемент Chart
        Chart myChart = new Chart();
        //кладем его на форму и растягиваем на все окно.
        myChart.Parent = this;
        myChart.Dock = DockStyle.Fill;
        //добавляем в Chart область для рисования графиков, их может быть
        //много, поэтому даем ей имя.
        myChart.ChartAreas.Add(new ChartArea("Math functions"));
        //Создаем и настраиваем набор точек для рисования графика, в том
        //не забыв указать имя области на которой хотим отобразить этот
        //набор точек.
        Series mySeriesOfPoint = new Series("Sinus");
        mySeriesOfPoint.ChartType = SeriesChartType.Line;
        mySeriesOfPoint.ChartArea = "Math functions";
        for (double x = -10; x <= 10; x += 1) 
        {
            mySeriesOfPoint.Points.AddXY(x, function(x));
        }
        //Добавляем созданный набор точек в Chart
        myChart.Series.Add(mySeriesOfPoint);
        }

        public double function(double x)
        {
            double y = Math.Round(Math.Pow(Math.E, (-x)));
            return y;
        }
    }
}
