namespace ProyVentanasPrueba
{
    partial class FrmModificacionUusario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbFormModificarUsuarios = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblTipoUs = new System.Windows.Forms.Label();
            this.comboTipoUs = new System.Windows.Forms.ComboBox();
            this.checkActivo = new System.Windows.Forms.CheckBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtConfimaContra = new System.Windows.Forms.TextBox();
            this.lblConfirmacion = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbUsuariosRegistrado = new System.Windows.Forms.GroupBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.errorFromUsuarios = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBorrar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbFormModificarUsuarios.SuspendLayout();
            this.gbUsuariosRegistrado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFromUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFormModificarUsuarios
            // 
            this.gbFormModificarUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbFormModificarUsuarios.Controls.Add(this.btnBorrar);
            this.gbFormModificarUsuarios.Controls.Add(this.btnCancelar);
            this.gbFormModificarUsuarios.Controls.Add(this.btnModificar);
            this.gbFormModificarUsuarios.Controls.Add(this.lblTipoUs);
            this.gbFormModificarUsuarios.Controls.Add(this.comboTipoUs);
            this.gbFormModificarUsuarios.Controls.Add(this.checkActivo);
            this.gbFormModificarUsuarios.Controls.Add(this.dtpFechaNac);
            this.gbFormModificarUsuarios.Controls.Add(this.txtConfimaContra);
            this.gbFormModificarUsuarios.Controls.Add(this.lblConfirmacion);
            this.gbFormModificarUsuarios.Controls.Add(this.txtContraseña);
            this.gbFormModificarUsuarios.Controls.Add(this.lblContra);
            this.gbFormModificarUsuarios.Controls.Add(this.txtEmail);
            this.gbFormModificarUsuarios.Controls.Add(this.lblCorreo);
            this.gbFormModificarUsuarios.Controls.Add(this.lblFechaNac);
            this.gbFormModificarUsuarios.Controls.Add(this.txtCelular);
            this.gbFormModificarUsuarios.Controls.Add(this.lblCelular);
            this.gbFormModificarUsuarios.Controls.Add(this.txtDomicilio);
            this.gbFormModificarUsuarios.Controls.Add(this.lblDomicilio);
            this.gbFormModificarUsuarios.Controls.Add(this.txtApellido);
            this.gbFormModificarUsuarios.Controls.Add(this.lblApellido);
            this.gbFormModificarUsuarios.Controls.Add(this.txtNombre);
            this.gbFormModificarUsuarios.Controls.Add(this.lblNombre);
            this.gbFormModificarUsuarios.Location = new System.Drawing.Point(12, 12);
            this.gbFormModificarUsuarios.Name = "gbFormModificarUsuarios";
            this.gbFormModificarUsuarios.Size = new System.Drawing.Size(953, 149);
            this.gbFormModificarUsuarios.TabIndex = 0;
            this.gbFormModificarUsuarios.TabStop = false;
            this.gbFormModificarUsuarios.Text = "Formulario de Datos de Usuarios";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(853, 107);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(853, 56);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblTipoUs
            // 
            this.lblTipoUs.AutoSize = true;
            this.lblTipoUs.Location = new System.Drawing.Point(573, 112);
            this.lblTipoUs.Name = "lblTipoUs";
            this.lblTipoUs.Size = new System.Drawing.Size(82, 13);
            this.lblTipoUs.TabIndex = 21;
            this.lblTipoUs.Text = "Tipo de Usuario";
            // 
            // comboTipoUs
            // 
            this.comboTipoUs.FormattingEnabled = true;
            this.comboTipoUs.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "USUARIO FINAL"});
            this.comboTipoUs.Location = new System.Drawing.Point(701, 104);
            this.comboTipoUs.Name = "comboTipoUs";
            this.comboTipoUs.Size = new System.Drawing.Size(121, 21);
            this.comboTipoUs.TabIndex = 20;
            // 
            // checkActivo
            // 
            this.checkActivo.AutoSize = true;
            this.checkActivo.Location = new System.Drawing.Point(853, 33);
            this.checkActivo.Name = "checkActivo";
            this.checkActivo.Size = new System.Drawing.Size(68, 17);
            this.checkActivo.TabIndex = 19;
            this.checkActivo.Text = "¿Activo?";
            this.checkActivo.UseVisualStyleBackColor = true;
            this.checkActivo.CheckedChanged += new System.EventHandler(this.checkActivo_CheckedChanged);
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(396, 72);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaNac.TabIndex = 18;
            // 
            // txtConfimaContra
            // 
            this.txtConfimaContra.Location = new System.Drawing.Point(701, 65);
            this.txtConfimaContra.Name = "txtConfimaContra";
            this.txtConfimaContra.PasswordChar = '*';
            this.txtConfimaContra.Size = new System.Drawing.Size(121, 20);
            this.txtConfimaContra.TabIndex = 15;
            // 
            // lblConfirmacion
            // 
            this.lblConfirmacion.AutoSize = true;
            this.lblConfirmacion.Location = new System.Drawing.Point(573, 72);
            this.lblConfirmacion.Name = "lblConfirmacion";
            this.lblConfirmacion.Size = new System.Drawing.Size(105, 13);
            this.lblConfirmacion.TabIndex = 14;
            this.lblConfirmacion.Text = "Confirma Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(701, 30);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(121, 20);
            this.txtContraseña.TabIndex = 13;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(573, 37);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(61, 13);
            this.lblContra.TabIndex = 12;
            this.lblContra.Text = "Contraseña";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(396, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(265, 112);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(32, 13);
            this.lblCorreo.TabIndex = 10;
            this.lblCorreo.Text = "Email";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(265, 72);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNac.TabIndex = 8;
            this.lblFechaNac.Text = "Fecha de Nacimiento";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(396, 30);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 7;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(265, 37);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 6;
            this.lblCelular.Text = "Celular";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(97, 105);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(100, 20);
            this.txtDomicilio.TabIndex = 5;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(17, 112);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 4;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(97, 65);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(17, 72);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre ";
            // 
            // gbUsuariosRegistrado
            // 
            this.gbUsuariosRegistrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gbUsuariosRegistrado.Controls.Add(this.dgvUsuarios);
            this.gbUsuariosRegistrado.Location = new System.Drawing.Point(12, 167);
            this.gbUsuariosRegistrado.Name = "gbUsuariosRegistrado";
            this.gbUsuariosRegistrado.Size = new System.Drawing.Size(953, 193);
            this.gbUsuariosRegistrado.TabIndex = 1;
            this.gbUsuariosRegistrado.TabStop = false;
            this.gbUsuariosRegistrado.Text = "Usuarios Registrados";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(17, 19);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(916, 168);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // errorFromUsuarios
            // 
            this.errorFromUsuarios.ContainerControl = this;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Maroon;
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBorrar.Location = new System.Drawing.Point(853, 81);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 24;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmModificacionUusario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.gbUsuariosRegistrado);
            this.Controls.Add(this.gbFormModificarUsuarios);
            this.Name = "FrmModificacionUusario";
            this.Text = "Modificaciòn de Usuarios Creados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbFormModificarUsuarios.ResumeLayout(false);
            this.gbFormModificarUsuarios.PerformLayout();
            this.gbUsuariosRegistrado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFromUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFormModificarUsuarios;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblTipoUs;
        private System.Windows.Forms.ComboBox comboTipoUs;
        private System.Windows.Forms.CheckBox checkActivo;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.TextBox txtConfimaContra;
        private System.Windows.Forms.Label lblConfirmacion;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbUsuariosRegistrado;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.ErrorProvider errorFromUsuarios;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

