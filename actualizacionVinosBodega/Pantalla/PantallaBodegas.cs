using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using actualizacionVinosBodega.Gestor;

namespace actualizacionVinosBodega.Pantalla
{
    public partial class PantallaBodegas : Form
    {
        private GestorImportadorBodega gestor;
        //private GestorImportadorBodega gestor;
        //grillaVinosActualizados
        //labelBodegaSeleccionada
        //listaBodegasParaSeleccion

        public PantallaBodegas() // constructor de la clase
        {
            InitializeComponent();
        }

        public void opcionImportarActualizacionBodegas()
        {
            //Se crea el gestor que maneje la logica de negocio del caso de uso
            this.gestor = new GestorImportadorBodega(this);
            gestor.opcionImportarActualizacionBodegas();
        }

        public void mostrarBodegasActualizables(List<string> bodegasActualizables)
        {
            // Para probar que no haya bodegas actualizables
            // List<string> actualizables = new List<string>(); 

            if (bodegasActualizables.Count == 0)
            {
                Label lbl = this.Controls["label1"] as Label;

                lbl.Text = "No hay bodegas con actualizaciones disponibles";
                lbl.Visible = true;

                dataGridView1.DataSource = null;
                dataGridView1.Visible = false;
            }
            else
            {
                dataGridView1.Rows.Clear();
                foreach (string actualizable in bodegasActualizables)
                {
                    dataGridView1.Rows.Add(actualizable, "");
                }
            }
        }

        private void tomarSeleccionBodega(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnseleccionar"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                string nombreBodega = fila.Cells["nombre"].Value.ToString();

                gestor.tomarSeleccionBodega(nombreBodega);

                // Lo guardo de prueba por el momento
                MessageBox.Show($"Bodega seleccionada: {nombreBodega}");
            }

        }
    }
}

