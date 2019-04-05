namespace AppDePrueba
{
    partial class frmConsultarMiServicio
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
            this.userControlPanelCalificaciones1 = new AppDePrueba.UserControlPanelCalificaciones();
            this.SuspendLayout();
            // 
            // userControlPanelCalificaciones1
            // 
            this.userControlPanelCalificaciones1.Location = new System.Drawing.Point(12, 12);
            this.userControlPanelCalificaciones1.Name = "userControlPanelCalificaciones1";
            this.userControlPanelCalificaciones1.Size = new System.Drawing.Size(944, 224);
            this.userControlPanelCalificaciones1.TabIndex = 3;
            this.userControlPanelCalificaciones1.Visible = false;
            this.userControlPanelCalificaciones1.Load += new System.EventHandler(this.userControlPanelCalificaciones1_Load);
            // 
            // frmConsultarMiServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1059, 569);
            this.Controls.Add(this.userControlPanelCalificaciones1);
            this.Name = "frmConsultarMiServicio";
            this.Text = "Consulta Tu Servicio";
            this.Load += new System.EventHandler(this.frmConsultarMiServicio_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmConsultarMiServicio_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControlPanelCalificaciones userControlPanelCalificaciones1;
    }
}