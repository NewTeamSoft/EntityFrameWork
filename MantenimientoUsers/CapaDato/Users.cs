using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidad;
using System.Data;

namespace CapaDato
{
    public static class Users
    {
        public static DataTable mostrarUsuario()
        {
           return Datos.ejecutarDataTable("uspView", null, "StoredProcedure");
        }
        
        public static DataTable insertarUsuario(EntidadUsers users)
        {
             List<SqlParameter> listParameter = new List<SqlParameter>()
            {
               new SqlParameter() {ParameterName = "@nombre", SqlDbType = SqlDbType.VarChar, SqlValue = users.nombre,Size = 20 },
               new SqlParameter() {ParameterName = "@apellido", SqlDbType = SqlDbType.VarChar, SqlValue = users.apellido,Size = 20 }
            };

            return Datos.ejecutarDataTable("uspInsertar", listParameter, "StoredProcedure");
        }

        public static DataTable actualizarUsuario(EntidadUsers users)
        {
            List<SqlParameter> listParameter = new List<SqlParameter>()
            {
               new SqlParameter() {ParameterName = "@usuarioId", SqlDbType = SqlDbType.Int, SqlValue = users.usuarioId},
               new SqlParameter() {ParameterName = "@nombre", SqlDbType = SqlDbType.VarChar, SqlValue = users.nombre,Size = 20 },
               new SqlParameter() {ParameterName = "@apellido", SqlDbType = SqlDbType.VarChar, SqlValue = users.apellido,Size = 20 }
            };

            return Datos.ejecutarDataTable("usUpdate", listParameter, "StoredProcedure");
        }

        public static DataTable buscarUsuario(EntidadUsers users)
        {
            List<SqlParameter> listParameter = new List<SqlParameter>()
            {
               new SqlParameter() {ParameterName = "@nombre", SqlDbType = SqlDbType.VarChar, SqlValue = users.nombre,Size = 20 },
               new SqlParameter() {ParameterName = "@apellido", SqlDbType = SqlDbType.VarChar, SqlValue = users.apellido,Size = 20 }
            };

            return Datos.ejecutarDataTable("uspFiltrer", listParameter, "StoredProcedure");
        }
    }
}
