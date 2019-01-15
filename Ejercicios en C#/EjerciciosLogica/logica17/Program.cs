using System;

namespace logica17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculando promedio de matematicas");
            Console.WriteLine("ingresar nota de examen");
            double em = 0;
            em = double.Parse(Console.ReadLine());
            Console.WriteLine("ingresar nota de tarea 1");
            double tm1 = 0;
            tm1 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingresar nota de tarea 2");
            double tm2 = 0;
            tm2 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingresar nota de tarea 3");
            double tm3 = 0;
            tm3 = double.Parse(Console.ReadLine());
            double tm = (tm1 + tm2 + tm3) / 3;
            double promM = (em * 0.9) + (tm * 0.1);
            Console.WriteLine("su promedio es: " + promM);

            Console.WriteLine("calculando promedio de fisica");
            Console.WriteLine("ingresar nota de examen");
            double ef = 0;
            ef = double.Parse(Console.ReadLine());
            Console.WriteLine("ingresar nota de tarea 1");
            double tf1 = 0;
            tf1 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingresar nota de tarea 2");
            double tf2 = 0;
            tf2 = double.Parse(Console.ReadLine());
            double tf = (tf1 + tf2) / 2;
            double promF = (ef * 0.8) + (tf * 0.2);
            Console.WriteLine("su promedio es: " + promF);

            Console.WriteLine("calculando promedio de quimica");
            Console.WriteLine("ingresar nota de examen");
            double eq = 0;
            eq = double.Parse(Console.ReadLine());
            Console.WriteLine("ingresar nota de tarea 1");
            double tq1 = 0;
            tq1 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingresar nota de tarea 2");
            double tq2 = 0;
            tq2 = double.Parse(Console.ReadLine());
            Console.WriteLine("ingresar nota de tarea 3");
            double tq3 = 0;
            tq3 = double.Parse(Console.ReadLine());
            double tq = (tq1 + tq2 + tq3) / 3;
            double promQ = (eq * 0.9) + (tq * 0.1);
            Console.WriteLine("su promedio es: " + promQ);

            Console.ReadKey();
        }
    }
}
