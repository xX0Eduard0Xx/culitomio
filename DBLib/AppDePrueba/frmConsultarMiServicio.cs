using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModCalificacion;

namespace AppDePrueba
{
    public partial class frmConsultarMiServicio : Form
    {
        //id del usuario del que consultaremos las calificiaciones
        private int idUsuario;
        public frmConsultarMiServicio(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void frmConsultarMiServicio_Load(object sender, EventArgs e)
        {
            //lista de paneles de calificaciones}
            List<UserControlPanelCalificaciones> listaCalif = new List<UserControlPanelCalificaciones>();
            //lista de calificaciones para controles 
            List<CalifiServicio> listaConsulta = new List<CalifiServicio>();
            //consultar las calificaciones del usuario
            for (int i = 0; i <listaConsulta.Count; i++)
            {
                //hacer cponsulta de calificaciones
                //tomar cada objeto de calificacion y con sus propiedaades vamos a instanciar cada CONTROL DE CALIFICACIONEs
                CalifiServicio calConsulta = new CalifiServicio();
                //listaConsulta = calConsulta.ConsultaVAriosServicios();
                listaCalif.Add(new UserControlPanelCalificaciones("Calif #" + calConsulta.Id, calConsulta.Calificacion_global + "", calConsulta.Calificacion_1+"", calConsulta.Calificacion_2.ToString(), calConsulta.Comentario));
                //listaCalif[i].Height = this.Height + (-200 * i);
               listaCalif[i].Location=new Point(0,190*i);
                
                this.Controls.Add(listaCalif[i]);
            }
        }

        private void frmConsultarMiServicio_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void userControlPanelCalificaciones1_Load(object sender, EventArgs e)
        {

        }
    }
}
