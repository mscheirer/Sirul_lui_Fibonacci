using System;

namespace Lab8_Fibonacci_GitHub
{
    public class Fibonacci
    {
        public static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, numar;
            Console.Write("Introduceti numarul de elemente din sirul lui Fibonacci: ");
            numar = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");   
            for (i = 2; i < numar; i++)   
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
            Console.WriteLine(".");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Apasa o tasta pentru iesire...");
        }
    }
}