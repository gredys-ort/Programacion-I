using System;

namespace _4._Dias_de_la_semana
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string lin;
            Console.WriteLine("Dias De La Semana");
            Console.WriteLine();
            Console.Write("Ingrese un número del 1 al 7 : ");
            lin = Console.ReadLine();
            numero = int.Parse(lin);
            switch(numero)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("El número que ingreso corresponde al día Domingo");
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("El número que ingreso corresponde al día Lunes");
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("El número que ingreso corresponde al día Martes");
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("El número que ingreso corresponde al día Miercoles");
                    break;
                case 5:
                    Console.WriteLine();
                    Console.WriteLine("El número que ingreso corresponde al día Jueves");
                    break;
                case 6:
                    Console.WriteLine();
                    Console.WriteLine("El número que ingreso corresponde al día Viernes");
                    break;
                case 7:
                    Console.WriteLine();
                    Console.WriteLine("El número que ingreso corresponde al día Sábado");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("El número que ingreso está fuera de rango");
                    break;
            }
            Console.ReadKey();
        }
    }
}
