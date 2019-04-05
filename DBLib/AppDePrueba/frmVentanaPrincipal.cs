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
using ProyVentanasPrueba;


namespace AppDePrueba
{
    public partial class frmVentanaPrincipal : Form
    {
        
        public static UsuarioGral usSesion = new UsuarioGral();

        public int idUsuario { get; private set; }

        public frmVentanaPrincipal()
        {
            InitializeComponent();
            BackColor = ColorTranslator.FromHtml("#18665B");
            menuStrip1.BackColor = ColorTranslator.FromHtml("#063F37");
            menuStrip1.ForeColor = ColorTranslator.FromHtml("#71C3B8"); 
        }

        private void frmVentanaPrincipal_Load(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Hide();
            login.ShowDialog();
            this.Show();
            //autoenticar al us y guardar obj usuario en sesion
            //mostrar la info de sesion en el panelSesion
            lblSesionNombre.Text = frmVentanaPrincipal.usSesion.Nombre + " " + frmVentanaPrincipal.usSesion.Apellido;
            lblSesionTipo.Text = frmVentanaPrincipal.usSesion.Tipo.ToString();
            //mostrar o esconder opciones de Administrador o Us Final
            //if (frmVentanaPrincipal.usSesion.Tipo == TipoUs.USUARIO_FINAL)
            //{
            //    usuariosToolStripMenuItem.Visible = false;
            //    calificacionesToolStripMenuItem.Visible = false;
            //}
            //else
            //{
            //    usuariosToolStripMenuItem.Visible = true;
            //    calificacionesToolStripMenuItem.Visible = true;
            //}
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        { 
        }

        private void consultarTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void crearMandadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSesionConfig_Click(object sender, EventArgs e)
        {

        }

        private void serviciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultarMiServicio consultami = new frmConsultarMiServicio(idUsuario);
            consultami.Show();


        }
    }
   
}
