using System;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Converter();
            Console.WriteLine(result.CamelCase("a b c d-e-f%g"));
            Console.ReadLine();
        }
    }
}
