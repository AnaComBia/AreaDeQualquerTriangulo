using System;

namespace AreaDeQualquerTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nAgora iremos evoluir de nível de calcular a área de qualuer triângulo, para isso informe os dados abaixo\n");

            Console.Write("\nLado 1: ");
            double Lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nLado 2: ");
            double Lado2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nLado 3: ");
            double Lado3 = Convert.ToDouble(Console.ReadLine());

            double SemiPerimetro = (Lado1 + Lado2 + Lado3) / 2;
            double Area = Convert.ToDouble(Math.Sqrt(SemiPerimetro * (SemiPerimetro - Lado1) * (SemiPerimetro - Lado2) * (SemiPerimetro - Lado3)));


            Console.WriteLine($"\nSemiperímetro: {SemiPerimetro}");
            Console.WriteLine($"Área: {Area}\n");


        }
    }
}
