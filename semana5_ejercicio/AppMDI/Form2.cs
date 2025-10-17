using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIEstudiantes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dgvAsignaturas.Columns.Clear();
            dgvAsignaturas.Columns.Add("Asignatura", "Asignatura");
            dgvAsignaturas.Columns.Add("Nota", "Nota Final");

            // Agregar algunas filas por defecto
            for (int i = 0; i < 5; i++)
            {
                dgvAsignaturas.Rows.Add("", "");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCarnet.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor complete el carnet y nombre del estudiante.");
                return;
            }

            // Verificar si ya existe un estudiante con el mismo carnet
            var estudianteExistente = DatosCompartidos.Estudiantes
                .Find(est => est.Carnet == txtCarnet.Text);

            if (estudianteExistente != null)
            {
                // Actualizar estudiante existente
                estudianteExistente.Nombre = txtNombre.Text;
                estudianteExistente.Asignaturas.Clear();
            }
            else
            {
                // Crear nuevo estudiante
                estudianteExistente = new Estudiante
                {
                    Carnet = txtCarnet.Text,
                    Nombre = txtNombre.Text
                };
                DatosCompartidos.Estudiantes.Add(estudianteExistente);
            }

            // Procesar asignaturas
            foreach (DataGridViewRow fila in dgvAsignaturas.Rows)
            {
                if (fila.Cells[0].Value != null &&
                    !string.IsNullOrWhiteSpace(fila.Cells[0].Value.ToString()) &&
                    fila.Cells[1].Value != null &&
                    double.TryParse(fila.Cells[1].Value.ToString(), out double nota))
                {
                    if (nota >= 0 && nota <= 100)
                    {
                        estudianteExistente.Asignaturas.Add(new Asignatura
                        {
                            Nombre = fila.Cells[0].Value.ToString(),
                            Nota = nota
                        });
                    }
                }
            }

            if (estudianteExistente.Asignaturas.Count == 0)
            {
                MessageBox.Show("Advertencia: No se ingresaron asignaturas válidas.");
            }

            MessageBox.Show($"Datos del estudiante {estudianteExistente.Nombre} guardados correctamente");

            // Limpiar formulario para nuevo ingreso
            txtCarnet.Clear();
            txtNombre.Clear();
            dgvAsignaturas.Rows.Clear();
            ConfigurarDataGridView();
            txtCarnet.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCarnet.Clear();
            txtNombre.Clear();
            dgvAsignaturas.Rows.Clear();
            ConfigurarDataGridView();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}