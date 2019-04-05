using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotificarPorEmail;

namespace ProyVentanasPrueba
{
    public partial class FrmEnviarNotificacion : Form
    {
        //instancien el obj del Correo con sus datos, con el constructor sobrecargado
        CorreoElectronico email = new CorreoElectronico();//este manda con la cuenta de mi hosting que cree para el ejemplo
        public FrmEnviarNotificacion()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //se toman los datos del formulario
            if(email.enviarEmail(txtAQuien.Text, txtAsunto.Text, txtMsg.Text))
            {
                MessageBox.Show(this, "Notificación de Correo a '" + txtAQuien.Text + "' enviada...", "Notificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Error, Notificación de Correo a '" + txtAQuien.Text + "' NO enviada..."+this.email.error, "Notificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
