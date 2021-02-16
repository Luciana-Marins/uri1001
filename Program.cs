using System;

namespace uri1001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro:");
            int A = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero inteiro:");
            int B = Int32.Parse(Console.ReadLine());
            int X = (A+B);
            Console.WriteLine("A soma de " +A+" + " +B+ " é igual a: "+X);
        }
    }
}
