using System;

namespace S3D13
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;
            for(int i =1; i < 5; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }

        public static int factorial (int nro)
        {
            if (nro == 1)
                return 1;
            return nro * factorial(nro - 1);
        }
    }
}
