using MySqlConnector;
using System;

namespace Progra1Bot.Clases.CONEXIONES
{
    class ConnectionDb
    {
        private static string server = "localhost";
        private static string database = "db_final_progra";
        private static string userId = "root";
        private static string pass = "MYSQL2021";
        public static MySqlConnection conexion()
        {
            string cadenaConexion = "Database=" + database + "; Data Source=" + server + "; User Id=" + userId + "; Password=" + pass + "; Convert Zero Datetime=True";

            try
            {
                MySqlConnection connection = new MySqlConnection(cadenaConexion);
                return connection;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
    }
}
