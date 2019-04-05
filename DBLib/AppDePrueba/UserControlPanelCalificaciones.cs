using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDePrueba
{
    public partial class UserControlPanelCalificaciones : UserControl
    {
        string tituloGroupBox;
        string calificacionGlobal;
        string calificacionExtra1;
        string calificacionExtra2;
        string comentario;
        public UserControlPanelCalificaciones(string titulo, string calGlobal, string calExtra1, string calExtra2, string comentario)
        {
            InitializeComponent();
            this.tituloGroupBox = titulo;
            this.calificacionGlobal = calGlobal;
            this.calificacionExtra1 = calExtra1;
            this.calificacionExtra2 = calExtra2;
            this.comentario = comentario;
            ///////////////////////
            //pasamos los valores a los controles
            this.txtComentario.Text = this.comentario;
            this.lblCalificacionGlobal.Text = this.calificacionGlobal;
            this.lblCalificacionExtra1.Text = this.calificacionExtra1;
            this.lblCalificacionExtra2.Text = this.calificacionExtra2;

        }

        private void gbCalificacion_Enter(object sender, EventArgs e)
        {

        }
        public UserControlPanelCalificaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuItem[] menuItems = new MenuItem[] { new MenuItem("Modificar Calificacion", clickCalificacion), new MenuItem("Modificar Comentario"), new MenuItem("Eliminar Comentario") };
            ContextMenu buttonMenu = new ContextMenu(menuItems);
            buttonMenu.Show(button1, new System.Drawing.Point());
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
           
            //lblX.Text = this.Location.X.ToString();
            //lblY.Text = this.Location.Y.ToString();
        }

        private void clickCalificacion(object sender, EventArgs e)
        {
            this.Hide();
            frmModificarCalifiServicio modificarCali = new frmModificarCalifiServicio(frmVentanaPrincipal.usSesion.Id);
        }
    }
}
