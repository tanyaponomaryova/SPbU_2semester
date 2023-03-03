using System;

namespace InsertionSort
{
    internal class Program
    {
        static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int index = i;
                while (index > 0 && temp < array[index - 1])
                {
                    array[index] = array[index - 1];
                    index--;
                }
                array[index] = temp;
            }
        }

        static bool Test()
        {
            Random random = new Random();
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(20);
            }
            InsertionSort(array);
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("This program sorts input array!");
            for (int i = 0; i < 10; i++)
            {
                if (!Test())
                {
                    Console.WriteLine("Test failed!");
                    return;
                }
            }

            Console.Write("Enter length of array: ");
            bool isConvertedToInt = int.TryParse(Console.ReadLine(), out int length);
            while (!isConvertedToInt || length <= 0)
            {
                Console.Write("Incorrect input! Try again: ");
                isConvertedToInt = int.TryParse(Console.ReadLine(), out length);
            }

            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Enter {i} element: ");
                isConvertedToInt = int.TryParse(Console.ReadLine(), out array[i]);
                while (!isConvertedToInt)
                {
                    Console.Write("Incorrect input! Try again: ");
                    isConvertedToInt = int.TryParse(Console.ReadLine(), out array[i]);
                }
            }

            Console.Write("Entered array: ");
            for (int i = 0; i < length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();

            InsertionSort(array);

            Console.Write("Sorted array: ");
            for (int i = 0; i < length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
    }
}