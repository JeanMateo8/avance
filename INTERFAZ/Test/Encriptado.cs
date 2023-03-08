using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CryptSharp;

namespace INTERFAZ.Test
{
    public partial class Encriptado : Form
    {
        public Encriptado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String claveoriginal= textBox1.Text;
            string claveencriptada = Crypter.Blowfish.Crypt(claveoriginal);
            textBox2.Text = claveencriptada;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string claveingresada = textBox3.Text;
            bool login = Crypter.CheckPassword(claveingresada, textBox2.Text);
            if (login)
            {
                MessageBox.Show("Acceso permitido");

            }
            else
            {
                MessageBox.Show("Acceso denegado");
            }
        }
    }
}
