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
			pcbTutores = new PictureBox();
			pcbDocentes = new PictureBox();
			pnlContenedor = new Panel();
			pcbUsuarios = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pcbMenu).BeginInit();
			((System.ComponentModel.ISupportInitialize)pcbTitulo).BeginInit();
			((System.ComponentModel.ISupportInitialize)pcbAlumnos).BeginInit();
			((System.ComponentModel.ISupportInitialize)pcbCarreras).BeginInit();
			((System.ComponentModel.ISupportInitialize)pcbTutores).BeginInit();
			((System.ComponentModel.ISupportInitialize)pcbDocentes).BeginInit();
			((System.ComponentModel.ISupportInitialize)pcbUsuarios).BeginInit();
			SuspendLayout();
			// 
			// pcbMenu
			// 
			pcbMenu.Image = (Image)resources.GetObject("pcbMenu.Image");
			pcbMenu.Location = new Point(10, 9);
			pcbMenu.Margin = new Padding(3, 2, 3, 2);
			pcbMenu.Name = "pcbMenu";
			pcbMenu.Size = new Size(365, 725);
			pcbMenu.SizeMode = PictureBoxSizeMode.StretchImage;
			pcbMenu.TabIndex = 0;
			pcbMenu.TabStop = false;
			// 
			// pcbTitulo
			// 
			pcbTitulo.Image = (Image)resources.GetObject("pcbTitulo.Image");
			pcbTitulo.Location = new Point(404, 9);
			pcbTitulo.Margin = new Padding(3, 2, 3, 2);
			pcbTitulo.Name = "pcbTitulo";
			pcbTitulo.Size = new Size(1265, 162);
			pcbTitulo.SizeMode = PictureBoxSizeMode.StretchImage;
			pcbTitulo.TabIndex = 1;
			pcbTitulo.TabStop = false;
			// 
			// pcbAlumnos
			// 
			pcbAlumnos.Image = (Image)resources.GetObject("pcbAlumnos.Image");
			pcbAlumnos.Location = new Point(70, 140);
			pcbAlumnos.Margin = new Padding(3, 2, 3, 2);
			pcbAlumnos.Name = "pcbAlumnos";
			pcbAlumnos.Size = new Size(228, 82);
			pcbAlumnos.SizeMode = PictureBoxSizeMode.StretchImage;
			pcbAlumnos.TabIndex = 2;
			pcbAlumnos.TabStop = false;
			pcbAlumnos.Click += frmPrincipal_Load;
			pcbAlumnos.MouseDown += pcbGeneral_MouseDown;
			pcbAlumnos.MouseUp += pcbGeneral_MouseUp;
			// 
			// pcbCarreras
			// 
			pcbCarreras.Image = (Image)resources.GetObject("pcbCarreras.Image");
			pcbCarreras.Location = new Point(70, 250);
			pcbCarreras.Margin = new Padding(3, 2, 3, 2);
			pcbCarreras.Name = "pcbCarreras";
			pcbCarreras.Size = new Size(228, 82);
			pcbCarreras.SizeMode = PictureBoxSizeMode.StretchImage;
			pcbCarreras.TabIndex = 3;
			pcbCarreras.TabStop = false;
			pcbCarreras.Click += pcbCarreras_Click;
			pcbCarreras.MouseDown += pcbGeneral_MouseDown;
			pcbCarreras.MouseUp += pcbGeneral_MouseUp;
			// 
			// pcbTutores
			// 
			pcbTutores.Image = (Image)resources.GetObject("pcbTutores.Image");
			pcbTutores.Location = new Point(70, 481);
			pcbTutores.Margin = new Padding(3, 2, 3, 2);
			pcbTutores.Name = "pcbTutores";
			pcbTutores.Size = new Size(228, 82);
			pcbTutores.SizeMode = PictureBoxSizeMode.StretchImage;
			pcbTutores.TabIndex = 4;
			pcbTutores.TabStop = false;
			pcbTutores.Click += frmPrincipal_Load;
			pcbTutores.MouseDown += pcbGeneral_MouseDown;
			pcbTutores.MouseUp += pcbGeneral_MouseUp;
			// 
			// pcbDocentes
			// 
			pcbDocentes.Image = (Image)resources.GetObject("pcbDocentes.Image");
			pcbDocentes.Location = new Point(70, 371);
			pcbDocentes.Margin = new Padding(3, 2, 3, 2);
			pcbDocentes.Name = "pcbDocentes";
			pcbDocentes.Size = new Size(228, 82);
			pcbDocentes.SizeMode = PictureBoxSizeMode.StretchImage;
			pcbDocentes.TabIndex = 5;
			pcbDocentes.TabStop = false;
			pcbDocentes.Click += frmPrincipal_Load;
			pcbDocentes.MouseDown += pcbGeneral_MouseDown;
			pcbDocentes.MouseUp += pcbGeneral_MouseUp;
			// 
			// pnlContenedor
			// 
			pnlContenedor.BackColor = Color.White;
			pnlContenedor.ForeColor = SystemColors.ControlText;
			pnlContenedor.Location = new Point(404, 196);
			pnlContenedor.Margin = new Padding(3, 2, 3, 2);
			pnlContenedor.Name = "pnlContenedor";
			pnlContenedor.Size = new Size(1265, 538);
			pnlContenedor.TabIndex = 6;
			// 
			// pcbUsuarios
			// 
			pcbUsuarios.Image = (Image)resources.GetObject("pcbUsuarios.Image");
			pcbUsuarios.Location = new Point(70, 584);
			pcbUsuarios.Margin = new Padding(3, 2, 3, 2);
			pcbUsuarios.Name = "pcbUsuarios";
			pcbUsuarios.Size = new Size(228, 82);
			pcbUsuarios.SizeMode = PictureBoxSizeMode.StretchImage;
			pcbUsuarios.TabIndex = 0;
			pcbUsuarios.TabStop = false;
			pcbUsuarios.Click += frmPrincipal_Load;
			pcbUsuarios.MouseDown += pcbGeneral_MouseDown;
			pcbUsuarios.MouseUp += pcbGeneral_MouseUp;
			// 
			// FrmPrincipal
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(51, 63, 80);
			CausesValidation = false;
			ClientSize = new Size(1370, 700);
			Controls.Add(pcbUsuarios);
			Controls.Add(pnlContenedor);
			Controls.Add(pcbDocentes);
			Controls.Add(pcbTutores);
			Controls.Add(pcbCarreras);
			Controls.Add(pcbAlumnos);
			Controls.Add(pcbTitulo);
			Controls.Add(pcbMenu);
			Margin = new Padding(3, 2, 3, 2);
			Name = "FrmPrincipal";
			Text = "Sistema Escolar";
			WindowState = FormWindowState.Maximized;
			Load += frmPrincipal_Load;
			((System.ComponentModel.ISupportInitialize)pcbMenu).EndInit();
			((System.ComponentModel.ISupportInitialize)pcbTitulo).EndInit();
			((System.ComponentModel.ISupportInitialize)pcbAlumnos).EndInit();
			((System.ComponentModel.ISupportInitialize)pcbCarreras).EndInit();
			((System.ComponentModel.ISupportInitialize)pcbTutores).EndInit();
			((System.ComponentModel.ISupportInitialize)pcbDocentes).EndInit();
			((System.ComponentModel.ISupportInitialize)pcbUsuarios).EndInit();
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
        private PictureBox pcbTutores
		;
    }
}