﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Progra1Bot.Clases.Archivo
{
    class ClsArchivo
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
