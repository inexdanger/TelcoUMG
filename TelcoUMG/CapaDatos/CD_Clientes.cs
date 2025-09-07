using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Clientes
    {
        CD_Conexion conexion = new CD_Conexion();

        public DataTable Mtd_ConsultarClientes()
        {
            string query = "SELECT * FROM tbl_Clientes;";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, conexion.MtdAbrirConexion());
            da.Fill(dt);
            conexion.MtdCerrarConexion();
            return dt;
        }

        public void Mtd_AgregarClientes(string Nombre, string Apellido, int Dpi, int Telefono, string Email, string Estado)
        {
            string query = @"INSERT INTO tbl_Clientes (Nombre, Apellido, Dpi, Telefono, Email, Estado)
                             VALUES (@Nombre, @Apellido, @Dpi, @Telefono, @Email, @Estado);";
            SqlCommand cmd = new SqlCommand(query, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Apellido", Apellido);
            cmd.Parameters.AddWithValue("@Dpi", Dpi);
            cmd.Parameters.AddWithValue("@Telefono", Telefono);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        }

        // NUEVO: Update
        public void Mtd_ActualizarCliente(int CodigoCliente, string Nombre, string Apellido, int Dpi, int Telefono, string Email, string Estado)
        {
            string query = @"UPDATE tbl_Clientes
                             SET Nombre=@Nombre, Apellido=@Apellido, Dpi=@Dpi, Telefono=@Telefono, Email=@Email, Estado=@Estado
                             WHERE CodigoCliente=@CodigoCliente;";
            SqlCommand cmd = new SqlCommand(query, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoCliente", CodigoCliente);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Apellido", Apellido);
            cmd.Parameters.AddWithValue("@Dpi", Dpi);
            cmd.Parameters.AddWithValue("@Telefono", Telefono);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        }

        // NUEVO: Delete
        public void Mtd_EliminarCliente(int CodigoCliente)
        {
            string query = "DELETE FROM tbl_Clientes WHERE CodigoCliente=@CodigoCliente;";
            SqlCommand cmd = new SqlCommand(query, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoCliente", CodigoCliente);
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        }
    }
}
