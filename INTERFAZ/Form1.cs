using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using CNEGOCIOS;
using CryptSharp;

namespace INTERFAZ
{
    public partial class Form1 : Form
    {
       Empleado empleado = new Empleado();
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("data source=. ;database=sistema_licoreria;user id=sa;password=123456;integrated security=false");
        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            
            conexion.Open();
         
            string consulta = "select * from  empleados where nombreusuario= '" + txtusuario.Text + "' and claveacceso='" + txtclave.Text + "'";
            SqlCommand comando = new SqlCommand(consulta,conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if(lector.HasRows == true)
            {
                FrmInicio inicio = new FrmInicio();
                inicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erro! en los datos.");
                txtclave.Clear();
                txtclave.Focus();
            }

            conexion.Close();
        }

        private void txtclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                conexion.Open();

                string consulta = "select * from  empleados where nombreusuario= '" + txtusuario.Text + "' and claveacceso='" + txtclave.Text + "'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader lector;
                lector = comando.ExecuteReader();

                if (lector.HasRows == true)
                {
                    FrmInicio inicio = new FrmInicio();
                    inicio.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error! en los datos.");
                    txtclave.Clear();
                    txtclave.Focus();
                }

                conexion.Close();
            }
            
            
        }
    }
}
