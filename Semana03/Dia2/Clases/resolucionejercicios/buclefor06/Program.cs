using System;

namespace buclefor06
{
    class Program
    {
        static void Main(string[] args)
        {
            float MAXnota = float.MaxValue, MINnota = 0, acumnotas = 0;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"Ingrese nota alumno {i}");
                float nota = float.Parse(Console.ReadLine());
                acumnotas = acumnotas + nota;
                if (nota > MAXnota)
                    MAXnota = nota;
                if (nota < MINnota)
                {
                    MINnota = nota;
                } 
            }
            Console.WriteLine($"la nota media es {acumnotas/10}");
            Console.WriteLine($"la nota mayor es {MAXnota}");
            Console.WriteLine($"la nota baja es {MINnota}");
            Console.ReadKey();
        }
    }
}
