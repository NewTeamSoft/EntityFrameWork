namespace Bodega
{
    partial class FormListado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radGridViewListadoProveedor = new Telerik.WinControls.UI.RadGridView();
            this.ultraButtonNuevo = new Infragistics.Win.Misc.UltraButton();
            this.ultraButtonElminarProveedor = new Infragistics.Win.Misc.UltraButton();
            this.ultraButtonModificar = new Infragistics.Win.Misc.UltraButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewListadoProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewListadoProveedor.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridViewListadoProveedor
            // 
            this.radGridViewListadoProveedor.AutoSizeRows = true;
            this.radGridViewListadoProveedor.BackColor = System.Drawing.Color.Aquamarine;
            this.radGridViewListadoProveedor.Location = new System.Drawing.Point(12, 23);
            // 
            // radGridViewListadoProveedor
            // 
            this.radGridViewListadoProveedor.MasterTemplate.AllowAddNewRow = false;
            this.radGridViewListadoProveedor.MasterTemplate.AllowColumnReorder = false;
            this.radGridViewListadoProveedor.MasterTemplate.AllowDragToGroup = false;
            this.radGridViewListadoProveedor.MasterTemplate.EnableAlternatingRowColor = true;
            this.radGridViewListadoProveedor.MasterTemplate.ShowChildViewCaptions = true;
            this.radGridViewListadoProveedor.Name = "radGridViewListadoProveedor";
            this.radGridViewListadoProveedor.ReadOnly = true;
            // 
            // 
            // 
            this.radGridViewListadoProveedor.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.Auto;
            this.radGridViewListadoProveedor.ShowChildViewCaptions = true;
            this.radGridViewListadoProveedor.Size = new System.Drawing.Size(558, 150);
            this.radGridViewListadoProveedor.TabIndex = 0;
            this.radGridViewListadoProveedor.Text = "radGridView1";
            this.radGridViewListadoProveedor.ThemeName = "ControlDefault";
            // 
            // ultraButtonNuevo
            // 
            this.ultraButtonNuevo.Location = new System.Drawing.Point(26, 203);
            this.ultraButtonNuevo.Name = "ultraButtonNuevo";
            this.ultraButtonNuevo.Size = new System.Drawing.Size(120, 23);
            this.ultraButtonNuevo.TabIndex = 1;
            this.ultraButtonNuevo.Text = "Nuevo";
            this.ultraButtonNuevo.Click += new System.EventHandler(this.ultraButtonNuevo_Click);
            // 
            // ultraButtonElminarProveedor
            // 
            this.ultraButtonElminarProveedor.Location = new System.Drawing.Point(179, 203);
            this.ultraButtonElminarProveedor.Name = "ultraButtonElminarProveedor";
            this.ultraButtonElminarProveedor.Size = new System.Drawing.Size(120, 23);
            this.ultraButtonElminarProveedor.TabIndex = 2;
            this.ultraButtonElminarProveedor.Text = "Eliminar";
            this.ultraButtonElminarProveedor.Click += new System.EventHandler(this.ultraButtonElminarProveedor_Click);
            // 
            // ultraButtonModificar
            // 
            this.ultraButtonModificar.Location = new System.Drawing.Point(342, 203);
            this.ultraButtonModificar.Name = "ultraButtonModificar";
            this.ultraButtonModificar.Size = new System.Drawing.Size(120, 23);
            this.ultraButtonModificar.TabIndex = 3;
            this.ultraButtonModificar.Text = "Modificar";
            this.ultraButtonModificar.Click += new System.EventHandler(this.ultraButtonModificar_Click);
            // 
            // FormListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 262);
            this.Controls.Add(this.ultraButtonModificar);
            this.Controls.Add(this.ultraButtonElminarProveedor);
            this.Controls.Add(this.ultraButtonNuevo);
            this.Controls.Add(this.radGridViewListadoProveedor);
            this.Name = "FormListado";
            this.Text = "Listado proveedor";
            this.Activated += new System.EventHandler(this.FormListado_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewListadoProveedor.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewListadoProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridViewListadoProveedor;
        private Infragistics.Win.Misc.UltraButton ultraButtonNuevo;
        private Infragistics.Win.Misc.UltraButton ultraButtonElminarProveedor;
        private Infragistics.Win.Misc.UltraButton ultraButtonModificar;
    }
}