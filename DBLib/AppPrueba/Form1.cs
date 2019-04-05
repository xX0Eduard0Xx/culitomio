using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPrueba
{
    public partial class frmPruebaUsuarios : Form
    {
        public frmPruebaUsuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //TO DO: hacer constructor para crear Usuario Final SOLO con sus campos...

            ModUsuarios.UsuarioFinal us = new ModUsuarios.UsuarioFinal(txtNombre.Text, txtApellido.Text, txtDom.Text, txtCel.Text, dtpFechaNac.Value, txtEmail.Text, txtContraseña.Text, checkActivado.Checked);
            if (us.crear())
            {
                MessageBox.Show("El usuario '" + txtNombre.Text + " " + txtApellido.Text + "', fue creado correcto");
            }
            else
            {
                MessageBox.Show("ERROR - El usuario '" + txtNombre.Text + " " + txtApellido.Text + "', NO fue creado correcto. ");
            }
            
        }
    }
}
