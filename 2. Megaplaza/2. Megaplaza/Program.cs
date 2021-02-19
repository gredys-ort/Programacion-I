using System;

namespace _2._Megaplaza
{
    class Program
    {
        static void Main(string[] args)
        {
            double desc, prep, pren;
            Console.Write("Ingrese el precio: ");
            pren = double.Parse(Console.ReadLine());
            desc = pren > 300 ? pren * 0.2 : 0;
            prep = pren - desc;
            Console.WriteLine("El descuento es de: " + desc);
            Console.WriteLine("El total a pagar es de: " + prep);
            Console.WriteLine();
            Console.Write("Gracias por su compra, Megaplaza le desea un buen dia.");
            Console.ReadKey();
        }
    }
}
