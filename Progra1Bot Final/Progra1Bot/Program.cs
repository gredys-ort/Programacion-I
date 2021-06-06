
using Progra1Bot.Clases;
using Progra1Bot.Clases.Archivo;
using Progra1Bot.Clases.CONEXIONES;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.InlineQueryResults;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.ReplyMarkups;

namespace Progra1Bot
{
    class Program
    {
        private static TelegramBotClient Bot;

        public static async Task Main(string[] args)
        {

            string fuente = @"C:\Users\Usuario\Documents\Archivos scv\crudDB.csv";
            ClsArchivo ar = new ClsArchivo();

            //obtener todo el archivo de un arreglo
            string[] ArregloNotas = ar.LeerArchivo(fuente);
            string SentenciaSql = "";
            int NumeroLinea = 0;

            //iteramos sobre el arreglo, linea por linea
            //para luego convertirlos en datos individuales
            ClsConexion cn = new ClsConexion();
            foreach (string linea in ArregloNotas)
            {
                string[] datos = linea.Split(';');
                if (NumeroLinea > 0)
                {
                    SentenciaSql = $"insert into alumnos values({datos[0]},{datos[1]},{datos[2]},{datos[3]},{datos[4]},{datos[5]},'{datos[6]}','{datos[7]}');\n";
                    cn.consultaTablaDirecta(SentenciaSql);
                }
                NumeroLinea++;
            }
            NumeroLinea = 0;

            await new clsBotAlumnos().IniciarTelegram();
        }

    } // fin de la clase

  
}
































































// await new clsEjemplo2().IniciarTelegram();
// await new clsBotAlumnos().IniciarTelegram();

