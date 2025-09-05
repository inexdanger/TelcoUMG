using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Clientes
    {
        CD_Conexion conexion = new CD_Conexion();

        public DataTable Mtd_ConsultarClientes()
        {
            string QueryConsultarClietnes = "select * from tbl_Clientes;";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(QueryConsultarClietnes, conexion.MtdAbrirConexion());
            adapter.Fill(dt);
            conexion.MtdCerrarConexion();
            return dt;
        }

        public void Mtd_AgregarClientes(string Nombre, string  Apellido, int Dpi, int Telefono, string Email, string Estado)
        {
            string QueryAgregarCliente = "insert into tbl_Clientes (Nombre,Apellido,Dpi,Telefono,Email,Estado) values (@Nombre,@Apellido,@Dpi,@Telefono,@Email,@Estado);";
            SqlCommand cmd = new SqlCommand(QueryAgregarCliente, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("Apellido", Apellido);
            cmd.Parameters.AddWithValue("Dpi", Dpi);
            cmd.Parameters.AddWithValue("@Telefono",Telefono);
            cmd.Parameters.AddWithValue("@Email",Email);
            cmd.Parameters.AddWithValue("@Estado",Estado);
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        }

    }
}
