using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public static class negocio
    {
        public static void guardar (string nombre,  string telefono)
        {
            using (dbEntityDataContext db = new dbEntityDataContext())
            {
                persona per = new persona()
                {
                    nombre = nombre,
                    telefono = telefono
                };

                db.personas.InsertOnSubmit(per);
                db.SubmitChanges();
            }
        }

        public static void mostrar (ListBox listBox )
        {
            using (dbEntityDataContext db = new dbEntityDataContext())
            {
                var consulta = from x in db.personas
                               orderby x.id descending
                               select x;
                foreach (persona p in consulta)
                {
                    listBox.Items.Add(p.id + " " + p.nombre + " " + p.telefono);
                }
            }
        }

        public static void mostrar(ComboBox comboBox)
        {
            using (dbEntityDataContext db = new dbEntityDataContext())
            {
                var consulta = from x in db.personas
                               orderby x.id descending
                               select x;
                foreach (var item in consulta)
                {
                    comboBox.Items.Add(item.nombre);
                }
            }
        }
        static int ID;
        private static void obtenerID(string datos)
        {
           
            using ( dbEntityDataContext db = new dbEntityDataContext())
            {
                var consulta = from x in db.personas
                               where x.nombre == datos
                               select x;
                foreach (persona item in consulta)
                {
                    ID = item.id;
                }
            }
        }

        public static void modificar(string nombre, string telefono, string datos)
        {
            obtenerID(datos);
            using (dbEntityDataContext db = new dbEntityDataContext())
            {
                var consulta = (from x in db.personas
                                where x.id == ID
                                select x).First();
                consulta.nombre = nombre;
                consulta.telefono = telefono;
                db.SubmitChanges();
            }
        }
        public static void cargar(string datos, TextBox nombre, TextBox telefono)
        {
            obtenerID(datos);
            using (dbEntityDataContext db = new dbEntityDataContext()) 
            {
                var consulta = from x in db.personas
                               where x.id == ID
                               select x;
                foreach (persona item in consulta)
                {
                    nombre.Text = item.nombre;
                    telefono.Text = item.telefono.ToString();
                }
            }
        }
        public static void eliminar(string datos)
        {
            using (dbEntityDataContext db = new dbEntityDataContext())
            {
                var consulta = from x in db.personas
                               where (x.id + " " + x.nombre + " " + x.telefono) == datos
                               select x;
                foreach (persona item in consulta)
                {
                    db.personas.DeleteOnSubmit(item);
                }
                db.SubmitChanges();
            }
        }
    }
}
