using System;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Converter();
            Console.WriteLine(result.CamelCase("This*is%a-TEST    "));
            Console.ReadLine();
        }
    }
}
