using System;

namespace bucle18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("ingrese primer numero");
            n1 = Int32.Parse(Console.ReadLine());
            int i1 = 0;
            int n2;
            Console.WriteLine("ingrese segundo numero");
            n2 = Int32.Parse(Console.ReadLine());
            int i2 = 0;
            int e = 13;

            while (i1 < e)
            {
                Console.WriteLine(n1 + " * " + i1 " = " + (n1 * i1));
                i1++;
            }
            Console.ReadKey();
        }
    }
}
