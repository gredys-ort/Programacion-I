using MySqlConnector;
using Progra1Bot.Clases.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Progra1Bot.Clases.CONEXIONES
{
    class OperacionesDb
    {

        public OperacionesDb()
        {
        }

        public static List<String> obtenerSeccion()
        {
            string query = "SELECT Seccion FROM alumnos";
            List<String> secciones = new List<string>();

            MySqlConnection conexionDb = ConnectionDb.conexion();
            conexionDb.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(query, conexionDb);
                //comando.ExecuteNonQuery();

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var sec = reader["Seccion"].ToString();
                        secciones.Add(sec);
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

            finally
            {
                conexionDb.Close();
            }

            return secciones;
        }

        public static Alumno obtenerAlumnoId(String id)
        {
            string query = "SELECT * FROM ALUMNOS WHERE id = '" + id + "'";
            Alumno alumno = new Alumno();

            MySqlConnection conexionDb = ConnectionDb.conexion();
            conexionDb.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(query, conexionDb);
                //comando.ExecuteNonQuery();

                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        
                        alumno.Nombre = reader["Nombre"].ToString();
                        alumno.Seccion = reader["Seccion"].ToString();
                        alumno.Parcial1 = Convert.ToDouble(reader["Parcial1"].ToString());
                        alumno.Parcial2 = Convert.ToDouble(reader["Parcial2"].ToString());
                        alumno.Parcial3 = Convert.ToDouble(reader["Parcial3"].ToString());
                        alumno.Parcial4 = Convert.ToDouble(reader["Parcial4"].ToString());
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

            finally
            {
                conexionDb.Close();
            }

            return alumno;
        }

    }
}
