using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTERFAZ
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
            Form1 v1 = new Form1();
            v1.Show();
        }

        private void tsmusuario_Click(object sender, EventArgs e)
        {
            FrmPersonas v1 = new FrmPersonas();
            this.Hide();
            v1.ShowDialog();
        }

        private void tsmempleados_Click(object sender, EventArgs e)
        {
            FrmEmpleado v1 = new FrmEmpleado();
            this.Hide(); v1.ShowDialog();
        }

        private void tsmproductos_Click(object sender, EventArgs e)
        {
            FrmProducto v1 = new FrmProducto();
            this.Hide(); v1.ShowDialog();
        }
    }
    
}
