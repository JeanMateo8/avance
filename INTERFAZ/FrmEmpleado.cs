using CNEGOCIOS;
using INTERFAZ.Herramientas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace INTERFAZ
{
    public partial class FrmEmpleado : Form
    {
        Empleado empleado = new Empleado();
        Persona persona = new Persona();
        DataTable dt = new DataTable();
        DataView dv = new DataView();
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        public void limpiarcajas()
        {
            txtidpersona.Clear();
            txtusuario.Clear();
            txtclave.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
            FrmInicio frm1 = new FrmInicio();
            frm1.Show();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            dgvempleados.DataSource = persona.listarActivos();
            btnmodificar.Visible = false;
            //configurando
            dgvempleados.Columns[0].Width = 30;
            dgvempleados.Columns[1].Width = 100;
            dgvempleados.Columns[2].Width = 100;
            dgvempleados.Columns[3].Width = 100;
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (Dialogo.Preguntar("¿Desea Guardar Empleado") == DialogResult.Yes)
            {
                string id = txtidpersona.Text;
                string usuario = txtusuario.Text;
                string clave = txtclave.Text;

                empleado.registrar(id, usuario, clave);
                limpiarcajas();

                MessageBox.Show("Guardado correctamente");

                dgvempleados.DataSource = empleado.listarActivos();
            }
        }

        private void dgvempleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidpersona.Text = dgvempleados.CurrentRow.Cells[0].Value.ToString();
            txtusuario.Text = dgvempleados.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            empleado.modificar(Convert.ToInt16(txtidusuario.Text), txtclave.Text);

            if (Dialogo.Preguntar("¿Estás seguro de hacer cambios?") == DialogResult.Yes)

            dgvempleados.Refresh();
            dgvempleados.DataSource = persona.listarActivos();

            limpiarcajas();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            dgvempleados.DataSource = persona.listarActivos();
            txtidpersona.Enabled = true;
            txtusuario.Enabled = true;
            btnmodificar.Visible = false;
            rbmodificar.Checked = false;
            limpiarcajas();
        }

        private void rbmodificar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbmodificar.Checked == true)
            {
                btnmodificar.Visible = true;
                txtidpersona.Enabled = false;
                txtusuario.Enabled = false;
                dgvempleados.DataSource = empleado.listarActivos();

                txtidpersona.Text = dgvempleados.CurrentRow.Cells[0].Value.ToString();
                txtidusuario.Text = dgvempleados.CurrentRow.Cells[1].Value.ToString();
                txtusuario.Text = dgvempleados.CurrentRow.Cells[2].Value.ToString();
                txtclave.Text = dgvempleados.CurrentRow.Cells[3].Value.ToString();
            }
            

        }
    }
}
