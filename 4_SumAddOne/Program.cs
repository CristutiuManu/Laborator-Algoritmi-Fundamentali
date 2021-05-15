using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAddOne
{
    class Program
    {
        static void Read(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = int.Parse(Console.ReadLine());
        }

        static void View(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        static void AddOne(ref int[] arr)
        {
            int n = arr.Length;
            arr[n - 1] = arr[n - 1] + 1;
            if (arr[n - 1] == 10)
            {
                arr[n - 1] = 0;
                for (int i = n - 2; i >= 0; i--)
                {
                    arr[i] = arr[i] + 1;
                    if (arr[i] == 10)
                        arr[i] = 0;
                    else
                        break;
                }
            }
            if (arr[0] == 0)
            {
                arr = new int[n + 1];
                arr[0] = 1;
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Read(arr);
            View(arr);
            AddOne(ref arr);
            View(arr);
        }
    }
}
