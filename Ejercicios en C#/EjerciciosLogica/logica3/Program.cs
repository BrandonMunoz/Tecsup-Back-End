using System;

namespace logica3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el valor de la compra");
            double compra = 0;
            compra = double.Parse(Console.ReadLine());
            double descuento = compra - (compra * 0.15);
            Console.WriteLine("su precio con descuento es: " + descuento);
            Console.ReadKey();
            
        }
    }
}
