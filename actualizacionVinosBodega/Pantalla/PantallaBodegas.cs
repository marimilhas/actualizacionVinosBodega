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

                //mostrarBodegas();
                gestor.tomarSeleccionBodega(nombreBodega);
                //mostrarBodegaSeleccionada(nombreBodega);
            }
        }

        public void mostrarResumen()
        {

        }

        // método de prueba
        public void mostrarBodegas()
        {
            DatosBodega objsbodega = new DatosBodega();
            List<Bodega> bodegas = objsbodega.Listar();
            if (bodegas == null || bodegas.Count == 0)
            {
                MessageBox.Show("No se encontraron bodegas.");
                return;
            } else
            {
                MessageBox.Show("Se encontraron bodegas.");
                return;
            }
        }


        // método de prueba
        public void mostrarBodegaSeleccionada(string nombreBodega)
        {
            MessageBox.Show($"Bodega seleccionada: {nombreBodega}");
        }


        // método de prueba
        public void mostrarListaVinos(List<Vino> vinosParaMostrar)
        {
            if (vinosParaMostrar.Count == 0)
            {
                MessageBox.Show("No hay vinos para mostrar.", "Lista de Vinos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Lista de Vinos:");

            foreach (Vino vino in vinosParaMostrar)
            {
                sb.AppendLine($"- {vino.nombre}, Añada: {vino.añada}, Precio: {vino.precioArs:C}");
            }

            string mensaje = sb.ToString();

            MessageBox.Show(mensaje, "Lista de Vinos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvVinos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mostrarResumen()
        {

        }


        private void iconButton1_Click(object sender, EventArgs e)
        {

            List<Vino> vinos = gestor.importarActualizacionesVino();

            if (vinos != null)
            {
                dgvVinos.DataSource = vinos;
            }
            else
            {
                MessageBox.Show("No se encontraron bodegas con actualizaciones disponibles.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

