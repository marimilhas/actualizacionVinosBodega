using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using actualizacionVinosBodega.Datos;
using actualizacionVinosBodega.Entidades;
using actualizacionVinosBodega.Gestor;
using Datos;

namespace actualizacionVinosBodega.Pantalla
{
    public partial class PantallaBodegas : Form
    {
        private GestorImportadorBodega gestor;
        string bodegaSeleccionada;
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

        public void tomarSeleccionBodega(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnseleccionar"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
                bodegaSeleccionada = fila.Cells["nombre"].Value.ToString();

                gestor.tomarSeleccionBodega(bodegaSeleccionada);

                List<Vino> infoVinosImportada = gestor.importarActualizacionesVino();

                if (infoVinosImportada != null)
                {
                    List<Tuple<Vino, bool>> vinosActualizarCrear = gestor.determinarVinosParaActualizar(infoVinosImportada);
                    List<Vino> resumen = gestor.crearOActualizarVinos(vinosActualizarCrear);
                    mostrarResumen(resumen, bodegaSeleccionada);
                }
                else
                {
                    MessageBox.Show("El sistema de bodegas no responde", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void mostrarResumen(List<Vino> resumen, string bodegaSeleccionada)
        {
            if (resumen != null)
            {
                dgvVinos.DataSource = resumen;
            } else
            {
                MessageBox.Show("Esta vacío");
            }  
        }

    }
}

