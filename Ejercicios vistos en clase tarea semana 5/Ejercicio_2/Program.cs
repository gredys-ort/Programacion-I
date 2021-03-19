using System;
using System.Threading;

namespace Ejercicio_2
{
    class Program
    {
        public static void dibuja(int Cantidad)
        {
            int espacios = 20;
            int dimension = 80;
            int enter = 2;
            int haciaarriba = 2;
            int fila, columna, lineas;

            for (lineas = 1; lineas <= Cantidad; lineas++)
            {
                for (fila = haciaarriba; fila <= dimension; fila++)
                {
                    Console.SetCursorPosition(fila, espacios); Console.Write("0");
                    Console.SetCursorPosition(fila, enter); Console.Write("0");
                }
                for (columna = haciaarriba; columna <= espacios; columna++)
                {
                    Console.SetCursorPosition(haciaarriba, columna); Console.Write("/");
                    Console.SetCursorPosition(dimension, columna); Console.Write("/");
                }
                enter = enter + 1;
                espacios = espacios - 1;
                haciaarriba = haciaarriba + 1;
                dimension = dimension - 1;
            }
        }
        static void Main(string[] args)
        {
            for (int tamanio = 1; tamanio < 9; tamanio++)
            {
                dibuja(tamanio);
                Thread.Sleep(700);
            }

        }

    }
}

