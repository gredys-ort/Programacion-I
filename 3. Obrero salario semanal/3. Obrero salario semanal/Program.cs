using System;

namespace _3._Obrero_salario_semanal
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas;
            int pagonormal;
            int extras;
            int pagototal;
            int totalpago;
            int horanormal;

            Console.Write("Escriba horas trabajadas en el mes: ");
            horas = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (horas > 40)
            {
                extras = horas - 40;
                horanormal = 40 * 16;
                pagototal = extras * 20;
                totalpago = pagototal + horanormal;
                Console.WriteLine("Pago Mensual: " + totalpago);

            }
            else
            {
                pagonormal = horas * 16;
                Console.WriteLine("SU TOTAL DE PAGO ES DE:" + pagonormal);

            }
        }
    }
}
