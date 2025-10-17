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
    public partial class Form1 : Form
    {
        private Form2 form2Instance;
        private Form3 form3Instance;
        private Form4 form4Instance;

        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            if (form2Instance == null || form2Instance.IsDisposed)
            {
                form2Instance = new Form2();
                form2Instance.MdiParent = this;
                form2Instance.WindowState = FormWindowState.Normal;
                form2Instance.Show();
            }
            else
            {
                form2Instance.BringToFront();
                form2Instance.WindowState = FormWindowState.Normal;
            }
        }

        private void btnForm3_Click(object sender, EventArgs e)
        {
            if (form3Instance == null || form3Instance.IsDisposed)
            {
                form3Instance = new Form3();
                form3Instance.MdiParent = this;
                form3Instance.WindowState = FormWindowState.Normal;
                form3Instance.Show();
            }
            else
            {
                form3Instance.BringToFront();
                form3Instance.WindowState = FormWindowState.Normal;
            }
        }

        private void btnForm4_Click(object sender, EventArgs e)
        {
            if (form4Instance == null || form4Instance.IsDisposed)
            {
                form4Instance = new Form4();
                form4Instance.MdiParent = this;
                form4Instance.WindowState = FormWindowState.Normal;
                form4Instance.Show();
            }
            else
            {
                form4Instance.BringToFront();
                form4Instance.WindowState = FormWindowState.Normal;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}