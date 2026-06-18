using System;
using System.Collections.Generic;
using System.Text;

namespace prySistemaEscolar
{
	internal class clsPrincipal
	{
		//este es un objeto de tipo form
		private Form misformsabierto;

		public void agregarAlContenedor(Form formulario,Panel panel)
		{
			//verifico si esta abierto
			if (misformsabierto != null)
			{ 
				misformsabierto.Close();//cierra la instancia
				misformsabierto.Dispose();//libera de memoria
			}

			//esto es para abrir el formulario en caso de no estar abierto 
			misformsabierto = formulario;
			panel.Controls.Clear();

			formulario.TopLevel = false; //esto indica que el formulario no es independiente
			formulario.FormBorderStyle = FormBorderStyle.Sizable;
			formulario.Dock = DockStyle.Fill;

			panel.Controls.Add(formulario);
			panel.Tag = formulario;
			formulario.Show();
		}
	}
}

