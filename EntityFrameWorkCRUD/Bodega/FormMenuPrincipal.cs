using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bodega
{
    public partial class FormMenuPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListado formListado = new FormListado();
            formListado.MdiParent = this;
            formListado.Show();
        }
    }
}
