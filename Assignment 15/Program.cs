using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_15
{
    internal class Program
    {
        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            int noswap = 0;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;

                        noswap++;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }

        static bool IsSorted(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                    return false;
            }
            return true;
        }

        public static int BinarySearch(int[] arr, int sItem)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == sItem)
                {
                    return mid;
                }
                else if (arr[mid] > sItem)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }

            }
            return -1;
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
        public static void Main(string[] args)
        {
            string c="";
            int[] arr = new int[5];
            Console.WriteLine("Enter the elements to be Stored in the array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array Before Bubble Sort and Binary Search");
            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();


            do
            {
                Console.WriteLine("Functions to be done on a array");
                Console.WriteLine("1.Bubble Sort");
                Console.WriteLine("2.Binary Search");
                Console.WriteLine("Enter your choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Print Array Without Sort");
                            Print(arr);
                            BubbleSort(arr);
                            Console.WriteLine("After Bubble Sort");
                            Print(arr);
                            break;
                        }
                    case 2:
                        {

                            Console.WriteLine("Enter Item to be Searched");
                            int sItem = int.Parse(Console.ReadLine());
                            IsSorted(arr);
                            int result = BinarySearch(arr, sItem);
                            if (result != -1)
                            {
                                Console.WriteLine($"{sItem} Found at Index {result}");
                            }
                            else
                            {
                                Console.WriteLine($"No such item {sItem} found");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice");
                            break;
                        }
                }
                Console.WriteLine("Choose y to continue n to exit");
                c = Console.ReadLine();

            } while (c == "y");
            
            
        }
    }
}