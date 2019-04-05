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
    public partial class FrmConsultaUsuario : Form
    {
        //propiedades
        
        public static UsuarioFinal usFinal;
        public static Administrador usAdmin;
        public FrmConsultaUsuario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            this.Hide();
            login.ShowDialog();
            this.Show();
           

        }

        public void consultaTodos()
        {
            //TO DO vamos a hacer la consulta para traer a todos los us registrados
            usFinal = new UsuarioFinal(txtNombre.Text, txtApellido.Text, txtDomicilio.Text, txtCelular.Text, dtpFechaNac.Value, txtEmail.Text, txtContraseña.Text, checkActivo.Checked);
            List<UsuarioFinal> lista = usFinal.consultarTodos();
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
            
            //TODO ejecutar metodo consulta para obtener un USUARIO de UsuarioFinal
            usFinal = new UsuarioFinal();
            usFinal = usFinal.consultar(int.Parse(txtID.Text));
            if (usFinal != null)
            {
                //TODO mostrar el usFinaluario en el Formulario
                txtID.Text               = usFinal.Id.ToString();
                txtNombre.Text           = usFinal.Nombre;
                txtApellido.Text         = usFinal.Apellido;
                txtCelular.Text          = usFinal.Celular;
                txtContraseña.Text       = usFinal.Contraseña;
                txtConfimaContra.Text    = usFinal.Contraseña;
                txtDomicilio.Text        = usFinal.Domicilio;
                txtEmail.Text            = usFinal.CorreoElectronico;
                comboTipoUs.SelectedItem = usFinal.Tipo;
                checkActivo.Checked      = usFinal.Activo;
                //TODO mostrar el usuario en el DataGrid
                //primero limpiamos datagrid
                dgvUsuarios.DataSource = null;
                dgvUsuarios.Rows.Clear();
                List<UsuarioFinal> lista = new List<UsuarioFinal>();
                lista.Add(usFinal);
                dgvUsuarios.DataSource = lista;

                //TODO limpiar los campos
            }
            else {
                //TODO mensaje de error, no se encontro us
                MessageBox.Show(this, "Error, no se encontró dicho USUARIO consultado", "Consulta de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void limpiaForm() {
            foreach (Control ctrl in gbFormConsultaUsuarios.Controls)
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
   

        

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            usFinal = new UsuarioFinal();
            if (usFinal.eliminar(usFinal.Id))
            {
                MessageBox.Show("Ususario ELIMINADO");
                consultaTodos();
                foreach (Control control in gbFormConsultaUsuarios.Controls) {
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

      
    }
}
