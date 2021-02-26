using System;

namespace _5._Edad_de_un_grupo
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a;
            byte b;
            byte c = 0;
            byte d = 0;
            byte i;
            Console.Write("Ingrese la cantidad de edades: ");
            b = byte.Parse(Console.ReadLine());
            for (i = 0; i < b; i++)
            {
                Console.Write("Ingrese una Edad: ");
                a = byte.Parse(Console.ReadLine());
                if (i == 0)
                {
                    d = a;
                    c = a;
                }
                else if (i != 0)
                {
                    if (a < c)
                    {
                        c = a;
                    }
                    if (a > d)
                    {
                        d = a;
                    }
                }
            }
            Console.WriteLine("Numero Menor es: " + c);
            Console.WriteLine("Numero Mayor es: " + d);
            Console.ReadKey();
        }
    }
}
