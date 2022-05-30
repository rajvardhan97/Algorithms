using System;
namespace AlgorithmProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nPress 1 . Insertion Sort");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the Array size");
                    int number = Convert.ToInt32(Console.ReadLine());
                    List<int> array = new List<int>();
                    while (number-- > 0)
                    {
                        Console.WriteLine("Enter a number:");
                        array.Add(Convert.ToInt32(Console.ReadLine()));
                    }
                    Sorting.InsertionSorting(array);
                    break;
            }
        }
    }
}
