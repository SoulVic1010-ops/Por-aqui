namespace prySistemaEscolar
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pcbLoginFondo = new PictureBox();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            pcbLoginIcono = new PictureBox();
            btnAcceder = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbLoginFondo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbLoginIcono).BeginInit();
            SuspendLayout();
            // 
            // pcbLoginFondo
            // 
            pcbLoginFondo.Image = (Image)resources.GetObject("pcbLoginFondo.Image");
            pcbLoginFondo.Location = new Point(34, 27);
            pcbLoginFondo.Name = "pcbLoginFondo";
            pcbLoginFondo.Size = new Size(218, 207);
            pcbLoginFondo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLoginFondo.TabIndex = 0;
            pcbLoginFondo.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtUsuario.Location = new Point(301, 46);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Nombre de usuario";
            txtUsuario.Size = new Size(266, 38);
            txtUsuario.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            txtPassword.Location = new Point(301, 107);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña del usuario";
            txtPassword.Size = new Size(266, 38);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // pcbLoginIcono
            // 
            pcbLoginIcono.Image = (Image)resources.GetObject("pcbLoginIcono.Image");
            pcbLoginIcono.Location = new Point(612, 27);
            pcbLoginIcono.Name = "pcbLoginIcono";
            pcbLoginIcono.Size = new Size(225, 207);
            pcbLoginIcono.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLoginIcono.TabIndex = 3;
            pcbLoginIcono.TabStop = false;
            // 
            // btnAcceder
            // 
            btnAcceder.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnAcceder.Location = new Point(301, 174);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(127, 44);
            btnAcceder.TabIndex = 4;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnSalir.Location = new Point(440, 174);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(127, 44);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 283);
            Controls.Add(btnSalir);
            Controls.Add(btnAcceder);
            Controls.Add(pcbLoginIcono);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(pcbLoginFondo);
            Name = "frmLogin";
            Text = "Control de acceso";
            ((System.ComponentModel.ISupportInitialize)pcbLoginFondo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbLoginIcono).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbLoginFondo;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private PictureBox pcbLoginIcono;
        private Button btnAcceder;
        private Button btnSalir;
    }
}
