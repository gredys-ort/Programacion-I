using System;

namespace Ejercicio_3
{
    class Program
    {
        public static string generaletra(int min, int max)

        {
            Random ran = new Random();
            int rango = Convert.ToInt32(ran.Next(0, 127));
            string letrarespuesta = "";
            if (((rango > min) & (rango < max)))
            {
                letrarespuesta = Convert.ToString((char)rango);
            }
            return letrarespuesta;
        }

        static void Main(string[] args)
        {
            byte numeros, caracteres;
            string cantidad;
            Console.Write("Cuantos numeros: ");
            cantidad = Console.ReadLine();
            numeros = byte.Parse(cantidad);

            string letra = "";
            for (caracteres = 1; caracteres <= numeros; caracteres++)
            {
                letra = letra + generaletra(0, 127);
            }

            Console.WriteLine($"Tocken es : {letra}");

        }
    }
}
