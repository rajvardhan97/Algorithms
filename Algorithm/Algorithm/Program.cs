using System;
namespace AlgorithmProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nPress 1.to Calculate Permutation using Recursion &Iterative Method of a string" +
                "\n2.Insertion Sort \n3. Bubble Sort");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter a string to calculate Permutation");
                    string str = Console.ReadLine();
                    int n = str.Length;
                    Console.WriteLine("Permutation through Recursion Method");
                    Algorithm.RecursivePermutation(str, 0, n - 1);
                    Console.WriteLine("\nPermutation through Iteration Method");
                    string str1 = Console.ReadLine();
                    int n1 = str1.Length;
                    Algorithm.IterativePermutation(str1, n1);
                    break;
                case 2:
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
                case 3:
                    List<int> arr1 = BubbleSort.ArrayInput();
                    BubbleSort.BubbleSorting(arr1);
                    break;
                case 4:
                    AnagramCheck.Anagram();
                    break;
                case 5:
                    PrimeNumbersInRange.PrimeNumbers();
                    break;
            }
        }
    }
}
