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
    public partial class frmCalifiServicio : Form
    {
        
        public bool res1 = false;
        public bool res2 = false;
        CalifiServicio caliser;
        public int idServicio;
        public frmCalifiServicio(int idServ)
        {
            //colores
            BackColor = ColorTranslator.FromHtml("#3D236F");
            //btnEstrella1.BackColor = Color.Transparent;

            //fincolores
            InitializeComponent();
            //label1.Text = "0";
            pctBox5Estrellas.Image = imList5Estrellas.Images[0];
            btnEstrella1.Image = AppDePrueba.Properties.Resources.estrella0;
            btnEstrella2.Image = AppDePrueba.Properties.Resources.estrella0;
            caliser = new CalifiServicio();
            this.idServicio = idServ;
            lblCproveedor.Text = "proveer :" + "aqui va el nombre del proveedor" + "trabajo:" + "aqui va el nombre del trabajo";


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 5;
            trackBar1.TickStyle = TickStyle.BottomRight;
            trackBar1.TickFrequency = 1;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //label1.Text = trackBar1.Value.ToString();
            if (trackBar1.Value == 0)
            {
                pctBox5Estrellas.Image = imList5Estrellas.Images[0];
            }
            if (trackBar1.Value == 1)
            {
                pctBox5Estrellas.Image = imList5Estrellas.Images[1];
            }
            if (trackBar1.Value == 2)
            {
                pctBox5Estrellas.Image = imList5Estrellas.Images[2];
            }
            if (trackBar1.Value == 3)
            {
                pctBox5Estrellas.Image = imList5Estrellas.Images[3];
            }
            if (trackBar1.Value == 4)
            {
                pctBox5Estrellas.Image = imList5Estrellas.Images[4];
            }
            if (trackBar1.Value == 5)
            {
                pctBox5Estrellas.Image = imList5Estrellas.Images[5];
            }
        }

        private void btnEstrella1_Click(object sender, EventArgs e)
        {
            if (res1==false)
            {
                btnEstrella1.Image = AppDePrueba.Properties.Resources.estrella1;
                res1 = true;
            }
            else
            {
                btnEstrella1.Image = AppDePrueba.Properties.Resources.estrella0;
                res1 = false;
            }
            
        }

        private void btnEstrella2_Click(object sender, EventArgs e)
        {

            if (res2 == false)
            {
                btnEstrella2.Image = AppDePrueba.Properties.Resources.estrella1;
                res2 = true;
            }
            else
            {
                btnEstrella2.Image = AppDePrueba.Properties.Resources.estrella0;
                res2 = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int califiG = trackBar1.Value;
            int califiD1 = res1?1:0;
            int califiD2 = res2?1:0;
            caliser.Comentario= txtBoxComentario.Text;
            caliser.Calificacion_global = califiG;
            caliser.Calificacion_1= califiD1;
            caliser.Calificacion_2= califiD2;
            caliser.Id_servicio= this.idServicio;
            caliser.FechaCali = DateTime.Now;
            if (caliser.crearCali())
            {
                MessageBox.Show("se quedo registrado exito.....");
                pctBox5Estrellas.Image = imList5Estrellas.Images[0];
                btnEstrella1.Image = AppDePrueba.Properties.Resources.estrella0;
                btnEstrella2.Image = AppDePrueba.Properties.Resources.estrella0;
                txtBoxComentario.Clear();
                trackBar1.Value = 0;
                this.Close();


            }
            else
            {
                MessageBox.Show("sorry vuelve a intentarlo");
            }


            
        }

    }
}


