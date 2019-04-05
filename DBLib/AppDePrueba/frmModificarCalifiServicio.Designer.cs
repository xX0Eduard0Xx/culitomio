namespace AppDePrueba
{
    partial class frmModificarCalifiServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarCalifiServicio));
            this.lblcali = new System.Windows.Forms.Label();
            this.pctBox5Estrellas = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnEstrella1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEstrella2 = new System.Windows.Forms.Button();
            this.imList5Estrellas = new System.Windows.Forms.ImageList(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctBox5Estrellas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcali
            // 
            this.lblcali.AutoSize = true;
            this.lblcali.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcali.Location = new System.Drawing.Point(12, 33);
            this.lblcali.Name = "lblcali";
            this.lblcali.Size = new System.Drawing.Size(246, 20);
            this.lblcali.TabIndex = 1;
            this.lblcali.Text = "como le paresio el servicio?";
            // 
            // pctBox5Estrellas
            // 
            this.pctBox5Estrellas.Location = new System.Drawing.Point(16, 65);
            this.pctBox5Estrellas.Name = "pctBox5Estrellas";
            this.pctBox5Estrellas.Size = new System.Drawing.Size(325, 72);
            this.pctBox5Estrellas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBox5Estrellas.TabIndex = 5;
            this.pctBox5Estrellas.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 4;
            this.trackBar1.Location = new System.Drawing.Point(16, 143);
            this.trackBar1.Maximum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(325, 56);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnEstrella1
            // 
            this.btnEstrella1.BackColor = System.Drawing.Color.Transparent;
            this.btnEstrella1.Location = new System.Drawing.Point(16, 236);
            this.btnEstrella1.Name = "btnEstrella1";
            this.btnEstrella1.Size = new System.Drawing.Size(93, 93);
            this.btnEstrella1.TabIndex = 8;
            this.btnEstrella1.UseVisualStyleBackColor = false;
            this.btnEstrella1.Click += new System.EventHandler(this.btnEstrella1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(12, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "estuvo bien el tiempo?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "le parecio bueno el proveedor?";
            // 
            // btnEstrella2
            // 
            this.btnEstrella2.Location = new System.Drawing.Point(16, 385);
            this.btnEstrella2.Name = "btnEstrella2";
            this.btnEstrella2.Size = new System.Drawing.Size(93, 93);
            this.btnEstrella2.TabIndex = 11;
            this.btnEstrella2.UseVisualStyleBackColor = true;
            this.btnEstrella2.Click += new System.EventHandler(this.btnEstrella2_Click);
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
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Location = new System.Drawing.Point(305, 556);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 35);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmModificarCalifiServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 621);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEstrella2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEstrella1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pctBox5Estrellas);
            this.Controls.Add(this.lblcali);
            this.Name = "frmModificarCalifiServicio";
            this.Text = "frmModificarCalifiServicio";
            this.Load += new System.EventHandler(this.frmModificarCalifiServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBox5Estrellas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcali;
        private System.Windows.Forms.PictureBox pctBox5Estrellas;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnEstrella1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEstrella2;
        private System.Windows.Forms.ImageList imList5Estrellas;
        private System.Windows.Forms.Button btnGuardar;
    }
}