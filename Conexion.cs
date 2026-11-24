using System;
using System.Data.SqlClient;

namespace sistemasRegistrosSalario
{
    internal class Conexion
    {
        private string cadena = @"Server=HP_KYRA_1101200;Database=registroSalario;Integrated Security=True;TrustServerCertificate=True;";

        public SqlConnection Conectar()
        {
            return new SqlConnection(cadena);
        }
    }
}
