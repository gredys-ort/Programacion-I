using System;

namespace _3._Impuesto_de_un_producto
{
    class Program
    {
        static void Main(string[] args)
        {
            byte opcion;
            decimal iva = 12;
            decimal a;
            decimal pago;
            Console.WriteLine("Que producto va a pagar");
            Console.WriteLine("1). Medicina");
            Console.WriteLine("2). Otro");
            Console.Write("Seleccione una opcion: ");
            opcion = byte.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Write("Escriba su total a pagar: ");
                    a = decimal.Parse(Console.ReadLine());
                    pago = a;
                    Console.Write("Su total de pago es " + pago); break;
                case 2:
                    Console.Write("Escriba su total a pagar: ");
                    a = decimal.Parse(Console.ReadLine());
                    iva = ((a * 12) / 100);
                    pago = iva + a;
                    Console.Write("Su total de pago es " + pago); break;
                default: Console.Write("Numero no valido"); break;
            }
            Console.ReadKey();
        }
    }
}
