using CNEGOCIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using INTERFAZ.Herramientas;

namespace INTERFAZ
{
    public partial class FrmPersonas : Form
    {
        Persona persona = new Persona ();
        DataTable dt = new DataTable ();
        DataView dv = new DataView ();

        public FrmPersonas()
        {
            InitializeComponent();
        }

        private void cargaDatos()
        {
            dt = persona.listarActivos();
            dgvpersonas.DataSource = dt;
            dgvpersonas.Refresh();
            dv = dt.DefaultView; //conexion entre datatable y dataview

        }

        public void limpiarcajas()
        {
            txtid.Clear();
            txtapellidos.Clear();
            txtnombres.Clear();
            txtdni.Clear();
            txttelefono.Clear();
            txtvalorbuscado.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
            FrmInicio frm1 = new FrmInicio();
            frm1.Show();
        }


        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (Dialogo.Preguntar("¿Desea guardar los datos?") == DialogResult.Yes) 
            {
                string apellidos = txtapellidos.Text;
                string nombres = txtnombres.Text;
                string dni  = txtdni.Text;
                string telefono = txttelefono.Text;

                persona.registrar(apellidos,nombres,dni, telefono);

                dgvpersonas.DataSource = persona.listarActivos();  
            }
            limpiarcajas();
        }

        private void FrmPersonas_Load(object sender, EventArgs e)
        {
            cargaDatos();

            //configurando
            dgvpersonas.Columns[0].Width = 30;
            dgvpersonas.Columns[1].Width = 100;
            dgvpersonas.Columns[2].Width = 100;
            dgvpersonas.Columns[3].Width = 100;
            dgvpersonas.Columns[4].Width = 100;

            dgvpersonas.Columns[0].HeaderText = "ID";
            dgvpersonas.Columns[1].HeaderText = "APELLIDOS";
            dgvpersonas.Columns[2].HeaderText = "NOMBRES";
            dgvpersonas.Columns[3].HeaderText = "DNI";
            dgvpersonas.Columns[4].HeaderText = "TELEFONO";

            dgvpersonas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            persona.Modificar(Convert.ToInt16(txtid.Text), txtapellidos.Text, txtnombres.Text, txtdni.Text, txttelefono.Text);

            if (Dialogo.Preguntar("¿Estás seguro de hacer cambios?") == DialogResult.Yes)
            dgvpersonas.Refresh();
            dgvpersonas.DataSource = persona.listarActivos();

            limpiarcajas();
        }

        private void dgvpersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtapellidos.Text = dgvpersonas.CurrentRow.Cells[1].Value.ToString();
            txtnombres.Text = dgvpersonas.CurrentRow.Cells[2].Value.ToString();
            txtdni.Text = dgvpersonas.CurrentRow.Cells[3].Value.ToString();
            txttelefono.Text = dgvpersonas.CurrentRow.Cells[4].Value.ToString();
            txtid.Text = dgvpersonas.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            cargaDatos();
            limpiarcajas();
        }

        private void txtvalorbuscado_TextChanged(object sender, EventArgs e)
        {
            if (txtvalorbuscado.Text.Trim() != String.Empty)
            {
                dv.RowFilter = "dni like '%" + txtvalorbuscado.Text.Trim() + "%'";
            }
            if (rtnombres.Checked == true)
            {
                dv.RowFilter = "apellidos like '%" + txtvalorbuscado.Text.Trim() + "%'";
            }
            else
            {
                dgvpersonas.ClearSelection();
            }
        }
    }
}
