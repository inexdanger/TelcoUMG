using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    internal class CD_Conexion
    {
        private SqlConnection db_conexion = new SqlConnection("Server=localhost;Database=TelcoUMG;Uid=admin;Pwd=admin;");
         
        public SqlConnection MtdAbrirConexion()
        {
            if (db_conexion.State == ConnectionState.Closed)
            {
                db_conexion.Open();
            }
            return db_conexion;
        }

        public SqlConnection MtdCerrarConexion()
        {
            if(db_conexion.State == ConnectionState.Open)
            {
                db_conexion.Close();
            }
            return db_conexion;
        }
    }
}
