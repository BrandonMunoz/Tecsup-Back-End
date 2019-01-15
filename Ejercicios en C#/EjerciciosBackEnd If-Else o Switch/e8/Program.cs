using System;

namespace e8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Ingrese el primer numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            int n2;
            Console.WriteLine("Ingrese el segundo numero");
            n2 = Convert.ToInt32(Console.ReadLine());
            int n3;
            Console.WriteLine("Ingrese el tercer numero");
            n3 = Convert.ToInt32(Console.ReadLine());
            int n4;
            Console.WriteLine("Ingrese el cuarto numero");
            n4 = Convert.ToInt32(Console.ReadLine());
            int n5;
            Console.WriteLine("Ingrese el quinto numero");
            n5 = Convert.ToInt32(Console.ReadLine());
            int n6;
            Console.WriteLine("Ingrese el sexto numero");
            n6 = Convert.ToInt32(Console.ReadLine());
            int n7;
            Console.WriteLine("Ingrese el septimo numero");
            n7 = Convert.ToInt32(Console.ReadLine());
            int n8;
            Console.WriteLine("Ingrese el octavo numero");
            n8 = Convert.ToInt32(Console.ReadLine());
            int n9;
            Console.WriteLine("Ingrese el noveno numero");
            n9 = Convert.ToInt32(Console.ReadLine());
            int n10;
            Console.WriteLine("Ingrese el decimo numero");
            n10 = Convert.ToInt32(Console.ReadLine());
            int menor = 0;
            int mayor = 0;

            if (n1>n2)
            {
                mayor = n1;
                menor = n2;
            }
            else
            {
                mayor = n2;
                menor = n1;
            }

            if (n3 > mayor)
            {
                mayor = n3;

            }else if (n3 < menor)
            {
                menor = n3;
            }

            if (n4 > mayor)
            {
                mayor = n4;

            }
            else if (n4 < menor)
            {
                menor = n4;
            }

            if (n5 > mayor)
            {
                mayor = n5;

            }
            else if (n5 < menor)
            {
                menor = n5;
            }

            if (n6 > mayor)
            {
                mayor = n6;

            }
            else if (n6 < menor)
            {
                menor = n6;
            }

            if (n7 > mayor)
            {
                mayor = n7;

            }
            else if (n7 < menor)
            {
                menor = n7;
            }

            if (n8 > mayor)
            {
                mayor = n8;

            }
            else if (n8 < menor)
            {
                menor = n8;
            }

            if (n9 > mayor)
            {
                mayor = n9;

            }
            else if (n9 < menor)
            {
                menor = n9;
            }

            if (n10 > mayor)
            {
                mayor = n10;

            }
            else if (n10 < menor)
            {
                menor = n10;
            }
            
            Console.Write("el mayor es: " + mayor + " el menor es: " + menor);
            Console.ReadKey();
        }
    }
}
