using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semana3_gestordetareas
{
    public partial class Form1 : Form
    {
        public class Tarea
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public DateTime Fecha { get; set; }
            public string Lugar { get; set; }
            public string Estado { get; set; }
        }

        List<Tarea> listaTareas = new List<Tarea>();

        public Form1()
        {
            InitializeComponent();

            CmbBusqueda.Items.Clear();
            CmbBusqueda.Items.AddRange(new object[] { "Por codigo", "Por Estado", "Por Rango de Fecha" });
            CmbBusqueda.SelectedIndex = 0;

            dtpDesde.Visible = false;
            dtpHasta.Visible = false;
            CbEstadoBusqueda.Visible = false;
            TxTBuscartareas.Visible = true;

            CbEstadoBusqueda.Items.AddRange(new object[] { "No realizada", "En Proceso", "Terminada" });
            CbEstadoBusqueda.SelectedIndex = 0;
        }

        private void ActualizarGrid()
        {
            DgvMostrartareas.DataSource = null;
            DgvMostrartareas.DataSource = listaTareas;
        }

        private void LimpiarCampos()
        {
            TxCodigotarea.Text = "";
            TxNombretarea.Text = "";
            TxDescripciontarea.Text = "";
            TxLugar.Text = "";
            DtpFechas.Value = DateTime.Now;
            if (CmbEstado.Items.Count > 0)
                CmbEstado.SelectedIndex = 0;
        }

        private bool ValidarCamposParaAgregar()
        {
            if (string.IsNullOrWhiteSpace(TxCodigotarea.Text))
            {
                MessageBox.Show("El código no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxCodigotarea.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxNombretarea.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxNombretarea.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxDescripciontarea.Text))
            {
                MessageBox.Show("La descripción no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxDescripciontarea.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxLugar.Text))
            {
                MessageBox.Show("El lugar no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxLugar.Focus();
                return false;
            }

            if (CmbEstado.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CmbEstado.Focus();
                return false;
            }

            return true;
        }

        private bool ValidarSeleccionParaEditar()
        {
            if (DgvMostrartareas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una tarea para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(TxCodigotarea.Text))
            {
                MessageBox.Show("El código no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposParaAgregar()) return;

            Tarea nueva = new Tarea()
            {
                Codigo = TxCodigotarea.Text,
                Nombre = TxNombretarea.Text,
                Descripcion = TxDescripciontarea.Text,
                Fecha = DtpFechas.Value,
                Lugar = TxLugar.Text,
                Estado = CmbEstado.SelectedItem.ToString()
            };

            listaTareas.Add(nueva);
            ActualizarGrid();
            MessageBox.Show("Tarea agregada correctamente.");

            LimpiarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!ValidarSeleccionParaEditar()) return;

            int index = DgvMostrartareas.SelectedRows[0].Index;

            if (!string.IsNullOrWhiteSpace(TxCodigotarea.Text))
                listaTareas[index].Codigo = TxCodigotarea.Text;

            if (!string.IsNullOrWhiteSpace(TxNombretarea.Text))
                listaTareas[index].Nombre = TxNombretarea.Text;

            if (!string.IsNullOrWhiteSpace(TxDescripciontarea.Text))
                listaTareas[index].Descripcion = TxDescripciontarea.Text;

            if (!string.IsNullOrWhiteSpace(TxLugar.Text))
                listaTareas[index].Lugar = TxLugar.Text;

            listaTareas[index].Fecha = DtpFechas.Value;

            if (CmbEstado.SelectedItem != null)
                listaTareas[index].Estado = CmbEstado.SelectedItem.ToString();

            ActualizarGrid();
            MessageBox.Show("Tarea editada correctamente.");

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvMostrartareas.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("¿Está seguro de eliminar esta tarea?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int index = DgvMostrartareas.SelectedRows[0].Index;
                    listaTareas.RemoveAt(index);
                    ActualizarGrid();
                    MessageBox.Show("Tarea eliminada correctamente.");

                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una tarea para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TxCodigotarea.Text = DgvMostrartareas.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "";
                TxNombretarea.Text = DgvMostrartareas.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "";
                TxDescripciontarea.Text = DgvMostrartareas.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? "";

                if (DgvMostrartareas.Rows[e.RowIndex].Cells[3].Value is DateTime fecha)
                    DtpFechas.Value = fecha;

                TxLugar.Text = DgvMostrartareas.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? "";

                string estado = DgvMostrartareas.Rows[e.RowIndex].Cells[5].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(estado) && CmbEstado.Items.Contains(estado))
                    CmbEstado.SelectedItem = estado;
            }
        }

        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = CmbBusqueda.SelectedItem?.ToString();
            bool esRango = opcion == "Por Rango de Fecha";
            bool esEstado = opcion == "Por Estado";

            TxTBuscartareas.Visible = opcion == "Por codigo";
            CbEstadoBusqueda.Visible = esEstado;
            dtpDesde.Visible = esRango;
            dtpHasta.Visible = esRango;

            TxTBuscartareas.Text = "";
            if (CbEstadoBusqueda.Items.Count > 0)
                CbEstadoBusqueda.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (CmbBusqueda.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de búsqueda.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string opcion = CmbBusqueda.SelectedItem.ToString();

            if (listaTareas == null || listaTareas.Count == 0)
            {
                MessageBox.Show("No hay tareas para buscar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<Tarea> resultados = new List<Tarea>();

            switch (opcion)
            {
                case "Por codigo":
                    string textoCodigo = (TxTBuscartareas.Text ?? "").Trim();
                    if (string.IsNullOrEmpty(textoCodigo))
                    {
                        MessageBox.Show("Ingrese el código a buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    resultados = listaTareas
                        .Where(t => !string.IsNullOrEmpty(t.Codigo) &&
                                    t.Codigo.IndexOf(textoCodigo, StringComparison.OrdinalIgnoreCase) >= 0)
                        .ToList();
                    break;

                case "Por Estado":
                    string textoEstado = (CbEstadoBusqueda.SelectedItem?.ToString() ?? "").Trim();
                    if (string.IsNullOrEmpty(textoEstado))
                    {
                        MessageBox.Show("Seleccione un estado para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    resultados = listaTareas
                        .Where(t => !string.IsNullOrEmpty(t.Estado) &&
                                    t.Estado.Equals(textoEstado, StringComparison.OrdinalIgnoreCase))
                        .ToList();
                    break;

                case "Por Rango de Fecha":
                    DateTime desde = dtpDesde.Value.Date;
                    DateTime hasta = dtpHasta.Value.Date;

                    if (desde > hasta)
                    {
                        MessageBox.Show("La fecha 'Desde' no puede ser mayor que 'Hasta'.", "Error en fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    resultados = listaTareas
                        .Where(t => t.Fecha.Date >= desde && t.Fecha.Date <= hasta)
                        .ToList();
                    break;

                default:
                    resultados = listaTareas.ToList();
                    break;
            }

            DgvMostrartareas.DataSource = null;
            DgvMostrartareas.DataSource = resultados;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
            TxTBuscartareas.Text = "";
            CmbBusqueda.SelectedIndex = 0;
            if (CbEstadoBusqueda.Items.Count > 0)
                CbEstadoBusqueda.SelectedIndex = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
        }
    }
}