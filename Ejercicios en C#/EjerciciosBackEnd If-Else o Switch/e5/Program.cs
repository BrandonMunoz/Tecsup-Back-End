using System;

namespace e5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Ingresar primer numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            int n2;
            Console.WriteLine("Ingresar segundo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            int n3;
            Console.WriteLine("Ingresar tercer numero: ");
            n3 = Convert.ToInt32(Console.ReadLine());
            int mayor=0;
            int medio=0;
            int menor=0;

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


            if (n3 >= mayor)
            {
                medio = mayor;
                mayor = n3;
            }
            else if (n3 <= menor)
            {
                medio = menor;
                menor = n3;
            }
            else
            {
                medio = n3;
            }
            Console.Write( $"{mayor}  { medio}  {menor}" );
            Console.ReadLine();
        }
    }
}
