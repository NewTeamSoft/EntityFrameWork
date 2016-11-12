using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
using CapaEntidad;
using System.Data;

namespace CapaLogica
{
    public static class Users
    {
        public static DataTable mostrarUsuario()
        {
            return CapaDato.Users.mostrarUsuario();
        }

        public static DataTable insertarUsuario(string nombre, string apellido)
        {
            EntidadUsers users = new EntidadUsers()
            {
                nombre = nombre,
                apellido = apellido
            };

            return CapaDato.Users.insertarUsuario(users);
        }

        public static DataTable actualizarUsuario(int usuarioId,string nombre, string apellido)
        {
            EntidadUsers users = new EntidadUsers()
            {
                usuarioId = usuarioId,
                nombre = nombre,
                apellido = apellido
            };

            return CapaDato.Users.actualizarUsuario(users);
        }

        public static DataTable buscarUsuario(string buscarNombreApellido)
        {
            EntidadUsers users = new EntidadUsers()
            {
                nombre = buscarNombreApellido,
                apellido = buscarNombreApellido
            };

            return CapaDato.Users.buscarUsuario(users);
        }
    }
}
