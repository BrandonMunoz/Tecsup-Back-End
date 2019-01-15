using System;

namespace logica15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tiempo del lunes");
            double lunes = 0;
            lunes = double.Parse(Console.ReadLine());
            Console.WriteLine("tiempo del miercoles");
            double miercoles = 0;
            miercoles = double.Parse(Console.ReadLine());
            Console.WriteLine("tiempo del viernes");
            double viernes = 0;
            viernes = double.Parse(Console.ReadLine());
            double tp = (lunes + miercoles + viernes) / 3;
            Console.WriteLine("su tiempo promedio de la semana es: " + tp);
            Console.ReadKey();
        }
    }
}
