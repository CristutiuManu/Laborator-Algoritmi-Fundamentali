using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LeftRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int lungime = int.Parse(Console.ReadLine());
            int[] v = new int[lungime];
            for (int i = 0; i < lungime; i++)
            {
                v[i] = i + 1;
            }
            Console.Write("Numarul de rotatii :");
            int rotatii = int.Parse(Console.ReadLine());

            afisare(v);

            int[] vector = rotate(v, rotatii);
            Console.WriteLine("vectorul dupa rotatii");
            afisare(vector);
        }
        static void afisare(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"{v[i]} ");
            }
        }
        static int[] rotate(int[] v, int rotatii)
        {
            if (rotatii >= v.Length)
            {
                rotatii %= v.Length;
            }

            if (rotatii == 0)
            { return v; }
            int[] aux = new int[v.Length];
            int j = 0;
            for (int i = rotatii; i < v.Length; i++)
            {
                aux[j] = v[i];
                j++;
            }
            for (int i = 0; i < rotatii; i++)
            {
                aux[j] = v[i];
                j++;
            }
            return aux;
        }
    }
}
