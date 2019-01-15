using System;

namespace e3
{
    class Program
    {
        static void Main(string[] args)
        {
                    
            int dia;
            Console.WriteLine("Enter a number: ");
            dia = Convert.ToInt32(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Ingrese el numero correspondiente al dia");
                    break;
            }
        }
    }
}
