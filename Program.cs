using System;
using System.Linq;

namespace CSharpTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 92, 4, 23, 12, 128 };
            string[] characters = { "I love", "coding" };


            // Aggregate functions
            Console.WriteLine("The no of elements is: {0}", numbers.Count());
            Console.WriteLine("The minimum number is: {0}", numbers.Min());
            Console.WriteLine("The maximum number is: {0}", numbers.Max());
            Console.WriteLine("The sum is: {0}", numbers.Sum());
            Console.WriteLine("The sum is: {0}", numbers.Aggregate((x, y) => x + y));
            Console.WriteLine("The product is: {0}", numbers.Aggregate((x, y) => x * y));
            Console.WriteLine("The string is: {0}", characters.Aggregate((x, y) => x + " " + y));


            // Sorting operations
            Console.Write("In ascending order: ");
            foreach (int num in numbers.OrderBy(x => x))
                Console.Write(num + " ");

            Console.Write("\nIn descending order: ");
            foreach (int num in numbers.OrderByDescending(x => x))
                Console.Write(num + " ");

            Console.Write("\nIn reverse order: ");
            foreach (int num in numbers.Reverse())
                Console.Write(num + " ");


            // Partition operations
            Console.Write("\nThe first 2 elements are: ");
            foreach (int num in numbers.Take(2))
                Console.Write(num + " ");

            Console.Write("\nThe elements greater than 50 are: ");
            foreach (int num in numbers.TakeWhile(x => x < 10))
                Console.Write(num + " ");

            Console.Write("\nThe elements except the first two: ");
            foreach (int num in numbers.Skip(2))
                Console.Write(num + " ");

            //Console.Write("\nThe elements greater than 50 are: ");
            //foreach (int num in numbers.SkipWhile(x => x > 50))
            //    Console.Write(num + " ");



            Console.ReadLine();
        }
    }
}
