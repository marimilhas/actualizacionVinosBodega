using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace actualizacionVinosBodega.Pantalla
{
    public partial class Inicio : Form
    {
        private static IconMenuItem menuActivo = null; 
        private static Form formularioActivo = null; 

        public Inicio() // constructor de la clase
        {
            InitializeComponent();
        }

        public void opcionImportarActualizacionBodega(object sender, EventArgs e) 
        {
            PantallaBodegas pantalla = new PantallaBodegas();
            habilitarPantalla((IconMenuItem)sender, pantalla);
            pantalla.opcionImportarActualizacionBodegas();
        }

        private void habilitarPantalla(IconMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;
            menuActivo = menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;

            // Configurar el formulario 
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.White;

            // Agregar el formulario al contenedor
            contenedor.Controls.Add(formulario);

            formulario.Show();
        }
    }
}

