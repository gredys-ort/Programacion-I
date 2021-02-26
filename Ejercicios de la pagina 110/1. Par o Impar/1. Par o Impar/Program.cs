using System;

namespace _1._Par_o_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.Write("Escriba un número: ");
            numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("El número es Par. ");
            }
            else
            {
                Console.WriteLine("El número es Impar. ");
            }
            Console.ReadKey();
        }
    }
}
