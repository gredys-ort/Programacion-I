using System;

namespace _4._Numeros_primos
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant = 0;
            int num = 2;
            int i;
            Console.WriteLine("Numeros Primos entre uno y mil");
            while (num <= 1000)
            {
                for (i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        cant++;
                    }
                    if (cant > 2)
                    {
                        break;
                    }
                }
                if (cant == 2)
                {
                    Console.Write(num + " ");
                }


                cant = 0;
                num++;
            }
            Console.ReadKey();
        }
    }
}
