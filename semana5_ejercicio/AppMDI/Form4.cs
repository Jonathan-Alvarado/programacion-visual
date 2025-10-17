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

namespace MDIEstudiantes
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            ConfigurarChart();
        }

        private void ConfigurarChart()
        {
            chart1.Titles.Clear();
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            // Configurar área del chart
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Title = "Estudiantes";
            chartArea.AxisY.Title = "Promedio";
            chartArea.AxisY.Maximum = 100;
            chartArea.AxisY.Minimum = 0;
            chart1.ChartAreas.Add(chartArea);

            // Configurar serie
            Series series = new Series("Promedios");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;
            chart1.Series.Add(series);

            chart1.Titles.Add("Mejores Promedios de Estudiantes");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ActualizarChart();
        }

        private void ActualizarChart()
        {
            if (DatosCompartidos.Estudiantes.Count == 0)
            {
                MessageBox.Show("No hay datos de estudiantes para mostrar.");
                return;
            }

            // Ordenar estudiantes por promedio descendente y tomar los top 10
            var mejoresEstudiantes = DatosCompartidos.Estudiantes
                .OrderByDescending(est => est.CalcularPromedio())
                .Take(10)
                .ToList();

            chart1.Series[0].Points.Clear();

            foreach (var estudiante in mejoresEstudiantes)
            {
                double promedio = (double)estudiante.CalcularPromedio();
                DataPoint point = new DataPoint();
                point.SetValueXY(estudiante.Nombre, promedio);
                point.Label = promedio.ToString("F2");
                point.ToolTip = $"Carnet: {estudiante.Carnet}\nPromedio: {promedio:F2}";
                chart1.Series[0].Points.Add(point);
            }

            // Actualizar estadísticas
            lblTotalEstudiantes.Text = $"Total estudiantes: {DatosCompartidos.Estudiantes.Count}";
            lblMejorPromedio.Text = $"Mejor promedio: {mejoresEstudiantes.First().CalcularPromedio():F2}";
            lblPromedioGeneral.Text = $"Promedio general: {DatosCompartidos.Estudiantes.Average(est => (int)est.CalcularPromedio()):F2}";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarChart();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblTotalEstudiantes_Click(object sender, EventArgs e)
        {

        }
    }
}