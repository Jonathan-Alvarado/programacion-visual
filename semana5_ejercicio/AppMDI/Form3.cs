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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ActualizarListaEstudiantes();
        }

        private void ActualizarListaEstudiantes()
        {
            cmbEstudiantes.Items.Clear();
            foreach (var estudiante in DatosCompartidos.Estudiantes)
            {
                cmbEstudiantes.Items.Add($"{estudiante.Carnet} - {estudiante.Nombre}");
            }

            if (cmbEstudiantes.Items.Count > 0)
            {
                cmbEstudiantes.SelectedIndex = 0;
            }
        }

        private void cmbEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstudiantes.SelectedIndex >= 0)
            {
                var estudiante = DatosCompartidos.Estudiantes[cmbEstudiantes.SelectedIndex];

                txtCarnet.Text = estudiante.Carnet;
                txtNombre.Text = estudiante.Nombre;
                double promedioEstudiante = (double)estudiante.CalcularPromedio();
                txtPromedio.Text = promedioEstudiante.ToString("F2");

                dgvDatos.Rows.Clear();
                foreach (var asig in estudiante.Asignaturas)
                {
                    dgvDatos.Rows.Add(asig.Nombre, asig.Nota.ToString("F2"));
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarListaEstudiantes();
        }
    }
}