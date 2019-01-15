using System;

namespace logica9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el valor de la presion");
            double presion = 0;
            presion = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor del volumen");
            double volumen = 0;
            volumen = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor de la temperatura");
            double temperatura = 0;
            temperatura = double.Parse(Console.ReadLine());
            double masa = (presion * volumen) / (0.37 * (temperatura + 460));
            Console.WriteLine("la masa total es= " + masa);
            Console.ReadLine();

        }
    }
}
