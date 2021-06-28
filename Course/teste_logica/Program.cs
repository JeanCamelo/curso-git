using System;

namespace teste_logica
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, average;
            Console.WriteLine("Digite o primeiro numero");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            y = int.Parse(Console.ReadLine());
            average = (x + y) / 2.0;
            Console.WriteLine("Result = " + average);


        }
    }
}
