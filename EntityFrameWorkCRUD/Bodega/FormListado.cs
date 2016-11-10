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
    public partial class FormListado : DevExpress.XtraEditors.XtraForm
    {
        public static int codigoProveedor;
        public FormListado()
        {
            InitializeComponent();
        }

        private void FormListado_Activated(object sender, EventArgs e)
        {
            llenarGrid();
        }
        private void llenarGrid()
        {
            using (InventarioContainer modelo = new InventarioContainer())
            {
                IQueryable<Proveedor> datos = from q in modelo.Proveedor
                                              select q;

                radGridViewListadoProveedor.DataSource = datos.ToList();
                radGridViewListadoProveedor.ColumnCount = 5;
            }
        }

        private void ultraButtonNuevo_Click(object sender, EventArgs e)
        {
            FormProveedor formProveedor = new FormProveedor();
            formProveedor.MdiParent = this.MdiParent;
            formProveedor.Show();
        }

        private void ultraButtonElminarProveedor_Click(object sender, EventArgs e)
        {
            eliminarProveedor();
        }
        private void eliminarProveedor()
        {
            int valorCodigo = int.Parse(radGridViewListadoProveedor.CurrentRow.Cells[0].Value.ToString());

            using (InventarioContainer modelo = new InventarioContainer())
            {
                Proveedor prov = (from q in modelo.Proveedor
                                  where q.ProveedorID == valorCodigo
                                  select q).First();

                modelo.Proveedor.Remove(prov);
                modelo.SaveChanges();
            }
            MessageBox.Show("Eliminado correctamente");
            llenarGrid();
        }

        private void ultraButtonModificar_Click(object sender, EventArgs e)
        {
            codigoProveedor = int.Parse(radGridViewListadoProveedor.CurrentRow.Cells[0].Value.ToString());
            RadFormModificar modificar = new RadFormModificar();
            modificar.MdiParent = this.MdiParent;
            modificar.Show();

        }
    }
}