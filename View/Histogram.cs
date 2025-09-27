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

namespace View
{
    using Logic;
    using System.Diagnostics;

    public partial class Histogram : Form
    {
        public Histogram(Logic data)
        {
            InitializeComponent();
            InitializeChart(data);
        }
        private void InitializeChart(Logic d)
        {
            var studentData = d.ShowTheHistogram().GroupBy(x => x.Speciality).ToDictionary(g => g.Key, g => g.Count());

            Chart chart = new Chart();
            chart.Dock = DockStyle.Fill;

            // Создаем область графика
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            // Создаем серию данных
            Series series = new Series
            {
                Name = "StudentSeries",
                ChartType = SeriesChartType.Column // Тип графика - столбчатая диаграмма
            };

            // Добавляем данные в серию
            foreach (var entry in studentData)
            {
                series.Points.AddXY(entry.Key, entry.Value);
            }

            chart.Series.Add(series);

            // Настройка внешнего вида графика
            chart.Titles.Add("Количество человек по специальностям");
            chart.Series["StudentSeries"].Color = System.Drawing.Color.Blue;
            chart.Series["StudentSeries"].IsValueShownAsLabel = true; // Показывать значения над столбцами

            // Добавляем график на форму
            this.Controls.Add(chart);
        }

        private void Histogram_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
