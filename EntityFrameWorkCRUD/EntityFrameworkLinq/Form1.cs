using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace EntityFrameworkLinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                negocio.guardar(textBoxNombre.Text, textBoxTelefono.Text);
                MessageBox.Show("Guardado");
                textBoxNombre.Clear();
                textBoxTelefono.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxBuscar.Items.Clear();
                negocio.mostrar(listBoxBuscar);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            negocio.mostrar(comboBoxBuscar);
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            try
            {
                negocio.cargar(comboBoxBuscar.Text, textBoxNombre, textBoxTelefono);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                negocio.modificar(textBoxNombre.Text, textBoxTelefono.Text, comboBoxBuscar.Text);
                MessageBox.Show("Modificar");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                negocio.eliminar(listBoxBuscar.SelectedItem.ToString());
                MessageBox.Show("eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

