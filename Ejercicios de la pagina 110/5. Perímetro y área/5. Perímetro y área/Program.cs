using System;

namespace _5._Perímetro_y_área
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int h;
            int c;
            int e;
            Console.Write("Digite la base: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite la Altura: ");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Seleccione una Opcion");
            Console.WriteLine();
            Console.WriteLine("1). Perimetro ");
            Console.WriteLine("2). Area ");
            Console.Write("Seleccione una Opcion: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (c)
            {
                case 1:
                    e = (b * 2) + (h * 2);
                    Console.WriteLine("El perimetro de uun rectangulo es: " + e);
                    break;
                case 2:
                    a = b * h;
                    Console.WriteLine("El area de un rectangulo es: " + a);
                    break;
                default:
                    Console.WriteLine("Numero no valido: ");
                    break;
            }
            Console.ReadKey();
        }
    }
}
