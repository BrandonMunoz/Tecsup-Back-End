using System;

namespace logica14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el precio pagado por el producto");
            double precio = 0;
            precio = double.Parse(Console.ReadLine());
            double ganancia = precio + (precio * 0.3);
            Console.WriteLine("la ganancia del 30% es: " + ganancia);
            Console.ReadKey();
        }
    }
}
