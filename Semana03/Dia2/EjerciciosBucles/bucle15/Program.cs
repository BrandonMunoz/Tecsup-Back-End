using System;

namespace bucle15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int i = 0;
            int a = 0;
            while (i < 100)
            {
                i++;
                a = a + i;
                
            }
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
