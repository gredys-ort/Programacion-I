using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_9_Progra.Clases
{
     internal class cls_archivo
    {
        public string[] LeerArchivo(string archivo)
        {
            string[] lineas = File.ReadAllLines(archivo, Encoding.Default);
            return lineas;
        }
        public string LeerTodoArchivo(string archivo)
        {
            string ContenidoArchivo;

            using (StreamReader reader = new StreamReader(archivo, Encoding.UTF7))
            {
                ContenidoArchivo = reader.ReadToEnd();
            }
            return ContenidoArchivo;
        }
    }
}
