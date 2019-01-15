using System;

namespace e10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Escriba el primer numero");
            n1 = Convert.ToInt32(Console.ReadLine());
            int n2;
            Console.WriteLine("Escriba el segundo numero");
            n2 = Convert.ToInt32(Console.ReadLine());
            string operacion;
            Console.WriteLine("elija el tipo de operacion: s,r,m,d,p");
            operacion = Console.ReadLine().ToUpper();
            int respuesta=0;
            

            if (operacion = "S")
            {
                respuesta = n1 + n2;
            }
            if (operacion = "R")
            {
                respuesta = n1 - n2;
            }
            if (operacion = "M")
            {
                respuesta = n1 * n2;
            }
            if (operacion = "D")
            {
                respuesta = n1 / n2;
            }
            if (operacion = "P")
            {
                respuesta = n1 ^ n2;
            }



            Console.ReadKey();

        }
    }
}
