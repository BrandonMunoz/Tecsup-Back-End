using System;

namespace e6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Enter a number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 >= 0)
            {
                Console.WriteLine("El numero es positivo");
            }
            else
            {
                Console.WriteLine("El numero es negativo");
            }
            
        }
    }
}
