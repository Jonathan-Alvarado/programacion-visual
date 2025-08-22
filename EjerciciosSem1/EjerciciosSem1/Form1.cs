using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace EjerciciosSem1
{
    public partial class Form1 : Form
    {
        int intentos = 3;
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void ctlogin_Click(object sender, EventArgs e)
        {
            string usuario = tBUsuario.Text;
            string clave = tBContraseña.Text;

            if (usuario != "admin" || clave != "admin123")
            {
                intentos--;

                if (intentos == 0)
                {
                    MessageBox.Show(
                        "A sobrepasado el limite.",
                        "Limite de intentos sobrepasado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    Close();
                }

                MessageBox.Show(
                    $"Credenciales incorrectas, vuelve a intentarlo, te quedan {intentos}.",
                    "Credenciales incorrectas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                MessageBox.Show(
                    $"Inicio de sesion exitoso, bienvenido {usuario}.",
                    "Inicio de sesion exitoso.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                Close();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btclic_Click(object sender, EventArgs e)
        {
            btclic.Text = "TOTAL DE CLICKS: " + (++contador);
        }

        private void btConvertir_Click(object sender, EventArgs e)
        {
            double peso;
            bool confirmweight = double.TryParse(tBpeso.Text, out peso);

            double altura;
            bool confirmheight = double.TryParse(tBaltura.Text, out altura);

            double resultado = peso / (altura * altura);
            tBimc.Text = resultado.ToString("F4");

            tBclasificacion.Text = ClasificarIMC(resultado);
        }

        private string ClasificarIMC(double imc)
        {
            if (imc < 18.5) return "Bajo";
            if (imc < 24.9) return "Normal";
            if (imc < 29.9) return "Sobrepeso";
            return "Obeso";
        }

        private void bTconvert_Click(object sender, EventArgs e)
        {
            double valor;
            bool confirmacion = double.TryParse(tBdato.Text, out valor);
            if (!confirmacion)
            {
                MessageBox.Show("SOLO SE ADMITEN NÚMEROS, NO CARACTERES");
                return;
            }

            string opcion = cBtemps.SelectedItem?.ToString();

            switch (opcion)
            {
                case "Fahrenheit a Celsius":
                    double resultadoC = (valor - 32) * 5 / 9;
                    tBresul.Text = resultadoC.ToString("F2");
                    break;

                case "Celsius a Fahrenheit":
                    double resultadoF = (valor * 9 / 5) + 32;
                    tBresul.Text = resultadoF.ToString("F2");
                    break;

                default:
                    MessageBox.Show("Selecciona una opción de conversión.");
                    break;
            }
        }

        private void cBtemps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tBUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
