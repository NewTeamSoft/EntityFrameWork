using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;
using System.Windows.Forms;


namespace EntityFrameWorkCRUD
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        DB_PresidentesEntities bd = new DB_PresidentesEntities();
        int index = 0;
        int opcional = 1;
        public RadForm1()
        {
            InitializeComponent();
        } 
        private void radButtonAgregar_Click(object sender, EventArgs e)
        {
            if (opcional == 0)
            {
                addPresidentes();
                MessageBox.Show("Agregado correctamente");
            }
            if (opcional == 1 )
            {
                updatePresidente(Convert.ToInt16(listView1.Items[index].SubItems[0].Text));
                MessageBox.Show("Actualizado correctamente");
                radButtonAgregar.Text = "Agregar";
                opcional = 0;
            }
            limpiar();
            listarDatos();
            listarPartidos();
            
        }
        private void addPresidentes()
        {
            Presidentes pre = new Presidentes()
            {
                PRE_nombre = radTextBoxNombre.Text,
                PRE_apellidos = textBoxApellido.Text,
                PRE_partido = textBoxPartidoPolitico.Text
            };
            bd.Presidentes.Add(pre);
            bd.SaveChanges();

        }
        private void listarDatos()
        {
            listView1.Items.Clear();
            radListViewPartidoPolitico.Items.Clear();

            var query = from p in bd.Presidentes
                        select p;


            foreach (var item in query)
            {
                ListViewItem lsview = listView1.Items.Add(item.PRE_codigo.ToString());
                lsview.SubItems.Add(item.PRE_nombre);
                lsview.SubItems.Add(item.PRE_apellidos);
                lsview.SubItems.Add(item.PRE_partido);
                radListViewPartidoPolitico.Items.Add(item.PRE_codigo.ToString());
                radListViewPartidoPolitico.Items.Add(item.PRE_nombre);
                radListViewPartidoPolitico.Items.Add(item.PRE_apellidos);
                radListViewPartidoPolitico.Items.Add(item.PRE_partido);
            }
        }
        private void limpiar()
        {
            radTextBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxPartidoPolitico.Clear();
            listarDatos();
            radButtonAgregar.Text ="Agregar";
            opcional = 0;

        }
        private void listarPartidos()
        {
            var query = (from p in bd.Presidentes
                         select p.PRE_partido).Concat
                        (from a in bd.Presidentes select "--Selecciones--");
            radDropDownListPartidoPolitico.DisplayMember = "PRE_partido";
            radDropDownListPartidoPolitico.DataSource = query.Distinct().ToList();
        }
        private void listarPorPartido(string partido)
        {
            listView1.Items.Clear();
            var query = from p in bd.Presidentes
                        where p.PRE_partido == partido
                        select p;

            foreach (var item in query)
            {
                ListViewItem lsViewItem = listView1.Items.Add(item.PRE_codigo.ToString());
                lsViewItem.SubItems.Add(item.PRE_nombre);
                lsViewItem.SubItems.Add(item.PRE_partido);
                lsViewItem.SubItems.Add(item.PRE_apellidos);
            }
        }

        private void updatePresidente(int codigo)
        {
            Presidentes presi = (from p in bd.Presidentes
                                 where p.PRE_codigo == codigo
                                 select p).FirstOrDefault();

            presi.PRE_nombre = radTextBoxNombre.Text;
            presi.PRE_apellidos = textBoxApellido.Text;
            presi.PRE_partido = textBoxPartidoPolitico.Text;

            bd.SaveChanges();
        }

        private void eliminarPresidente(int codigo)
        {
            //Presidentes presi = (from p in bd.Presidentes
            //                     where p.PRE_codigo == codigo
            //                     select p).FirstOrDefault();

            Presidentes presi = bd.Presidentes.First(p => p.PRE_codigo == codigo);

            bd.Presidentes.Remove(presi);
            bd.SaveChanges();

        }
        private void RadForm1_Load(object sender, EventArgs e)
        {
            listarDatos();
            listarPartidos();
        }       
        private void radButtonEliminar_Click(object sender, EventArgs e)
        {
            eliminarPresidente(Convert.ToInt16(listView1.Items[index].SubItems[0].Text));
            MessageBox.Show("Eliminado Correctamente");
            limpiar();
        }     
        private void radDropDownListPartidoPolitico_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (radDropDownListPartidoPolitico.Items.Count == 0)
            {
                return;
            }
            if (radDropDownListPartidoPolitico.SelectedIndex != 0 )//&& radDropDownListPartidoPolitico.SelectedItem.Text != "--Selecciones--")
            {
                listarPorPartido(radDropDownListPartidoPolitico.Text.Trim());
            }
            else
            {
                listarDatos();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                return;
            }
            radTextBoxNombre.Text = listView1.Items[index].SubItems[1].Text;
            textBoxApellido.Text = listView1.Items[index].SubItems[2].Text;
            textBoxPartidoPolitico.Text = listView1.Items[index].SubItems[3].Text;

            radButtonAgregar.Text = "Actualizar";
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            index = e.Item.Index;
        }
    }
}
