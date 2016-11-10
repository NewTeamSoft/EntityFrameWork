using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clientes
{
    public partial class Form1 : Form
    {
        VentasDataContext dbVentas = new VentasDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            string mensaje = " ";
            try
            {
                char sexo ;
                if (radioButtonMasculino.Checked == true)
                {
                    sexo = 'M';
                }
                else
                {
                    sexo = 'F';
                }
                dbVentas.uspRegistrarClientes(textBoxLClienteID.Text, textBoxNombre.Text, textBoxDni.Text, int.Parse(textBoxEdad.Text),sexo,textBoxTelefono.Text,ref mensaje);
                MessageBox.Show(mensaje);
                limpias();
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
                string mesaje = " ";
                char sexo;
                if(radioButtonMasculino.Checked == true)
                {
                    sexo = 'M';
                }
                else
                {
                    sexo = 'F';
                }
                dbVentas.uspModificarClientes(textBoxLClienteID.Text, textBoxNombre.Text, textBoxDni.Text,int.Parse(textBoxEdad.Text), sexo, textBoxTelefono.Text, ref mesaje);
                MessageBox.Show(mesaje);
                limpias();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string mesaje = " ";
            var fila = dbVentas.uspBuscarCliente(textBoxLClienteID.Text,ref mesaje);

            foreach (var datos in fila)
            {
                textBoxLClienteID.Text = datos.ClienteID + "";
                textBoxNombre.Text = datos.Nombre + "";
                textBoxDni.Text = datos.Dni + "";
                textBoxEdad.Text = datos.Edad.ToString() + "";
                textBoxTelefono.Text = datos.Telefono + "";
                if(datos.Sexo == 'M')
                {
                    radioButtonMasculino.Checked = true;
                }
                else
                {
                    radioButtonFemenino.Checked = true;
                }
            }

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string mesaje = " ";
                dbVentas.uspEliminarCliente(textBoxLClienteID.Text, ref mesaje);
                MessageBox.Show(mesaje);
                limpias();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void limpias()
        {
            textBoxLClienteID.Clear();
            textBoxNombre.Clear();
            textBoxDni.Clear();
            textBoxEdad.Clear();
            textBoxTelefono.Clear();
            radioButtonMasculino.Checked = true;
            textBoxLClienteID.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxLClienteID.MaxLength = 4;
            textBoxNombre.MaxLength = 20;
            textBoxDni.MaxLength = 8;
            textBoxTelefono.MaxLength = 11;
            textBoxEdad.MaxLength = 3;
        }
    }
}
