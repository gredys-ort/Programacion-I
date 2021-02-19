using System;

namespace _1._Letra_mayuscula
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            Console.WriteLine("Ingrese una Letra: ");
            letra = char.Parse(Console.ReadLine());

            if (letra == 'A' || letra == 'B' || letra == 'C' || letra == 'D' || letra == 'E' || letra == 'F' || letra == 'G' || letra == 'H' || letra == 'I' || letra == 'J' || letra == 'K' || letra == 'L' || letra == 'M' || letra == 'N' || letra == 'O' || letra == 'P' || letra == 'Q' || letra == 'R' || letra == 'S' || letra == 'T' || letra == 'U' || letra == 'V' || letra == 'W' || letra == 'X' || letra == 'Y' || letra == 'Z')
            {
                Console.WriteLine(letra + " es una letra Mayuscula");
            }
            else
            {
                Console.WriteLine(letra + " es una letra Minuscula");
            }
            Console.ReadKey();
        }
    }
}
