using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadorasem2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //variables
        string operador = "";
        double num1 = 0;
        double num2 = 0;
        double memoria = 0;
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScreen.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = "";

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtScreen.TextLength == 1) txtScreen.Text = "0";
            else txtScreen.Text = txtScreen.Text.Substring(0, txtScreen.Text.Length - 1);

        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0")
                txtScreen.Text = "1";
            else
                txtScreen.Text += "1";
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0")
                txtScreen.Text = "2";
            else
                txtScreen.Text += "2";
        }
        private void btnTres_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0")
                txtScreen.Text = "3";
            else
                txtScreen.Text += "3";
        }
        private void btnCuatro_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0")
                txtScreen.Text = "4";
            else
                txtScreen.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0")
                txtScreen.Text = "5";
            else
                txtScreen.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0")
                txtScreen.Text = "6";
            else
                txtScreen.Text += "6";
        }
        private void btnSiete_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0")
                txtScreen.Text = "7";
            else
                txtScreen.Text += "7";
        }
        private void btnOcho_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0")
                txtScreen.Text = "8";
            else
                txtScreen.Text += "8";
        }
        private void btnNueve_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0")
                txtScreen.Text = "9";
            else
                txtScreen.Text += "9";
        }
        private void btnCero_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text != "0")
                txtScreen.Text += "0";
        }
        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtScreen.Text);
            double resultOperation = 0;

            switch (operador)
            {
                case "+":
                    resultOperation = num1 + num2;
                    break;

                case "-":
                    resultOperation = num1 - num2;
                    break;

                case "*":
                    resultOperation = num1 * num2;
                    break;

                case "/":
                    if (num2 != 0) 
                    {
                        resultOperation = num1 / num2;
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por cero.");
                        return;
                    }
                    break;

                case "%":
                    if (num2 != 0)
                    {
                        resultOperation = num1 % num2;
                    }
                    else
                    {
                        MessageBox.Show("No se puede calcular el residuo con divisor cero.");
                        return;
                    }
                    break;
                case "^":

                    resultOperation = Math.Pow(num1, num2);
                    break;

                default:
                    MessageBox.Show("Operación no válida.");
                    return;
            }

            txtScreen.Text = resultOperation.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMplus_Click(object sender, EventArgs e)
        {
            double current = Convert.ToDouble(txtScreen.Text); 
            memoria += current; 
        }

        private void btnMminus_Click(object sender, EventArgs e)
        {
            double current = Convert.ToDouble(txtScreen.Text);
            memoria -= current;
        }
        private void btnMR_Click(object sender, EventArgs e)
        {
            txtScreen.Text = memoria.ToString(); 
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            memoria = 0; 
            txtScreen.Text = "0"; 
        }

        private void btnPot_Click(object sender, EventArgs e)
        {
            operador = "^"; 
            num1 = Convert.ToDouble(txtScreen.Text); 
            txtScreen.Text = "0"; 
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtScreen.Text = Math.PI.ToString();
        }

        private void btnPar1_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "(";
        }

        private void btnPar2_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + ")";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(txtScreen.Text); 
            if (val > 0) 
            {
                txtScreen.Text = Math.Log10(val).ToString(); 
            }
            else 
            {
                MessageBox.Show("Logaritmo solo definido para valores > 0.");
            }
        }

        private void btnRad_Click(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(txtScreen.Text);
            if (val >= 0)
            {
                txtScreen.Text = Math.Sqrt(val).ToString(); 
            }
            else
            {
                MessageBox.Show("No se puede mostrar un radical de un número negativo");
            }
        }

        private void btnOver_Click(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(txtScreen.Text);
            if (val != 0)
            {
                txtScreen.Text = (1.0 / val).ToString(); 
            }
            else
            {
                MessageBox.Show("No se puede hacer una division entre 0");
            }
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(txtScreen.Text);
            if (val < 0 || Math.Floor(val) != val) 
            {
                MessageBox.Show("El Factorial está definido solo para enteros no negativos");
                return;
            }
            if (val > 170)
            {
                MessageBox.Show("El factorial es demasiado grande para calcular con precisión");
                return;
            }

            double result = 1;
            for (int i = 1; i <= (int)val; i++) 
            {
                result *= i;
            }
            txtScreen.Text = result.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
