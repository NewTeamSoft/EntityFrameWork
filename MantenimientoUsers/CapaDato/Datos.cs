using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CapaDato
{
    public static class Datos
    {
       public static SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MantenimientoUsers"].ConnectionString);
    
        public static DataTable ejecutarDataTable(string stringSqlParamConsultaSQl, List<SqlParameter> listSqlParameter = null, string stringParamCommandType = "CommandText")
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

            try
            {
                if(sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
                sqlDataAdapter.SelectCommand = new SqlCommand(stringSqlParamConsultaSQl, sqlConnection);
                sqlDataAdapter.SelectCommand.CommandType = stringParamCommandType == "CommandText" ? CommandType.Text : CommandType.StoredProcedure;
                if(listSqlParameter != null)
                {
                    foreach (SqlParameter sqlParameter in listSqlParameter)
                    {
                        sqlDataAdapter.SelectCommand.Parameters.Add(sqlParameter);
                    }
                }

                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception exception)
            {

                throw new Exception(exception.Message);
            }
            finally
            {
                sqlConnection.Close();
                sqlDataAdapter.Dispose();
            }

            return dataTable;
        }

    }
}
