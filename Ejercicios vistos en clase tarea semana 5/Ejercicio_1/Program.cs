using System;
using System.Threading;

namespace Ejercicio_1
{
    class Program
    {
        public static string Mid(string parametro, int startindex, int Length)
        {
            string result = parametro.Substring(startindex, Length);
            return result;
        }

        static void Main(string[] args)
        {
            string nombre;
            string letra;
            int numerodecaracteres = 0;
            int eliminarletra = 0;
            int dimension = 0;
            int espacio = 0;
            Console.Write("Ingrese un nombre: ");
            nombre = Console.ReadLine();
            Console.SetCursorPosition(1, 7);
            Console.Write(nombre);
            dimension = nombre.Length;
            espacio = 65;
            nombre = nombre.ToUpper();
            for (eliminarletra = nombre.Length; eliminarletra >= 1; eliminarletra--)
            {
                letra = Mid(nombre, eliminarletra - 1, 1);
                for (numerodecaracteres = dimension; numerodecaracteres <= espacio; numerodecaracteres++)
                {
                    Console.SetCursorPosition(numerodecaracteres, 7);
                    Console.Write(" " + letra);
                    Thread.Sleep(40);
                }
                espacio = espacio - 3;
                dimension = dimension - 1;
            }
        }

    }
}

