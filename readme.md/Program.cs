using System;

namespace readme.md
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, produto;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());


            produto = A * B;

            Console.WriteLine("PROD = " + produto);

            var teste = Math.PI;
            Console.WriteLine(teste);

        }
    }
}
