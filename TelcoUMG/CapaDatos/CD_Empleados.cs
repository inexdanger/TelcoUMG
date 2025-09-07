using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Empleados
    {
        CD_Conexion conexion = new CD_Conexion();

        public DataTable Mtd_ConsultarEmpleados()
        {
            string query = "SELECT * FROM tbl_Empleados;";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, conexion.MtdAbrirConexion());
            da.Fill(dt);
            conexion.MtdCerrarConexion();
            return dt;
        }

        public void Mtd_AgregarEmpleados(string Nombre, int Dpi, string Direccion, DateTime FechaIngreso, double SalarioBase, string TipoEmpleado, string Estado)
        {
            string query = @"INSERT INTO tbl_Empleados (Nombre, Dpi, Direccion, FechaIngreso, SalarioBase, TipoEmpleado, Estado)
                             VALUES (@Nombre, @Dpi, @Direccion, @FechaIngreso, @SalarioBase, @TipoEmpleado, @Estado);";
            SqlCommand cmd = new SqlCommand(query, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Dpi", Dpi);
            cmd.Parameters.AddWithValue("@Direccion", Direccion);
            cmd.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
            // SalarioBase en DB es DECIMAL(10,2) — enviamos como decimal
            cmd.Parameters.AddWithValue("@SalarioBase", (decimal)SalarioBase);
            cmd.Parameters.AddWithValue("@TipoEmpleado", TipoEmpleado);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        }

        // NUEVO: Update
        public void Mtd_ActualizarEmpleado(int CodigoEmpleado, string Nombre, int Dpi, string Direccion, DateTime FechaIngreso, double SalarioBase, string TipoEmpleado, string Estado)
        {
            string query = @"UPDATE tbl_Empleados
                             SET Nombre=@Nombre, Dpi=@Dpi, Direccion=@Direccion, FechaIngreso=@FechaIngreso,
                                 SalarioBase=@SalarioBase, TipoEmpleado=@TipoEmpleado, Estado=@Estado
                             WHERE CodigoEmpleado=@CodigoEmpleado;";
            SqlCommand cmd = new SqlCommand(query, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Dpi", Dpi);
            cmd.Parameters.AddWithValue("@Direccion", Direccion);
            cmd.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
            cmd.Parameters.AddWithValue("@SalarioBase", (decimal)SalarioBase);
            cmd.Parameters.AddWithValue("@TipoEmpleado", TipoEmpleado);
            cmd.Parameters.AddWithValue("@Estado", Estado);
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        }

        // NUEVO: Delete
        public void Mtd_EliminarEmpleado(int CodigoEmpleado)
        {
            string query = "DELETE FROM tbl_Empleados WHERE CodigoEmpleado=@CodigoEmpleado;";
            SqlCommand cmd = new SqlCommand(query, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@CodigoEmpleado", CodigoEmpleado);
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        }
    }
}
