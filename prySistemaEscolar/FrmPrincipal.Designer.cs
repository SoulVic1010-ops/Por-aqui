namespace prySistemaEscolar
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            pcbMenu = new PictureBox();
            pcbTitulo = new PictureBox();
            pcbAlumnos = new PictureBox();
            pcbCarreras = new PictureBox();
            pcbUsuarios = new PictureBox();
            pcbDocentes = new PictureBox();
            pnlContenedor = new Panel();
            pcbExit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbTitulo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbCarreras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbDocentes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbExit).BeginInit();
            SuspendLayout();
            // 
            // pcbMenu
            // 
            pcbMenu.Image = (Image)resources.GetObject("pcbMenu.Image");
            pcbMenu.Location = new Point(12, 12);
            pcbMenu.Name = "pcbMenu";
            pcbMenu.Size = new Size(417, 967);
            pcbMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbMenu.TabIndex = 0;
            pcbMenu.TabStop = false;
            // 
            // pcbTitulo
            // 
            pcbTitulo.Image = (Image)resources.GetObject("pcbTitulo.Image");
            pcbTitulo.Location = new Point(462, 12);
            pcbTitulo.Name = "pcbTitulo";
            pcbTitulo.Size = new Size(1446, 216);
            pcbTitulo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbTitulo.TabIndex = 1;
            pcbTitulo.TabStop = false;
            // 
            // pcbAlumnos
            // 
            pcbAlumnos.Image = (Image)resources.GetObject("pcbAlumnos.Image");
            pcbAlumnos.Location = new Point(80, 187);
            pcbAlumnos.Name = "pcbAlumnos";
            pcbAlumnos.Size = new Size(260, 109);
            pcbAlumnos.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbAlumnos.TabIndex = 2;
            pcbAlumnos.TabStop = false;
            pcbAlumnos.MouseDown += pcbGeneral_MouseDown;
            pcbAlumnos.MouseUp += pcbGeneral_MouseUp;
            // 
            // pcbCarreras
            // 
            pcbCarreras.Image = (Image)resources.GetObject("pcbCarreras.Image");
            pcbCarreras.Location = new Point(80, 334);
            pcbCarreras.Name = "pcbCarreras";
            pcbCarreras.Size = new Size(260, 109);
            pcbCarreras.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbCarreras.TabIndex = 3;
            pcbCarreras.TabStop = false;
            pcbCarreras.MouseDown += pcbGeneral_MouseDown;
            pcbCarreras.MouseUp += pcbGeneral_MouseUp;
            // 
            // pcbUsuarios
            // 
            pcbUsuarios.Image = (Image)resources.GetObject("pcbUsuarios.Image");
            pcbUsuarios.Location = new Point(80, 650);
            pcbUsuarios.Name = "pcbUsuarios";
            pcbUsuarios.Size = new Size(260, 109);
            pcbUsuarios.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbUsuarios.TabIndex = 4;
            pcbUsuarios.TabStop = false;
            pcbUsuarios.MouseDown += pcbGeneral_MouseDown;
            pcbUsuarios.MouseUp += pcbGeneral_MouseUp;
            // 
            // pcbDocentes
            // 
            pcbDocentes.Image = (Image)resources.GetObject("pcbDocentes.Image");
            pcbDocentes.Location = new Point(80, 495);
            pcbDocentes.Name = "pcbDocentes";
            pcbDocentes.Size = new Size(260, 109);
            pcbDocentes.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbDocentes.TabIndex = 5;
            pcbDocentes.TabStop = false;
            pcbDocentes.MouseDown += pcbGeneral_MouseDown;
            pcbDocentes.MouseUp += pcbGeneral_MouseUp;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.White;
            pnlContenedor.ForeColor = SystemColors.ControlText;
            pnlContenedor.Location = new Point(462, 261);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1446, 718);
            pnlContenedor.TabIndex = 6;
            // 
            // pcbExit
            // 
            pcbExit.Image = (Image)resources.GetObject("pcbExit.Image");
            pcbExit.Location = new Point(80, 802);
            pcbExit.Name = "pcbExit";
            pcbExit.Size = new Size(260, 109);
            pcbExit.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbExit.TabIndex = 0;
            pcbExit.TabStop = false;
            pcbExit.MouseDown += pcbGeneral_MouseDown;
            pcbExit.MouseUp += pcbGeneral_MouseUp;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 63, 80);
            ClientSize = new Size(1920, 991);
            Controls.Add(pcbExit);
            Controls.Add(pnlContenedor);
            Controls.Add(pcbDocentes);
            Controls.Add(pcbUsuarios);
            Controls.Add(pcbCarreras);
            Controls.Add(pcbAlumnos);
            Controls.Add(pcbTitulo);
            Controls.Add(pcbMenu);
            Name = "FrmPrincipal";
            Text = "Sistema Escolar";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pcbMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbTitulo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbCarreras).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbDocentes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbExit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pcbMenu;
        private PictureBox pcbTitulo;
        private PictureBox pcbAlumnos;
        private PictureBox pcbCarreras;
        private PictureBox pcbUsuarios;
        private PictureBox pcbDocentes;
        private Panel pnlContenedor;
        private PictureBox pcbExit;
    }
}