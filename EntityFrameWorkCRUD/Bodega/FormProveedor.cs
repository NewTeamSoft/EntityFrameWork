using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Bodega
{
    public partial class FormProveedor : DevExpress.XtraEditors.XtraForm
    {
        public FormProveedor()
        {
            InitializeComponent();
        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            agregarProveedor();
            MessageBox.Show("Proveedor agregado correctamente");
            limpiarControles();
        }
        private void ultraButtonLimpiar_Click(object sender, EventArgs e)
        {
            limpiarControles();
        }
        private void agregarProveedor()
        {
            using (InventarioContainer modelo = new InventarioContainer())
            {
                Proveedor prov = new Proveedor()
                {
                    ProveedorID = Convert.ToInt32(ultraTextEditorProveedorID.Text),
                    ProveedorNombre = ultraTextEditorNombre.Text,
                    ProveedorDireccion = ultraTextEditorDireccion.Text,
                    ProveedorTelefono = ultraTextEditorTelefono.Text,
                    ProveedorCorreoE = ultraTextEditorCorreoE.Text
                };
                modelo.Proveedor.Add(prov);
                modelo.SaveChanges();
            }
        }

        private void limpiarControles()
        {
            ultraTextEditorProveedorID.Clear();
            ultraTextEditorNombre.Clear();
            ultraTextEditorDireccion.Clear();
            ultraTextEditorTelefono.Clear();
            ultraTextEditorCorreoE.Clear();
        }
    }
}
