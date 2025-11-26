using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Logic;

namespace View
{
    public partial class Histogram : Form
    {
        private readonly BusinessLogic _logic;

        public Histogram(BusinessLogic logic)
        {
            InitializeComponent();
            _logic = logic;
        }

        private void Histogram_Load(object sender, EventArgs e)
        {
            InitializeChart();
        }

        private void InitializeChart()
        {
            // Получаем данные студентов и группируем по специальности
            var studentData = _logic.ShowTheListOfStudents()
                                    .GroupBy(x => x.Speciality)
                                    .ToDictionary(g => g.Key, g => g.Count());

            // Создаём объект Chart и настраиваем его
            Chart chart = new Chart { Dock = DockStyle.Fill };
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            // Создаём серию данных
            Series series = new Series
            {
                Name = "StudentSeries",
                ChartType = SeriesChartType.Column
            };

            // Добавляем данные в серию
            foreach (var entry in studentData)
            {
                series.Points.AddXY(entry.Key, entry.Value);
            }

            chart.Series.Add(series);

            // Настройка внешнего вида графика
            chart.Titles.Add("Количество студентов по специальностям");
            chart.Series["StudentSeries"].Color = System.Drawing.Color.Blue;
            chart.Series["StudentSeries"].IsValueShownAsLabel = true;

            // Добавляем график на форму
            this.Controls.Add(chart);
        }
    }
}
