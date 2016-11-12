using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace MantenimientoUsers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarUsuario();
        }
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            insertarUsuario(textBoxNombre, textBoxApellido);
            mostrarUsuario();
        }
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            actualizarUsuario(textBox1, textBoxNombre, textBoxApellido);
            mostrarUsuario();
        }
        private void mostrarUsuario()
        {
            dataGridViewBuscarElemento.DataSource =  Users.mostrarUsuario();
        }

        private void insertarUsuario(TextBox nombre, TextBox apellido)
        {
            Users.insertarUsuario(nombre.Text, apellido.Text);
        }
        private void actualizarUsuario(TextBox usuarioId, TextBox nombre, TextBox apellido)
        {
            Users.actualizarUsuario(int.Parse(usuarioId.Text),nombre.Text, apellido.Text);
            mostrarUsuario();
        }
        public void selectCells()
        {
            textBox1.Text = dataGridViewBuscarElemento.CurrentRow.Cells[0].Value.ToString();
        }

        private void dataGridViewBuscarElemento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectCells();
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            buscarUsuario(textBoxBuscar);
        }
        private void buscarUsuario(TextBox buscarNombreApellido)
        {
            dataGridViewBuscarElemento.DataSource = Users.buscarUsuario(buscarNombreApellido.Text);
        }
    }
}
