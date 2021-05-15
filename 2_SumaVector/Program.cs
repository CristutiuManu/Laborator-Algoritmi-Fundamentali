using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_SumaVector
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] v = { 1, 2, 3, 4, 5 };
            Console.Write("Suma elementelor vectorului: ");

            Console.WriteLine(suma(v));

            Console.WriteLine(recursiveSum(v, 0));
        }
        static int suma(int[] v)
        {
            int sum = 0;

            for (int i = 0; i < v.Length; i++)
            {
                sum += v[i];
            }
            return sum;
        }
        static int recursiveSum(int[] v, int index)
        {
            if (index == v.Length)
            {
                return 0;
            }
            return v[index] + recursiveSum(v, index + 1);
        }
    }
}
}
