using System;

namespace _6._Numero_Primo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int cont = 0;
            int i;
            Console.Write("Escriba un numero: ");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    cont = cont + 1;
                }
            }
            if (cont > 2)
            {
                Console.WriteLine("No es un numero primo");
            }
            else
            {
                Console.WriteLine("Es un numero Primo");
            }
            Console.ReadKey();

        }
    }
}
