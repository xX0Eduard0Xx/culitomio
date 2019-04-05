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
using AppDePrueba;

namespace ProyVentanasPrueba
{
    public partial class FrmLogin : Form
    {
        //bandera para evitar que se cierre la forma
        bool sePuedeCerrar = false;
        //obj para hacer el login
        UsuarioGral us = new UsuarioGral();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal ven = new frmVentanaPrincipal();

            UsuarioGral resConsulta = us.autentica(txtUs.Text, txtPwd.Text);
            if(resConsulta!=null)
            {
                us = resConsulta;
                //crear instancia de usuario final o Administrador
                if (us.Tipo == TipoUs.ADMINISTRADOR)
                {
                    Administrador us = new Administrador();
                    frmVentanaPrincipal.usSesion = (Administrador)us;
                }
                else
                {
                    frmVentanaPrincipal.usSesion = new UsuarioFinal();
                    frmVentanaPrincipal.usSesion = us;
                }
                //se registra en la bitacora de conexion
                us.log(txtUs.Text);
                //camoabismoq la bandera para que si se cierre la ventana ligin
                sePuedeCerrar = true;
                //cerramos la ventana LIGIN
                this.Close();
            }
            else
            {
                //msgt de error
                MessageBox.Show(this, "Error, " + UsuarioGral.errorLogin, "Error al Autenticar a us "+txtUs.Text+".", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
                e.Cancel = !sePuedeCerrar;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
           
        }

    }
}
