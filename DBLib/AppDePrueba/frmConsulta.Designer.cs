namespace AppDePrueba
{
    partial class frmConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtBoxComentario = new System.Windows.Forms.TextBox();
            this.btnEliminarComentario = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpcalificacion  = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCalificacionGlobal= new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCalificacionDetalle1 = new System.Windows.Forms.Label();
            this.lblCalificacionDetalle2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvcalificacion  = new System.Windows.Forms.DataGridView();
            this.btnConsultaServicio = new System.Windows.Forms.Button();
            this.btnConsultaMandado = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmBFiltrocalificacion  = new System.Windows.Forms.ComboBox();
            this.pcbLupa = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcalificacion )).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.txtBoxComentario);
            this.groupBox1.Controls.Add(this.btnEliminarComentario);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpcalificacion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCalificacionGlobal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCalificacionDetalle1);
            this.groupBox1.Controls.Add(this.lblCalificacionDetalle2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(28, 93);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(113, 84, 167, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1090, 171);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(1038, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(46, 17);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "label4";
            this.lblId.Visible = false;
            // 
            // txtBoxComentario
            // 
            this.txtBoxComentario.Location = new System.Drawing.Point(9, 79);
            this.txtBoxComentario.Multiline = true;
            this.txtBoxComentario.Name = "txtBoxComentario";
            this.txtBoxComentario.Size = new System.Drawing.Size(809, 64);
            this.txtBoxComentario.TabIndex = 7;
            // 
            // btnEliminarComentario
            // 
            this.btnEliminarComentario.Location = new System.Drawing.Point(835, 114);
            this.btnEliminarComentario.Name = "btnEliminarComentario";
            this.btnEliminarComentario.Size = new System.Drawing.Size(147, 29);
            this.btnEliminarComentario.TabIndex = 8;
            this.btnEliminarComentario.Text = "Eliminar Comentario";
            this.btnEliminarComentario.UseVisualStyleBackColor = true;
            this.btnEliminarComentario.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Comentario:";
            // 
            // dtpcalificacion 
            // 
            this.dtpcalificacion .Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpcalificacion .Location = new System.Drawing.Point(492, 23);
            this.dtpcalificacion .Name = "dtpcalificacion ";
            this.dtpcalificacion .Size = new System.Drawing.Size(112, 22);
            this.dtpcalificacion .TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "calificacion  Global:";
            // 
            // lblcalificacion 
            // 
            this.lblCalificacionGlobal.AutoSize = true;
            this.lblCalificacionGlobal.Location = new System.Drawing.Point(140, 28);
            this.lblCalificacionGlobal.Name = "lblcalificacion ";
            this.lblCalificacionGlobal.Size = new System.Drawing.Size(16, 17);
            this.lblCalificacionGlobal.TabIndex = 1;
            this.lblCalificacionGlobal.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "calificacion  D1:";
            // 
            // lblcalificacion_1
            // 
            this.lblCalificacionDetalle1.AutoSize = true;
            this.lblCalificacionDetalle1.Location = new System.Drawing.Point(406, 28);
            this.lblCalificacionDetalle1.Name = "lblcalificacion_1";
            this.lblCalificacionDetalle1.Size = new System.Drawing.Size(16, 17);
            this.lblCalificacionDetalle1.TabIndex = 5;
            this.lblCalificacionDetalle1.Text = "0";
            // 
            // lblcalificacion 1
            // 
            this.lblCalificacionDetalle2.AutoSize = true;
            this.lblCalificacionDetalle2.Location = new System.Drawing.Point(273, 28);
            this.lblCalificacionDetalle2.Name = "lblcalificacion 1";
            this.lblCalificacionDetalle2.Size = new System.Drawing.Size(16, 17);
            this.lblCalificacionDetalle2.TabIndex = 3;
            this.lblCalificacionDetalle2.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "calificacion  D2:";
            // 
            // dgvcalificacion 
            // 
            this.dgvcalificacion .AllowUserToAddRows = false;
            this.dgvcalificacion .AllowUserToDeleteRows = false;
            this.dgvcalificacion .AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcalificacion .AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvcalificacion .ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcalificacion .Location = new System.Drawing.Point(28, 269);
            this.dgvcalificacion .Name = "dgvcalificacion ";
            this.dgvcalificacion .ReadOnly = true;
            this.dgvcalificacion .RowTemplate.Height = 24;
            this.dgvcalificacion .Size = new System.Drawing.Size(1090, 393);
            this.dgvcalificacion .TabIndex = 0;
            this.dgvcalificacion .CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicio_CellContentClick);
            // 
            // btnConsultaServicio
            // 
            this.btnConsultaServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaServicio.Location = new System.Drawing.Point(28, 12);
            this.btnConsultaServicio.Name = "btnConsultaServicio";
            this.btnConsultaServicio.Size = new System.Drawing.Size(189, 30);
            this.btnConsultaServicio.TabIndex = 2;
            this.btnConsultaServicio.Text = "Consultar Servicios";
            this.btnConsultaServicio.UseVisualStyleBackColor = true;
            this.btnConsultaServicio.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnConsultaMandado
            // 
            this.btnConsultaMandado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultaMandado.Location = new System.Drawing.Point(293, 12);
            this.btnConsultaMandado.Name = "btnConsultaMandado";
            this.btnConsultaMandado.Size = new System.Drawing.Size(205, 30);
            this.btnConsultaMandado.TabIndex = 3;
            this.btnConsultaMandado.Text = "Consultar Mandado";
            this.btnConsultaMandado.UseVisualStyleBackColor = true;
            this.btnConsultaMandado.Click += new System.EventHandler(this.btnConsultaMandado_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(25, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Filtro:";
            // 
            // cmBFiltrocalificacion 
            // 
            this.cmBFiltrocalificacion .FormattingEnabled = true;
            this.cmBFiltrocalificacion .Items.AddRange(new object[] {
            "MAYO A MENOR",
            "MENOR A MAYOR",
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.cmBFiltrocalificacion .Location = new System.Drawing.Point(172, 52);
            this.cmBFiltrocalificacion .Name = "cmBFiltrocalificacion ";
            this.cmBFiltrocalificacion .Size = new System.Drawing.Size(189, 24);
            this.cmBFiltrocalificacion .TabIndex = 7;
            // 
            // pcbLupa
            // 
            this.pcbLupa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbLupa.Image = global::AppDePrueba.Properties.Resources.Lupa;
            this.pcbLupa.Location = new System.Drawing.Point(770, 52);
            this.pcbLupa.Name = "pcbLupa";
            this.pcbLupa.Size = new System.Drawing.Size(29, 24);
            this.pcbLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLupa.TabIndex = 8;
            this.pcbLupa.TabStop = false;
            this.pcbLupa.Visible = false;
            this.pcbLupa.Click += new System.EventHandler(this.pcbLupa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "calificacion :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Fecha: De";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(470, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(113, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(589, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "A";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(612, 52);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(112, 22);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(557, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Consultar Capacitacion";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1157, 706);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pcbLupa);
            this.Controls.Add(this.cmBFiltrocalificacion );
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConsultaMandado);
            this.Controls.Add(this.btnConsultaServicio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvcalificacion );
            this.Name = "frmConsulta";
            this.Text = "Consultas Para Admin";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcalificacion )).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvcalificacion ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxComentario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCalificacionDetalle2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCalificacionDetalle1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCalificacionGlobal ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarComentario;
        private System.Windows.Forms.DateTimePicker dtpcalificacion ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnConsultaServicio;
        private System.Windows.Forms.Button btnConsultaMandado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmBFiltrocalificacion ;
        private System.Windows.Forms.PictureBox pcbLupa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
    }
}