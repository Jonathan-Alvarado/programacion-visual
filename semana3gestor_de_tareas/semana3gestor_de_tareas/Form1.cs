using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace semana3gestor_de_tareas
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

            
            CbIntroducir.Visible = true; 
            CbIntroducir.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void ActualizarGrid()
        {
            DgvMostrartareas.DataSource = null;
            DgvMostrartareas.DataSource = listaTareas;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
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
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (DgvMostrartareas.SelectedRows.Count > 0)
            {
                int index = DgvMostrartareas.SelectedRows[0].Index;
                listaTareas[index].Codigo = TxCodigotarea.Text;
                listaTareas[index].Nombre = TxNombretarea.Text;
                listaTareas[index].Descripcion = TxDescripciontarea.Text;
                listaTareas[index].Fecha = DtpFechas.Value;
                listaTareas[index].Lugar = TxLugar.Text;
                listaTareas[index].Estado = CmbEstado.SelectedItem.ToString();

                ActualizarGrid();
                MessageBox.Show("Tarea editada correctamente.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvMostrartareas.SelectedRows.Count > 0)
            {
                int index = DgvMostrartareas.SelectedRows[0].Index;
                listaTareas.RemoveAt(index);
                ActualizarGrid();
                MessageBox.Show("Tarea eliminada correctamente.");
            }
        }

        private void DgvMostrartareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                TxCodigotarea.Text = DgvMostrartareas.Rows[e.RowIndex].Cells[0].Value.ToString();
                TxNombretarea.Text = DgvMostrartareas.Rows[e.RowIndex].Cells[1].Value.ToString();
                TxDescripciontarea.Text = DgvMostrartareas.Rows[e.RowIndex].Cells[2].Value.ToString();
                DtpFechas.Value = (DateTime)DgvMostrartareas.Rows[e.RowIndex].Cells[3].Value;
                TxLugar.Text = DgvMostrartareas.Rows[e.RowIndex].Cells[4].Value.ToString();
                CmbEstado.SelectedItem = DgvMostrartareas.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void CmbBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = CmbBusqueda.SelectedItem?.ToString();
            bool esRango = opcion == "Por Rango de Fecha";

            dtpDesde.Visible = esRango;
            dtpHasta.Visible = esRango;

            if (opcion == "Por Estado")
            {
                
                CbIntroducir.Visible = true;
                CbIntroducir.DropDownStyle = ComboBoxStyle.DropDownList;
                CbIntroducir.Items.Clear();
                CbIntroducir.Items.AddRange(new object[] { "No realizada", "En Proceso", "Terminada" });
                CbIntroducir.SelectedIndex = 0;
            }
            else if (opcion == "Por codigo")
            {
                CbIntroducir.Visible = true;
                CbIntroducir.DropDownStyle = ComboBoxStyle.DropDown;
                CbIntroducir.Items.Clear();
                CbIntroducir.Text = "";
            }
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
                    string textoCodigo = (CbIntroducir.Text ?? "").Trim();
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
                    string textoEstado = (CbIntroducir.Text ?? "").Trim();
                    resultados = listaTareas
                        .Where(t => t.Estado.Equals(textoEstado, StringComparison.OrdinalIgnoreCase))
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
            }

            DgvMostrartareas.DataSource = null;
            DgvMostrartareas.DataSource = resultados;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ActualizarGrid();
            CbIntroducir.Text = "";
            CmbBusqueda.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
    }
}
