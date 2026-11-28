
using MySqlConnector;

namespace PSI_APRENDE
{
    internal class Conexion
    {
        public static MySqlConnection Conectar()
        {
            string? datos = Environment.GetEnvironmentVariable("PSIAPRENDE_MYSQL");

            if (string.IsNullOrEmpty(datos))
            {
                throw new Exception("No se configuró la conexión a MySQL");
            }

            MySqlConnection conexion = new MySqlConnection(datos);
            conexion.Open();

            return conexion;
        }
    }
}

