using System;

namespace Serie_de_un_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int total;
            int a;
            int b;
            int c;
            int i;
            Console.Write("Cuantos numeros va imprimir: ");
            total = int.Parse(Console.ReadLine());
            a = 1;
            b = 1;
            Console.Write(a + " " + b);
            for (i = 3; i <= total; i++)
            {
                c = a + b;
                Console.Write(" " + c + " ");
                a = b;
                b = c;
            }
            Console.ReadKey();
        }
    }
}
