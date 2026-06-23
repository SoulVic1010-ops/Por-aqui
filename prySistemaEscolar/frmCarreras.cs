using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prySistemaEscolar
{
	public partial class frmCarreras : Form
	{
		clsCarreras carreras;
		int idCarrera;
		public frmCarreras()
		{
			InitializeComponent();
			carreras = new clsCarreras();
			dgvCarreras.DataSource = null;
			dgvCarreras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			try
			{
				dgvCarreras.DataSource = carreras.CargarDataGrid();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

			}

		}


		private void InitializeComponent()
		{
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			pcbLogo = new PictureBox();
			lblTitulo = new Label();
			pnlAgrupaControles = new Panel();
			btnEliminar = new Button();
			btnGuardar = new Button();
			btnNuevo = new Button();
			txtDescripcion = new TextBox();
			txtNombre = new TextBox();
			dgvCarreras = new DataGridView();
			txtNombreCarrera = new TextBox();
			((ISupportInitialize)pcbLogo).BeginInit();
			pnlAgrupaControles.SuspendLayout();
			((ISupportInitialize)dgvCarreras).BeginInit();
			SuspendLayout();
			// 
			// pcbLogo
			// 
			pcbLogo.BackColor = SystemColors.ControlLightLight;
			pcbLogo.Image = Properties.Resources._5257028;
			pcbLogo.Location = new Point(742, 26);
			pcbLogo.Name = "pcbLogo";
			pcbLogo.Size = new Size(74, 65);
			pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
			pcbLogo.TabIndex = 0;
			pcbLogo.TabStop = false;
			// 
			// lblTitulo
			// 
			lblTitulo.AutoSize = true;
			lblTitulo.BackColor = SystemColors.ControlLightLight;
			lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTitulo.Location = new Point(475, 26);
			lblTitulo.Name = "lblTitulo";
			lblTitulo.Size = new Size(214, 65);
			lblTitulo.TabIndex = 1;
			lblTitulo.Text = "Carreras";
			// 
			// pnlAgrupaControles
			// 
			pnlAgrupaControles.BackColor = SystemColors.ControlLightLight;
			pnlAgrupaControles.Controls.Add(btnEliminar);
			pnlAgrupaControles.Controls.Add(btnGuardar);
			pnlAgrupaControles.Controls.Add(btnNuevo);
			pnlAgrupaControles.Controls.Add(txtDescripcion);
			pnlAgrupaControles.Controls.Add(txtNombre);
			pnlAgrupaControles.Location = new Point(314, 94);
			pnlAgrupaControles.Name = "pnlAgrupaControles";
			pnlAgrupaControles.Size = new Size(624, 201);
			pnlAgrupaControles.TabIndex = 2;
			// 
			// btnEliminar
			// 
			btnEliminar.BackgroundImage = Properties.Resources.imagen3;
			btnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
			btnEliminar.Location = new Point(376, 140);
			btnEliminar.Name = "btnEliminar";
			btnEliminar.Size = new Size(105, 46);
			btnEliminar.TabIndex = 4;
			btnEliminar.UseVisualStyleBackColor = true;
			// 
			// btnGuardar
			// 
			btnGuardar.BackgroundImage = Properties.Resources.imagen2;
			btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
			btnGuardar.Location = new Point(227, 140);
			btnGuardar.Name = "btnGuardar";
			btnGuardar.Size = new Size(105, 46);
			btnGuardar.TabIndex = 3;
			btnGuardar.UseVisualStyleBackColor = true;
			btnGuardar.Click += btnGuardar_Click;
			// 
			// btnNuevo
			// 
			btnNuevo.BackgroundImage = Properties.Resources.Imagen4;
			btnNuevo.BackgroundImageLayout = ImageLayout.Stretch;
			btnNuevo.Location = new Point(77, 140);
			btnNuevo.Name = "btnNuevo";
			btnNuevo.Size = new Size(105, 46);
			btnNuevo.TabIndex = 2;
			btnNuevo.UseVisualStyleBackColor = true;
			btnNuevo.Click += btnNuevo_Click;
			// 
			// txtDescripcion
			// 
			txtDescripcion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtDescripcion.Location = new Point(111, 84);
			txtDescripcion.Name = "txtDescripcion";
			txtDescripcion.PlaceholderText = "Escribir una descrpcion de la carrera";
			txtDescripcion.Size = new Size(370, 33);
			txtDescripcion.TabIndex = 1;
			// 
			// txtNombre
			// 
			txtNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtNombre.Location = new Point(111, 41);
			txtNombre.Name = "txtNombre";
			txtNombre.PlaceholderText = "Escribir el nombre de la carrera";
			txtNombre.Size = new Size(370, 33);
			txtNombre.TabIndex = 0;
			// 
			// dgvCarreras
			// 
			dgvCarreras.AllowUserToAddRows = false;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 192);
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = Color.Teal;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			dgvCarreras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			dgvCarreras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.Teal;
			dataGridViewCellStyle4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle4.ForeColor = Color.White;
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(192, 192, 255);
			dataGridViewCellStyle4.SelectionForeColor = Color.Black;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
			dgvCarreras.DefaultCellStyle = dataGridViewCellStyle4;
			dgvCarreras.EnableHeadersVisualStyles = false;
			dgvCarreras.Location = new Point(314, 342);
			dgvCarreras.Name = "dgvCarreras";
			dgvCarreras.RowHeadersWidth = 51;
			dgvCarreras.Size = new Size(624, 133);
			dgvCarreras.TabIndex = 3;
			dgvCarreras.SelectionChanged += dgvCarreras_SelectionChanged;
			// 
			// txtNombreCarrera
			// 
			txtNombreCarrera.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtNombreCarrera.Location = new Point(735, 301);
			txtNombreCarrera.Name = "txtNombreCarrera";
			txtNombreCarrera.PlaceholderText = "Buscar Carrera";
			txtNombreCarrera.Size = new Size(203, 35);
			txtNombreCarrera.TabIndex = 4;
			txtNombreCarrera.TextChanged += txtNombreCarrera_TextChanged;
			// 
			// frmCarreras
			// 
			BackgroundImage = Properties.Resources.imagen6;
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(1249, 499);
			Controls.Add(txtNombreCarrera);
			Controls.Add(dgvCarreras);
			Controls.Add(pnlAgrupaControles);
			Controls.Add(lblTitulo);
			Controls.Add(pcbLogo);
			DoubleBuffered = true;
			Name = "frmCarreras";
			Text = "Registro de Carreras";
			((ISupportInitialize)pcbLogo).EndInit();
			pnlAgrupaControles.ResumeLayout(false);
			pnlAgrupaControles.PerformLayout();
			((ISupportInitialize)dgvCarreras).EndInit();
			ResumeLayout(false);
			PerformLayout();

		}

		private PictureBox pcbLogo;
		private Label lblTitulo;
		private Button btnEliminar;
		private Button btnGuardar;
		private Button btnNuevo;
		private TextBox txtDescripcion;
		private TextBox txtNombre;
		private DataGridView dgvCarreras;
		private TextBox txtNombreCarrera;
		private Panel pnlAgrupaControles;

		private void dgvCarreras_SelectionChanged(object sender, EventArgs e)
		{
			//Este es el campo oculto que me servirá de referencia para actualizar y eliminar
			idCarrera = int.Parse(dgvCarreras.CurrentRow.Cells[0].Value.ToString());
			//estos son visuales
			txtNombre.Text = dgvCarreras.CurrentRow.Cells[1].Value.ToString();
			txtDescripcion.Text = dgvCarreras.CurrentRow.Cells[2].Value.ToString();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			int tipoOperacion = idCarrera==0 ? 0 : 1;
			carreras.GuardarActualizar(tipoOperacion);
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			idCarrera = 0;

		}
	}
}
