using System;

namespace Factorial_de_un_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int d = 1;
            Console.Write("Ingrese un numero: ");
            a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("El factorial es: " + d);
            }
            else
            {
                c = a;
                for (b = a; b > 1; b--)
                {
                    c = (c * (b - 1));
                }
                Console.WriteLine("El fatorial de " + a + " es: " + c);
            }
            Console.ReadKey();
        }
    }
}
