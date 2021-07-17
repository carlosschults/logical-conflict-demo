using System;

namespace logical_conflict_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type the number you want to generate the multiplication table for:");
            var response = int.Parse(Console.ReadLine());
            Console.WriteLine(Utils.GenerateMultiplicationTableFor(response));
        }
    }
}
