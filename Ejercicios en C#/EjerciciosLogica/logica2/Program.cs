using System;

namespace logica2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su salario");
            double salario = 0;
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese su primera venta");
            double venta1 = 0;
            venta1 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese su segunda venta");
            double venta2 = 0;
            venta2 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese su tercera venta");
            double venta3 = 0;
            venta3 = double.Parse(Console.ReadLine());
            Console.WriteLine("su sueldo al mes es:");
            double sueldoMensual = 0;
            sueldoMensual = salario + ((venta1 * 0.1) + (venta2 * 0.1) + (venta3 * 0.1));
            Console.WriteLine(sueldoMensual);
            Console.ReadKey();
            
        }
    }
}
