using System;

namespace e7
{
    class Program
    {
        static void Main(string[] args)
        {
            string letra;
            Console.WriteLine("Ingrese una letra");
            letra = Console.ReadLine().ToUpper();
            string respuesta = " ";
            if (letra =="A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")
            {
                respuesta = "si es vocal";
            }
            else
            {
                respuesta = "no es una vocal";
            }

            Console.WriteLine(respuesta);
            Console.ReadKey();

        }
    }
}
