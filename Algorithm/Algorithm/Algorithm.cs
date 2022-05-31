using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblem
{
    internal class Algorithm
    {
        public static List<string> recursiveList = new List<string>();
        public static List<string> iterativeList = new List<string>();
        public static void RecursivePermutation(String str, int l, int r)
        {
            if (l == r)
            {
                Console.WriteLine(str);
                recursiveList.Add(str);
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    RecursivePermutation(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
        }
        public static String swap(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }

        public static void IterativePermutation(string str, int n)
        {
            char[] arr = str.ToCharArray();
            Array.Sort(arr);
            string s = String.Join("", arr);

            while (true)
            {
                Console.WriteLine(s);

                iterativeList.Add(s);
                int i = n - 1;
                while (s[i - 1] >= s[i])
                {
                    if (--i == 0)
                    {
                        return;
                    }
                }
                int j = n - 1;
                while (j > i && s[j] <= s[i - 1])
                {
                    j--;
                }
                s = swap(s, i - 1, j);
                s = reverse(s, i);

            }
        }
        public static string reverse(string str, int k)
        {
            char[] chars = str.ToCharArray();
            for (int i = k, j = str.Length - 1; i < j; i++, j--)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
            }
            return new string(chars);
        }
    }
    public class Sorting
    {
        public static void InsertionSorting(List<int> arrayList)
        {
            for (int i = 0; i < arrayList.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arrayList[j - 1] > arrayList[j])
                    {
                        Swap(arrayList, j - 1, j);
                    }
                }
            }
            Display(arrayList);
        }
        public static List<int> Swap(List<int> arrayList, int j, int i)
        {
            int temp = arrayList[j];
            arrayList[j] = arrayList[i];
            arrayList[i] = temp;
            return arrayList;
        }
        public static void Display(List<int> arrayList)
        {
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine("Sorted Array: {}", arrayList[i]);

            }
        }
    }

    class BubbleSort
    {
        public static List<int> ArrayInput()
        {
            Console.WriteLine("Enter the Array size");
            int number = Convert.ToInt32(Console.ReadLine());
            List<int> array = new List<int>();
            while (number-- > 0)
            {
                Console.WriteLine("Enter a number:");
                array.Add(Convert.ToInt32(Console.ReadLine()));
            }
            return array;
        }

        public static void BubbleSorting(List<int> arr)
        {
            for (int j = 0; j <= arr.Count - 2; j++)
            {
                for (int i = 0; i <= arr.Count - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Display(arr);
        }
        public static void Display(List<int> arrayList)
        {
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine("Element {0} of Array: {1}", i + 1, arrayList[i]);
            }
        }
    }
    class AnagramCheck
    {
        public static void Anagram()
        {
            Console.WriteLine("\nEnter String 1:");
            char[] string1 = Console.ReadLine().ToCharArray();
            Console.WriteLine("\nEnter String 2:");
            Char[] string2 = Console.ReadLine().ToCharArray();

            Array.Sort(string1);
            Array.Sort(string2);

            string firstString = String.Join("", string1);
            string secondString = String.Join("", string2);

            if (string1.Length == string2.Length)
            {
                int res = firstString.CompareTo(secondString);
                if (res == 0)
                {
                    Console.WriteLine("String1 is an Anagram of String2");
                }
            }
            else
            {
                Console.WriteLine("String1 is not Anagram of String2");
            }
        }
    }
    class PrimeNumbersInRange
    {
        public static void PrimeNumbers()
        {
            int num, i, counter;
            for (num = 0; num <= 1000; num++)
            {
                counter = 0;
                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.Write("\n");
        }
    }
}