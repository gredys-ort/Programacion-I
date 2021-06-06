
using Progra1Bot.Clases.CONEXIONES;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;



namespace Progra1Bot.Clases
{
    class clsBotAlumnos
    {
        private static TelegramBotClient Bot;


        public async Task IniciarTelegram()
        {
            Bot = new TelegramBotClient("1881357157:AAEFhRKTKUog27rsT5xwNO568LkuhmA_rbk");

            var me = await Bot.GetMeAsync();
            Console.Title = me.Username;

            Bot.OnMessage += BotCuandoRecibeMensajes;
            Bot.OnMessageEdited += BotCuandoRecibeMensajes;
            Bot.OnReceiveError += BotOnReceiveError;

            Bot.StartReceiving(Array.Empty<UpdateType>());
            Console.WriteLine($"escuchando solicitudes del BOT @{me.Username}");



            Console.ReadLine();
            Bot.StopReceiving();
        }



        // cuando recibe mensajes
        private static async void BotCuandoRecibeMensajes(object sender, MessageEventArgs messageEventArgumentos)
        {
            var ObjetoMensajeTelegram = messageEventArgumentos;
            var mensajes = ObjetoMensajeTelegram.Message;

            string mensajeEntrante = mensajes.Text.ToLower();

 
            string id_manda_mensaje = mensajes.Chat.Id.ToString();
           

            string respuesta = "Lo siento, no te puedo entender \n" +
                        "Opciones validas\n*consultar alumno*\n*consultar promedio*\n*consultar seccion*" +
                        "\n*consultar parcial1*\n*consultar parcial2*\n*consultar parcial3*\n*consultar parcial4*" +
                        "\n*consultar datos*";
            if (mensajes == null || mensajes.Type != MessageType.Text)
                return;


            if (mensajeEntrante.Contains("consultar alumno"))
            {
                respuesta = emojis.mdEmoji.saludo + "Escriba alumno seguido de correlativo, ejemplo: alumno 1";
            }

            if (mensajeEntrante.StartsWith("alumno"))
            {
                var correlativo = mensajeEntrante.Replace("alumno ", "");
                var alumno = OperacionesDb.obtenerAlumnoId(correlativo);

                if (String.IsNullOrEmpty(alumno.Nombre)){
                    respuesta =emojis.mdEmoji.sorprendido +  "Lo siento, no existe este alumno \n";
                } else
                {
                    respuesta = emojis.mdEmoji.saludo + alumno.Nombre;
                }

                
            }

            if (mensajeEntrante.StartsWith("consultar promedio"))
            {
                respuesta = emojis.mdEmoji.saludo + "Escriba promedio seguido de correlativo, ejemplo: promedio 1";

            }

            if (mensajeEntrante.StartsWith("promedio"))
            {
                var correlativo = mensajeEntrante.Replace("promedio ", "");
                var alumno = OperacionesDb.obtenerAlumnoId(correlativo);

                if (String.IsNullOrEmpty(alumno.Nombre))
                {
                    respuesta = emojis.mdEmoji.sorprendido + "Lo siento, no existe este alumno";
                }
                else
                {
                    var promedio = ((alumno.Parcial1 + alumno.Parcial2 + alumno.Parcial3 + alumno.Parcial4) / 4);
                    respuesta = emojis.mdEmoji.saludo + " El promedio del alumno " + alumno.Nombre + " es: " + promedio;
                }


            }

            if (mensajeEntrante.Contains("consultar seccion"))
            {
                respuesta = emojis.mdEmoji.saludo + "Escriba sección seguido de correlativo, ejemplo: seccion 1";

            }

            if (mensajeEntrante.StartsWith("seccion"))
            {
                var correlativo = mensajeEntrante.Replace("seccion ", "");
                var alumno = OperacionesDb.obtenerAlumnoId(correlativo);

                if (String.IsNullOrEmpty(alumno.Nombre))
                {
                    respuesta = emojis.mdEmoji.sorprendido + "Lo siento, no existe este alumno";
                }
                else
                {
                  
                    respuesta = emojis.mdEmoji.saludo + " La seccion del alumno " + alumno.Nombre + " es: " + alumno.Seccion;
                }

            }
            if (mensajeEntrante.Contains("consultar parcial1"))
            {
                respuesta = emojis.mdEmoji.saludo + "Escriba parcial1 seguido de correlativo, ejemplo: Parcial1 1";

            }

            if (mensajeEntrante.StartsWith("parcial1"))
            {
                var correlativo = mensajeEntrante.Replace("parcial1 ", "");
                var alumno = OperacionesDb.obtenerAlumnoId(correlativo);

                if (String.IsNullOrEmpty(alumno.Nombre))
                {
                    respuesta = emojis.mdEmoji.sorprendido + "Lo siento, no existe este alumno";
                }
                else
                {

                    respuesta = emojis.mdEmoji.saludo + " La nota del Parcial1 de " + alumno.Nombre + " es de: " + alumno.Parcial1;
                }
            }
            if (mensajeEntrante.Contains("consultar parcial2"))
            {
                respuesta = emojis.mdEmoji.saludo + "Escriba parcial2 seguido de correlativo, ejemplo: Parcial2 1";

            }

            if (mensajeEntrante.StartsWith("parcial2"))
            {
                var correlativo = mensajeEntrante.Replace("parcial2 ", "");
                var alumno = OperacionesDb.obtenerAlumnoId(correlativo);

                if (String.IsNullOrEmpty(alumno.Nombre))
                {
                    respuesta = emojis.mdEmoji.sorprendido + "Lo siento, no existe este alumno";
                }
                else
                {

                    respuesta = emojis.mdEmoji.saludo + " La nota del Parcial2 de " + alumno.Nombre + " es de: " + alumno.Parcial2;
                }

            }
            if (mensajeEntrante.Contains("consultar parcial3"))
            {
                respuesta = emojis.mdEmoji.saludo + "Escriba parcial3 seguido de correlativo, ejemplo: Parcial3 1";

            }

            if (mensajeEntrante.StartsWith("parcial3"))
            {
                var correlativo = mensajeEntrante.Replace("parcial3 ", "");
                var alumno = OperacionesDb.obtenerAlumnoId(correlativo);

                if (String.IsNullOrEmpty(alumno.Nombre))
                {
                    respuesta = emojis.mdEmoji.sorprendido + "Lo siento, no existe este alumno";
                }
                else
                {

                    respuesta = emojis.mdEmoji.saludo + " La nota del Parcial3 de " + alumno.Nombre + " es de: " + alumno.Parcial3;
                }

            }
            if (mensajeEntrante.Contains("consultar parcial4"))
            {
                respuesta = emojis.mdEmoji.saludo + "Escriba parcial4 seguido de correlativo, ejemplo: Parcial4 1";

            }

            if (mensajeEntrante.StartsWith("parcial4"))
            {
                var correlativo = mensajeEntrante.Replace("parcial4 ", "");
                var alumno = OperacionesDb.obtenerAlumnoId(correlativo);

                if (String.IsNullOrEmpty(alumno.Nombre))
                {
                    respuesta = emojis.mdEmoji.sorprendido + "Lo siento, no existe este alumno";
                }
                else
                {

                    respuesta = emojis.mdEmoji.saludo + " La nota del Parcial4 de " + alumno.Nombre + " es de: " + alumno.Parcial4;
                }

            }
            if (mensajeEntrante.Contains("consultar datos"))
            {
                respuesta = emojis.mdEmoji.saludo + "Escriba datos seguido de correlativo, ejemplo: datos 1";

            }

            if (mensajeEntrante.StartsWith("datos"))
            {
                var correlativo = mensajeEntrante.Replace("datos ", "");
                var alumno = OperacionesDb.obtenerAlumnoId(correlativo);

                if (String.IsNullOrEmpty(alumno.Nombre))
                {
                    respuesta = emojis.mdEmoji.sorprendido + "Lo siento, no existe este alumno";
                }
                else
                {
                    var promedio = ((alumno.Parcial1 + alumno.Parcial2 + alumno.Parcial3 + alumno.Parcial4) / 4);
                    respuesta = emojis.mdEmoji.saludo + " La informacion general de " + alumno.Nombre + " es: \n" +
                        "Parcial1: "+alumno.Parcial1 + "\nParcial2: "+alumno.Parcial2 + "" +
                        "\nParcial3: " + alumno.Parcial3 + "\nParcial4: " + alumno.Parcial4 + "\nPromedio: " +
                        "" + promedio + "\nSeccion: " + alumno.Seccion;
                }

            }


            if (!String.IsNullOrEmpty(respuesta))//    
            {
                await Bot.SendTextMessageAsync(
                    chatId: ObjetoMensajeTelegram.Message.Chat,
                    parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown,
                    text: respuesta

            );
            }

        } // fin del metodo de recepcion de mensajes



        private static void BotOnReceiveError(object sender, ReceiveErrorEventArgs receiveErrorEventArgs)
        {
            Console.WriteLine("UPS!!! Recibo un error!!!: {0} — {1}",
                receiveErrorEventArgs.ApiRequestException.ErrorCode,
                receiveErrorEventArgs.ApiRequestException.Message
            );
        }

    }//fin clase
}
