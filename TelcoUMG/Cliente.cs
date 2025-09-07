using System;


namespace CapaEntidades
{
    public class Cliente
    {
        public int CodigoCliente { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Dpi { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Estado { get; set; } = "Activo";


        public string NombreCompleto => ($"{Nombre} {Apellido}").Trim();
    }
}