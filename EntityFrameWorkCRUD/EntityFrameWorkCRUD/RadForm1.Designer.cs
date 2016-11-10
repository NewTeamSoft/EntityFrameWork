namespace EntityFrameWorkCRUD
{
    partial class RadForm1
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
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn1 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Codigo");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn2 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Nombre");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn3 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Apellido");
            Telerik.WinControls.UI.ListViewDetailColumn listViewDetailColumn4 = new Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Partido");
            this.telerikMetroTouchTheme1 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.radListViewPartidoPolitico = new Telerik.WinControls.UI.RadListView();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.radTextBoxNombre = new Telerik.WinControls.UI.RadTextBox();
            this.textBoxPartidoPolitico = new System.Windows.Forms.TextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radButtonAgregar = new Telerik.WinControls.UI.RadButton();
            this.radButtonModificar = new Telerik.WinControls.UI.RadButton();
            this.radButtonEliminar = new Telerik.WinControls.UI.RadButton();
            this.radButtonNuevo = new Telerik.WinControls.UI.RadButton();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.radDropDownListPartidoPolitico = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.radListViewPartidoPolitico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListPartidoPolitico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radListViewPartidoPolitico
            // 
            listViewDetailColumn1.HeaderText = "Codigo";
            listViewDetailColumn1.Width = 50F;
            listViewDetailColumn2.HeaderText = "Nombre";
            listViewDetailColumn2.Width = 150F;
            listViewDetailColumn3.HeaderText = "Apellido";
            listViewDetailColumn3.Width = 150F;
            listViewDetailColumn4.HeaderText = "Partido";
            listViewDetailColumn4.Width = 150F;
            this.radListViewPartidoPolitico.Columns.AddRange(new Telerik.WinControls.UI.ListViewDetailColumn[] {
            listViewDetailColumn1,
            listViewDetailColumn2,
            listViewDetailColumn3,
            listViewDetailColumn4});
            this.radListViewPartidoPolitico.Location = new System.Drawing.Point(10, 160);
            this.radListViewPartidoPolitico.Name = "radListViewPartidoPolitico";
            this.radListViewPartidoPolitico.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radListViewPartidoPolitico.ShowGroups = true;
            this.radListViewPartidoPolitico.Size = new System.Drawing.Size(458, 162);
            this.radListViewPartidoPolitico.TabIndex = 0;
            this.radListViewPartidoPolitico.Text = "radListView1";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(82, 34);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(154, 20);
            this.textBoxApellido.TabIndex = 1;
            // 
            // radTextBoxNombre
            // 
            this.radTextBoxNombre.Location = new System.Drawing.Point(82, 8);
            this.radTextBoxNombre.Name = "radTextBoxNombre";
            this.radTextBoxNombre.Size = new System.Drawing.Size(154, 20);
            this.radTextBoxNombre.TabIndex = 3;
            // 
            // textBoxPartidoPolitico
            // 
            this.textBoxPartidoPolitico.Location = new System.Drawing.Point(360, 12);
            this.textBoxPartidoPolitico.Name = "textBoxPartidoPolitico";
            this.textBoxPartidoPolitico.Size = new System.Drawing.Size(108, 20);
            this.textBoxPartidoPolitico.TabIndex = 2;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(10, 8);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(66, 23);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "Nombre:";
            this.radLabel1.ThemeName = "TelerikMetroTouch";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(242, 9);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(112, 23);
            this.radLabel3.TabIndex = 5;
            this.radLabel3.Text = "Partido politico:";
            this.radLabel3.ThemeName = "TelerikMetroTouch";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 36);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(66, 23);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Apellido:";
            this.radLabel2.ThemeName = "TelerikMetroTouch";
            // 
            // radButtonAgregar
            // 
            this.radButtonAgregar.Location = new System.Drawing.Point(126, 71);
            this.radButtonAgregar.Name = "radButtonAgregar";
            this.radButtonAgregar.Size = new System.Drawing.Size(110, 32);
            this.radButtonAgregar.TabIndex = 6;
            this.radButtonAgregar.Text = "Agregar";
            this.radButtonAgregar.ThemeName = "TelerikMetroTouch";
            this.radButtonAgregar.Click += new System.EventHandler(this.radButtonAgregar_Click);
            // 
            // radButtonModificar
            // 
            this.radButtonModificar.Location = new System.Drawing.Point(242, 71);
            this.radButtonModificar.Name = "radButtonModificar";
            this.radButtonModificar.Size = new System.Drawing.Size(110, 32);
            this.radButtonModificar.TabIndex = 7;
            this.radButtonModificar.Text = "Modificar";
            this.radButtonModificar.ThemeName = "TelerikMetroTouch";
            // 
            // radButtonEliminar
            // 
            this.radButtonEliminar.Location = new System.Drawing.Point(358, 71);
            this.radButtonEliminar.Name = "radButtonEliminar";
            this.radButtonEliminar.Size = new System.Drawing.Size(110, 32);
            this.radButtonEliminar.TabIndex = 8;
            this.radButtonEliminar.Text = "Eliminar";
            this.radButtonEliminar.ThemeName = "TelerikMetroTouch";
            this.radButtonEliminar.Click += new System.EventHandler(this.radButtonEliminar_Click);
            // 
            // radButtonNuevo
            // 
            this.radButtonNuevo.Location = new System.Drawing.Point(10, 71);
            this.radButtonNuevo.Name = "radButtonNuevo";
            this.radButtonNuevo.Size = new System.Drawing.Size(110, 32);
            this.radButtonNuevo.TabIndex = 9;
            this.radButtonNuevo.Text = "Nuevo";
            this.radButtonNuevo.ThemeName = "TelerikMetroTouch";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(5, 117);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(191, 23);
            this.radLabel4.TabIndex = 6;
            this.radLabel4.Text = " Seleccione partido politico:";
            this.radLabel4.ThemeName = "TelerikMetroTouch";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(10, 338);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(458, 137);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Codigo:";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apellido";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Partido";
            this.columnHeader4.Width = 150;
            // 
            // radDropDownListPartidoPolitico
            // 
            this.radDropDownListPartidoPolitico.AllowShowFocusCues = false;
            this.radDropDownListPartidoPolitico.AutoCompleteDisplayMember = null;
            this.radDropDownListPartidoPolitico.AutoCompleteValueMember = null;
            this.radDropDownListPartidoPolitico.Location = new System.Drawing.Point(202, 117);
            this.radDropDownListPartidoPolitico.Name = "radDropDownListPartidoPolitico";
            this.radDropDownListPartidoPolitico.Size = new System.Drawing.Size(266, 30);
            this.radDropDownListPartidoPolitico.TabIndex = 0;
            this.radDropDownListPartidoPolitico.ThemeName = "TelerikMetroTouch";
            this.radDropDownListPartidoPolitico.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.radDropDownListPartidoPolitico_SelectedIndexChanged);
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 487);
            this.Controls.Add(this.radDropDownListPartidoPolitico);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radButtonNuevo);
            this.Controls.Add(this.radButtonEliminar);
            this.Controls.Add(this.radButtonModificar);
            this.Controls.Add(this.radButtonAgregar);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.textBoxPartidoPolitico);
            this.Controls.Add(this.radTextBoxNombre);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.radListViewPartidoPolitico);
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "PARTIDO POLITICO";
            this.ThemeName = "TelerikMetroTouch";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radListViewPartidoPolitico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBoxNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButtonNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownListPartidoPolitico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme1;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadListView radListViewPartidoPolitico;
        private System.Windows.Forms.TextBox textBoxApellido;
        private Telerik.WinControls.UI.RadTextBox radTextBoxNombre;
        private System.Windows.Forms.TextBox textBoxPartidoPolitico;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton radButtonAgregar;
        private Telerik.WinControls.UI.RadButton radButtonModificar;
        private Telerik.WinControls.UI.RadButton radButtonEliminar;
        private Telerik.WinControls.UI.RadButton radButtonNuevo;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Telerik.WinControls.UI.RadDropDownList radDropDownListPartidoPolitico;
    }
}