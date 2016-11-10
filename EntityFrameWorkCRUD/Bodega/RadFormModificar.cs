using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Bodega
{
    public partial class RadFormModificar : Telerik.WinControls.UI.RadForm
    {
        public RadFormModificar()
        {
            InitializeComponent();
        }

        private void RadFormModificar_Load(object sender, EventArgs e)
        {
            llenarForm();
        }
        private void llenarForm()
        {
            using (InventarioContainer modelo = new InventarioContainer())
            {
                IQueryable<Proveedor> datos = from q in modelo.Proveedor
                                              where q.ProveedorID == FormListado.codigoProveedor
                                              select q;

                List<Proveedor> lista = datos.ToList();

                ultraTextEditorProveedorID.Text = lista[0].ProveedorID.ToString();
                ultraTextEditorNombre.Text = lista[0].ProveedorNombre;
                ultraTextEditorDireccion.Text = lista[0].ProveedorDireccion;
                ultraTextEditorTelefono.Text = lista[0].ProveedorTelefono.ToString();
                ultraTextEditorCorreoE.Text = lista[0].ProveedorCorreoE.ToString();

            }
        }

        private void ultraButtonModificar_Click(object sender, EventArgs e)
        {
            modificarProveedor();
        }
        private void modificarProveedor()
        {
            using (InventarioContainer modelo = new InventarioContainer())
            {
                int valorID = int.Parse(ultraTextEditorProveedorID.Text);
                Proveedor datos = (from q in modelo.Proveedor
                                   where q.ProveedorID == valorID
                                   select q).First();

                datos.ProveedorNombre = ultraTextEditorNombre.Text;
                datos.ProveedorDireccion = ultraTextEditorDireccion.Text;
                datos.ProveedorTelefono = ultraTextEditorTelefono.Text;
                datos.ProveedorCorreoE = ultraTextEditorCorreoE.Text;
                modelo.SaveChanges();

            }
            MessageBox.Show("Modificado correctamente");
        }
    }
}
