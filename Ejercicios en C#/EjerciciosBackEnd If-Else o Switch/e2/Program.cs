using System;

namespace e2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n2;
            Console.WriteLine("Ingresar numero");
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n2%2==0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("Numero impar");
            }
            
        }
    }
}
