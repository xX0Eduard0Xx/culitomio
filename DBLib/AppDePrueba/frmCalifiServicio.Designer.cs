namespace AppDePrueba
{
    partial class frmCalifiServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalifiServicio));
            this.lblcali = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.imList5Estrellas = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnEstrella1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEstrella2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxComentario = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblCproveedor = new System.Windows.Forms.Label();
            this.pctBox5Estrellas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox5Estrellas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcali
            // 
            this.lblcali.AutoSize = true;
            this.lblcali.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcali.Location = new System.Drawing.Point(12, 45);
            this.lblcali.Name = "lblcali";
            this.lblcali.Size = new System.Drawing.Size(246, 20);
            this.lblcali.TabIndex = 0;
            this.lblcali.Text = "como le paresio el servicio?";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 4;
            this.trackBar1.Location = new System.Drawing.Point(12, 146);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(325, 56);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // imList5Estrellas
            // 
            this.imList5Estrellas.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imList5Estrellas.ImageStream")));
            this.imList5Estrellas.TransparentColor = System.Drawing.Color.Transparent;
            this.imList5Estrellas.Images.SetKeyName(0, "0estrellas.png");
            this.imList5Estrellas.Images.SetKeyName(1, "1estrella.png");
            this.imList5Estrellas.Images.SetKeyName(2, "2estrellas.png");
            this.imList5Estrellas.Images.SetKeyName(3, "3estrellas.png");
            this.imList5Estrellas.Images.SetKeyName(4, "4estrellas.png");
            this.imList5Estrellas.Images.SetKeyName(5, "5estrellas.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(8, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "estuvo bien el tiempo?";
            // 
            // btnEstrella1
            // 
            this.btnEstrella1.BackColor = System.Drawing.Color.Transparent;
            this.btnEstrella1.Location = new System.Drawing.Point(12, 228);
            this.btnEstrella1.Name = "btnEstrella1";
            this.btnEstrella1.Size = new System.Drawing.Size(134, 115);
            this.btnEstrella1.TabIndex = 7;
            this.btnEstrella1.UseVisualStyleBackColor = false;
            this.btnEstrella1.Click += new System.EventHandler(this.btnEstrella1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "le parecio bueno el proveedor?";
            // 
            // btnEstrella2
            // 
            this.btnEstrella2.Location = new System.Drawing.Point(16, 369);
            this.btnEstrella2.Name = "btnEstrella2";
            this.btnEstrella2.Size = new System.Drawing.Size(130, 111);
            this.btnEstrella2.TabIndex = 9;
            this.btnEstrella2.UseVisualStyleBackColor = true;
            this.btnEstrella2.Click += new System.EventHandler(this.btnEstrella2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "comentario :";
            // 
            // txtBoxComentario
            // 
            this.txtBoxComentario.Location = new System.Drawing.Point(16, 506);
            this.txtBoxComentario.Multiline = true;
            this.txtBoxComentario.Name = "txtBoxComentario";
            this.txtBoxComentario.Size = new System.Drawing.Size(386, 98);
            this.txtBoxComentario.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Location = new System.Drawing.Point(272, 625);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 35);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCproveedor
            // 
            this.lblCproveedor.AutoSize = true;
            this.lblCproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCproveedor.Location = new System.Drawing.Point(13, 9);
            this.lblCproveedor.Name = "lblCproveedor";
            this.lblCproveedor.Size = new System.Drawing.Size(29, 20);
            this.lblCproveedor.TabIndex = 13;
            this.lblCproveedor.Text = "\"\" ";
            // 
            // pctBox5Estrellas
            // 
            this.pctBox5Estrellas.Location = new System.Drawing.Point(12, 71);
            this.pctBox5Estrellas.Name = "pctBox5Estrellas";
            this.pctBox5Estrellas.Size = new System.Drawing.Size(325, 72);
            this.pctBox5Estrellas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBox5Estrellas.TabIndex = 4;
            this.pctBox5Estrellas.TabStop = false;
            // 
            // frmCalifiServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(514, 685);
            this.Controls.Add(this.lblCproveedor);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtBoxComentario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEstrella2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEstrella1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pctBox5Estrellas);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lblcali);
            this.Name = "frmCalifiServicio";
            this.Text = "calificacion  Servicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox5Estrellas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcali;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pctBox5Estrellas;
        private System.Windows.Forms.ImageList imList5Estrellas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEstrella1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEstrella2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxComentario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblCproveedor;
    }
}

