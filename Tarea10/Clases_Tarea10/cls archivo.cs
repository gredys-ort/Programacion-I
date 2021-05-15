using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace Tarea10.Clases_Tarea10
{
    public class cls_archivo
    {
        public string[] LeerArchivo(string archivo)
        {
            String[] lineas = File.ReadAllLines(archivo, Encoding.Default);
            return lineas;
        }

        public string LeerTodoArchivo(string archivo)
        {
            string ContenidoArchivo;
            using (StreamReader reader = new StreamReader(archivo, Encoding.UTF8))
            {
                ContenidoArchivo = reader.ReadToEnd();
            }
            return ContenidoArchivo;
        }


        //puede tambien contener arreglo
        //sobre escribe el archivo si ya tiene informacion
        public void grabarArchivoNuevo(String archivo, String contenido)
        {
            File.WriteAllText(archivo, contenido);
        }

        public void agreagarDatosArchivo(String archivo, String Contenido)
        {
            using (StreamWriter sw = File.AppendText(archivo))
            {
                sw.WriteLine(Contenido);

            }
        }
    }
}