// CapaDatos/CD_Proveedores.cs
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Proveedores
    {
        private readonly CD_Conexion conexion = new CD_Conexion();

        // LISTAR
        public DataTable Mtd_ConsultarProveedores()
        {
            string query = "SELECT CodigoProveedor, Nombre, Contacto, Telefono, Email, Direccion, Estado FROM tbl_Proveedores;";
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(query, conexion.MtdAbrirConexion()))
            {
                da.Fill(dt);
            }
            conexion.MtdCerrarConexion();
            return dt;
        }

        // INSERTAR
        public void Mtd_AgregarProveedor(string codigoProveedor, string nombre, string contacto,
                                         string telefono, string email, string direccion, string estado)
        {
            string query = @"
                INSERT INTO tbl_Proveedores
                (CodigoProveedor, Nombre, Contacto, Telefono, Email, Direccion, Estado)
                VALUES (@CodigoProveedor, @Nombre, @Contacto, @Telefono, @Email, @Direccion, @Estado);";

            using (SqlCommand cmd = new SqlCommand(query, conexion.MtdAbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@CodigoProveedor", codigoProveedor);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Contacto", contacto);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.ExecuteNonQuery();
            }
            conexion.MtdCerrarConexion();
        }

        // EDITAR
        public void Mtd_EditarProveedor(string codigoProveedor, string nombre, string contacto,
                                        string telefono, string email, string direccion, string estado)
        {
            string query = @"
                UPDATE tbl_Proveedores SET
                    Nombre    = @Nombre,
                    Contacto  = @Contacto,
                    Telefono  = @Telefono,
                    Email     = @Email,
                    Direccion = @Direccion,
                    Estado    = @Estado
                WHERE CodigoProveedor = @CodigoProveedor;";

            using (SqlCommand cmd = new SqlCommand(query, conexion.MtdAbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@CodigoProveedor", codigoProveedor);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Contacto", contacto);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                cmd.Parameters.AddWithValue("@Estado", estado);
                cmd.ExecuteNonQuery();
            }
            conexion.MtdCerrarConexion();
        }

        // ELIMINAR
        public void Mtd_EliminarProveedor(string codigoProveedor)
        {
            string query = "DELETE FROM tbl_Proveedores WHERE CodigoProveedor = @CodigoProveedor;";
            using (SqlCommand cmd = new SqlCommand(query, conexion.MtdAbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@CodigoProveedor", codigoProveedor);
                cmd.ExecuteNonQuery();
            }
            conexion.MtdCerrarConexion();
        }
    }
}
