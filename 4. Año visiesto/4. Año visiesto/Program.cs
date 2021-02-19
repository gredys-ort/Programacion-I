using System;

namespace _4._Año_visiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Escriba un año: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if ((a % 100 == 0 && a % 400 != 0) || a % 4 != 0)
            {
                Console.WriteLine("No es un año bisiesto");
            }
            else
            {
                Console.WriteLine("Es un año bisiesto");
            }
            Console.ReadKey();

        }
    }
}
