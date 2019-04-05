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

namespace ProyVentanasPrueba
{
    public partial class FrmModificacionUusario : Form
    {
        //propiedades
        int idUsuarioSeleccionado = 0;
        UsuarioFinal us;
        public FrmModificacionUusario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            consultaTodos();

        }

        public void consultaTodos()
        {
            //TO DO vamos a hacer la consulta para traer a todos los us registrados
            us = new UsuarioFinal(txtNombre.Text, txtApellido.Text, txtDomicilio.Text, txtCelular.Text, dtpFechaNac.Value, txtEmail.Text, txtContraseña.Text, checkActivo.Checked);
            List<UsuarioFinal> lista = us.consultarTodos();
            if (lista.Count == 0)
            {
                MessageBox.Show("NO HAY REGISTROS QUE MOSTRAR");
                dgvUsuarios.DataSource = null;
                //dgv se limpia
                dgvUsuarios.Rows.Clear();
            }
            else
            {
                dgvUsuarios.DataSource = null;
                //dgv se limpia
                dgvUsuarios.Rows.Clear();
                //vinculamos con lista de resultados
                dgvUsuarios.DataSource = lista;
                //reordenamos vista de columnas
                dgvUsuarios.Columns[1].DisplayIndex = 9;
                dgvUsuarios.Columns[2].DisplayIndex = 8;
                dgvUsuarios.Columns[3].DisplayIndex = 7;
                for (int i = 4; i < 9; i++)
                {
                    dgvUsuarios.Columns[i].DisplayIndex = i - 3;
                }
            } //TO DO pongo todo s los registros en el dgvUsuarios
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtConfimaContra.Text != txtContraseña.Text)
            {
                MessageBox.Show("la contraseña no coincide con su confirmacion...");
                errorFromUsuarios.SetError(txtConfimaContra, "Verifique que la confimaciòn sea igual a la contraseña");
            }
            else
            {
                //TO DO invocar al mètodo modificar de UsuarioFinal con los datos de los textboxes
                us = new UsuarioFinal(txtNombre.Text, txtApellido.Text, txtDomicilio.Text, txtCelular.Text, dtpFechaNac.Value, txtEmail.Text, txtContraseña.Text, checkActivo.Checked);
                //TO DO verificar con un if el resultado del UPDATE... si error.. msg error, si correcto, msg correcto
                if (us.actualizar(txtNombre.Text, txtApellido.Text, txtDomicilio.Text, txtCelular.Text, dtpFechaNac.Value, txtEmail.Text, txtContraseña.Text, checkActivo.Checked, idUsuarioSeleccionado))
                {
                    MessageBox.Show("Usuario modificado correctamente");
                    limpiaForm();
                    consultaTodos();
                }
                else
                {
                    MessageBox.Show("ERROR, verifique sus datos");
                }
                    //TO DO si se hizo correcto limpiar los textboxes... si no... error provider y focus al primer textbox
            }
        }
        public void limpiaForm() {
            foreach (Control ctrl in gbFormModificarUsuarios.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
                checkActivo.Checked = false;
                dtpFechaNac.Value = DateTime.Now;
                comboTipoUs.SelectedItem = TipoUs.USUARIO_FINAL;
            }
        }
        private void checkActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //TO DO capturar el ID de la columna 0 del renglon donde le dio click para modificar al usuario
            idUsuarioSeleccionado = int.Parse(dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString());
            //dgvUsuarios.Columns[0].Visible = false;
            //TO DO cargar todos los contenidos de las celdas a cada TEXTBOX correpondiente
            checkActivo.Checked = bool.Parse(dgvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString());
            if (dgvUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString() == TipoUs.USUARIO_FINAL.ToString())
            {
                comboTipoUs.SelectedItem = TipoUs.USUARIO_FINAL;
                comboTipoUs.Text = TipoUs.USUARIO_FINAL.ToString();
            }
            else
            {
                comboTipoUs.SelectedItem = TipoUs.ADMINISTRADOR;
                comboTipoUs.Text = TipoUs.ADMINISTRADOR.ToString();
            }
            txtContraseña.Text = dgvUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtConfimaContra.Text = dgvUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();

            txtNombre.Text = dgvUsuarios.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtApellido.Text = dgvUsuarios.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtDomicilio.Text = dgvUsuarios.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtCelular.Text = dgvUsuarios.Rows[e.RowIndex].Cells[7].Value.ToString();
            dtpFechaNac.Value = (DateTime)dgvUsuarios.Rows[e.RowIndex].Cells[8].Value;
            txtEmail.Text = dgvUsuarios.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            us = new UsuarioFinal();
            if (us.eliminar(idUsuarioSeleccionado))
            {
                MessageBox.Show("Ususario ELIMINADO");
                consultaTodos();
                foreach (Control control in gbFormModificarUsuarios.Controls) {
                    if (control is TextBox)
                    {
                        //limpiar textbox
                        control.Text = "";
                    }
                    if (control is CheckBox)
                    {
                        ((CheckBox)control).Checked = false;
                    }
                    if (control is ComboBox)
                    {
                        ((ComboBox)control).SelectedItem = TipoUs.USUARIO_FINAL;
                        ((ComboBox)control).Text = "";
                    }
                    if (control is DateTimePicker)
                    {
                        ((DateTimePicker)control).Value = DateTime.Parse("24/12/1999");
                    }
                }
            }
            else
            {
                MessageBox.Show("Error, Usuario NO ELIMINADO");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
