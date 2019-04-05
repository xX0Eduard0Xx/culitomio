using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModUsuarios;

namespace AppPrueba
{
    public partial class FrmCrear : Form
    {
        public FrmCrear()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblConfimacion_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Administrador ad = new Administrador();
            ad.Nombre = txtNombre.Text;
            ad.Apellido = txtApellido.Text;
            ad.Celular = txtCelular.Text;
            ad.Domicilio = txtDomicilio.Text;
            ad.FechaNac = dtpFecha.Value;
            ad.CorreoElectronico = txtEmail.Text;
            ad.Contraseña = txtContraceña.Text;
            ad.Tipo =TipoUs.ADMINISTRADOR;


            if (ad.crear())
            {
                MessageBox.Show("Se creo correctamente el usuario Administador");
            }
            else
            {
                MessageBox.Show("Error al insertar Usuario");
            }                             

        }

        private void chboxActivo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
