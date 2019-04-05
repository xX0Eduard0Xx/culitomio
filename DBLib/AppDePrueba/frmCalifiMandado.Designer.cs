namespace AppDePrueba
{
    partial class frmCalifiMandado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalifiMandado));
            this.label1 = new System.Windows.Forms.Label();
            this.imList5Estrellas = new System.Windows.Forms.ImageList(this.components);
            this.pctBox5Estrellas = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEstrella1 = new System.Windows.Forms.Button();
            this.btnEstrella2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxComentario = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox5Estrellas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Como Calificaria el mandado?";
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
            // pctBox5Estrellas
            // 
            this.pctBox5Estrellas.Location = new System.Drawing.Point(12, 59);
            this.pctBox5Estrellas.Name = "pctBox5Estrellas";
            this.pctBox5Estrellas.Size = new System.Drawing.Size(325, 72);
            this.pctBox5Estrellas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBox5Estrellas.TabIndex = 5;
            this.pctBox5Estrellas.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 4;
            this.trackBar1.Location = new System.Drawing.Point(12, 137);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(325, 56);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(9, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Como Calificaria al proveedor?";
            // 
            // btnEstrella1
            // 
            this.btnEstrella1.BackColor = System.Drawing.Color.Transparent;
            this.btnEstrella1.Location = new System.Drawing.Point(12, 199);
            this.btnEstrella1.Name = "btnEstrella1";
            this.btnEstrella1.Size = new System.Drawing.Size(134, 115);
            this.btnEstrella1.TabIndex = 9;
            this.btnEstrella1.UseVisualStyleBackColor = false;
            this.btnEstrella1.Click += new System.EventHandler(this.btnEstrella1_Click);
            // 
            // btnEstrella2
            // 
            this.btnEstrella2.Location = new System.Drawing.Point(12, 367);
            this.btnEstrella2.Name = "btnEstrella2";
            this.btnEstrella2.Size = new System.Drawing.Size(130, 111);
            this.btnEstrella2.TabIndex = 10;
            this.btnEstrella2.UseVisualStyleBackColor = true;
            this.btnEstrella2.Click += new System.EventHandler(this.btnEstrella2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(8, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Estuvo bien el tiempo del Mandadero?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(9, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Comentario:";
            // 
            // txtBoxComentario
            // 
            this.txtBoxComentario.Location = new System.Drawing.Point(12, 508);
            this.txtBoxComentario.Multiline = true;
            this.txtBoxComentario.Name = "txtBoxComentario";
            this.txtBoxComentario.Size = new System.Drawing.Size(563, 106);
            this.txtBoxComentario.TabIndex = 14;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Location = new System.Drawing.Point(445, 639);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 35);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmCalifiMandado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 712);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtBoxComentario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEstrella2);
            this.Controls.Add(this.btnEstrella1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctBox5Estrellas);
            this.Name = "frmCalifiMandado";
            this.Text = "frmCalifiMandado";
            this.Load += new System.EventHandler(this.frmCalifiMandado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox5Estrellas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctBox5Estrellas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imList5Estrellas;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEstrella1;
        private System.Windows.Forms.Button btnEstrella2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxComentario;
        private System.Windows.Forms.Button btnGuardar;
    }
}