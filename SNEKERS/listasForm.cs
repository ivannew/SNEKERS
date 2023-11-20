using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNEKERS
{
    public partial class listasForm : Form
    {
        private List<Sneakers> listaSneakers = new List<Sneakers>();
        public listasForm()
        {
            InitializeComponent();
        }
        private void ActualizarListBox1()
        {
            listBox1.Items.Clear();

            foreach (var sneakers in listaSneakers)
            {
                listBox1.Items.Add($"{sneakers.Marca} - {sneakers.modelo} - ${sneakers.costo}");
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtcosto.Text, out int costo))
            {
                Sneakers nuevoSneakers = new Sneakers
                {
                    modelo = txtmodelo.Text,
                    Marca = txtMarca.Text,
                    costo = costo,
                    // Asigna otras propiedades según sea necesario
                };

                listaSneakers.Add(nuevoSneakers);
                ActualizarListBox1();
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido para el costo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LimpiarListaSneakers()
        {
            listaSneakers.Clear();
            ActualizarListBox1(); // Asegúrate de actualizar el ListBox después de limpiar la lista
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimpiarListaSneakers();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // Obtener el índice del elemento seleccionado
                int indiceSeleccionado = listBox1.SelectedIndex;

                // Eliminar el Sneakers correspondiente al índice seleccionado
                listaSneakers.RemoveAt(indiceSeleccionado);

                // Actualizar el ListBox después de eliminar
                ActualizarListBox1();
            }
            else
            {
                MessageBox.Show("Seleccione un elemento para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
