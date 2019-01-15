using System;

namespace bucle13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int i = 0;
            while (i<=n)
            {
                Console.WriteLine(i*2);
                i++;
            }
            Console.ReadKey();
        }
    }
}
