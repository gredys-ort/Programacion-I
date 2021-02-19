using System;

namespace _5._Dia_laboral
{
    class Program
    {
        static void Main(string[] args)
        {
            String dia;
            int numero;
            Console.Write("Escriba un numero del 1 al 7: ");
            dia = Console.ReadLine();
            numero = int.Parse(dia);
            Console.WriteLine();
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Es un dia laboral");
                    break;
                case 2:
                    Console.WriteLine("Es un dia laboral");
                    break;
                case 3:
                    Console.WriteLine("Es un dia laboral");
                    break;
                case 4:
                    Console.WriteLine("Es un dia laboral");
                    break;
                case 5:
                    Console.WriteLine("Es un dia laboral");
                    break;
                case 6:
                    Console.WriteLine("No es un dia laboral");
                    break;
                case 7:
                    Console.WriteLine("No es un dia laboral");
                    break;
                default:
                    Console.WriteLine("Numero no valido");
                    break;

            }
        }
    }
}
