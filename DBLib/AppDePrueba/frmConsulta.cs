using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModCalificacion ;

namespace AppDePrueba
{
    public partial class frmConsulta : Form
    {
        Calificacion  cali;
        CalifiServicio caliser;
        CalifiMandado caliman;
        string tabla;
        public frmConsulta()
        {
            InitializeComponent();
            BackColor = ColorTranslator.FromHtml("#71C3B8");
            dgvcalificacion .BackgroundColor = ColorTranslator.FromHtml("#71C3B8");

            //tapConsultaServicio.BackColor = ColorTranslator.FromHtml("#BC3F5A");
            //tabConsultaCapacitacion.BackColor = ColorTranslator.FromHtml("#BC3F5A");
            //tabConsultaMandado.BackColor = ColorTranslator.FromHtml("#BC3F5A");
            groupBox1.ForeColor = ColorTranslator.FromHtml(" #1F0C44");
            dgvcalificacion .Visible = false;
            
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            caliser = new CalifiServicio();
            caliman = new CalifiMandado();
            groupBox1.Text = "Consulta calificacion  ";
        }
        private void cargadatosServi()
        {
            
            cali = new Calificacion (int.Parse(lblCalificacionGlobal.Text), int.Parse(lblCalificacionDetalle1.Text), int.Parse(lblCalificacionDetalle2.Text), txtBoxComentario.Text, dtpcalificacion .Value);
            List<Calificacion> lista = cali.ConsultaVAriosServicios();
            if (lista.Count == 0)
            {
                MessageBox.Show("NO HAY REGISTROS QUE MOSTRAR");
            }
            else
            {
                dgvcalificacion .DataSource = lista;
                dgvcalificacion .Columns[5].DefaultCellStyle.BackColor = Color.Aqua;
                dgvcalificacion .Columns[1].HeaderText = "numero de servicio";
                dgvcalificacion .Columns[2].HeaderText = "calificacion  Global";
                dgvcalificacion .Columns[3].HeaderText = "calificacion  extra 1";
                dgvcalificacion .Columns[4].HeaderText = "calificacion  extra 2";
                dgvcalificacion .Columns[5].HeaderText = "Comentario";
                dgvcalificacion .Columns[6].HeaderText = "Fecha";
            }
        }
        private void cargadatosMandado()
        {
            cali = new Calificacion (int.Parse(lblCalificacionGlobal.Text), int.Parse(lblCalificacionDetalle1.Text), int.Parse(lblCalificacionDetalle2.Text), txtBoxComentario.Text, dtpcalificacion .Value);
            List<Calificacion> lista = cali.ConsultaVAriosMandados();
            if (lista.Count == 0)
            {
                MessageBox.Show("NO HAY REGISTROS QUE MOSTRAR");
            }
            else
            {
                dgvcalificacion .DataSource = lista;
                dgvcalificacion .Columns[5].DefaultCellStyle.BackColor = Color.Aqua;
                dgvcalificacion .Columns[1].HeaderText = "numero de Mandadero";
                dgvcalificacion .Columns[2].HeaderText = "calificacion  Global";
                dgvcalificacion .Columns[3].HeaderText = "calificacion  extra 1";
                dgvcalificacion .Columns[4].HeaderText = "calificacion  extra 2";
                dgvcalificacion .Columns[5].HeaderText = "Comentario";
                dgvcalificacion .Columns[6].HeaderText = "Fecha";
            }

        }

        private void dgvServicio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dgvcalificacion .Rows[e.RowIndex].Cells[0].Value.ToString();
            lblCalificacionGlobal.Text = dgvcalificacion .Rows[e.RowIndex].Cells[2].Value.ToString();
            lblCalificacionDetalle1.Text = dgvcalificacion .Rows[e.RowIndex].Cells[3].Value.ToString();
            lblCalificacionDetalle2.Text = dgvcalificacion .Rows[e.RowIndex].Cells[4].Value.ToString();
            txtBoxComentario.Text = dgvcalificacion .Rows[e.RowIndex].Cells[5].Value.ToString();
            dtpcalificacion .Value = DateTime.Parse(dgvcalificacion .Rows[e.RowIndex].Cells[6].Value.ToString());
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabla=="servicio")
                {
                    if (caliser.eliminarComen(int.Parse(lblId.Text)))
                    {
                        MessageBox.Show("se quedo registrado exito.....");
                        lblCalificacionGlobal.Text = "0";
                        lblCalificacionDetalle1.Text = "0";
                        lblCalificacionDetalle2.Text = "0";
                        txtBoxComentario.Text = " ";
                        cargadatosServi();

                    }
                }
                if (tabla == "mandado")
                {
                    if (caliman.eliminarComen(int.Parse(lblId.Text)))
                    {
                        MessageBox.Show("se quedo registrado exito.....");
                        lblCalificacionGlobal.Text= "0";
                        lblCalificacionDetalle1.Text = "0";
                        lblCalificacionDetalle2.Text = "0";
                        txtBoxComentario.Text = " ";
                        cargadatosMandado();

                    }
                }


            }
            catch (Exception es)
            {

                MessageBox.Show("Error al " + es);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabla = "servicio";
            dgvcalificacion .DataSource = null;
            dgvcalificacion .Visible = true;
            cargadatosServi();
        }

        private void btnConsultaMandado_Click(object sender, EventArgs e)
        {
            tabla = "mandado";
            dgvcalificacion .DataSource = null;
            dgvcalificacion .Visible = true;
            cargadatosMandado();
        }

        private void cmBFiltro_Click(object sender, EventArgs e)
        {
        }

        private void pcbLupa_Click(object sender, EventArgs e)
        {
            cargadatosServi();
        }
    }
}
