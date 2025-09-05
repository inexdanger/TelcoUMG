using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Empleados
    {
        CD_Conexion conexion = new CD_Conexion();

        public DataTable Mtd_ConsultarEmpleados()
        {
            string QueryConsultarEmp = "select * from tbl_Empleados;";
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(QueryConsultarEmp, conexion.MtdAbrirConexion());
            adapter.Fill(dt);
            conexion.MtdCerrarConexion();
            return dt;
        }

        public void Mtd_AgregarEmpleados(string Nombre, int Dpi, string Direccion, DateTime FechaIngreso, double SalarioBase, string TipoEmpleado, string Estado)
        {
            string QueryAgregar = "insert into tbl_Empleados (Nombre, Dpi, Direccion, FechaIngreso, SalarioBase, TipoEmpleado, Estado) values (@Nombre,@Dpi,@Direccion,@FechaIngreso,@SalarioBase,@TipoEmpleado,@Estado);";
            SqlCommand cmd = new SqlCommand(QueryAgregar, conexion.MtdAbrirConexion());
            cmd.Parameters.AddWithValue("@Nombre", Nombre);
            cmd.Parameters.AddWithValue("@Dpi",Dpi);
            cmd.Parameters.AddWithValue("@Direccion",Direccion);
            cmd.Parameters.AddWithValue("@FechaIngreso",FechaIngreso);
            cmd.Parameters.AddWithValue("@SalarioBase",SalarioBase);
            cmd.Parameters.AddWithValue("@TipoEmpleado",TipoEmpleado);
            cmd.Parameters.AddWithValue("@Estado",Estado);
            cmd.ExecuteNonQuery();
            conexion.MtdCerrarConexion();
        }

    }
}
