using System;

namespace Laborator22MartieClaudia
{
    class Program
    {
        // 22 Martie laborator cu Claudia 

        static void Afisare(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(0); j++)
                    Console.Write(m[i, j] + " ");
                Console.WriteLine();
            }
        }

        public static void RotireMatrice(int[,] m)
        {
            int n = m.GetLength(0);
            int i, j, aux;
            for (i = 0; i < n / 2; i++)
            {
                for (j = 0; j < n / 2; j++)
                {
                    aux = m[i, j];
                    m[i, j] = m[n - j - 1, i];
                    m[n - j - 1, i] = m[n - i - 1, n - j - 1];
                    m[n - i - 1, n - j - 1] = m[j, n - i - 1];
                    m[j, n - i - 1] = aux;
                }
            }

            Afisare(m);
        }


        static void Main(string[] args)
        {
            int[,] m = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12},
                {13, 14, 15, 16}
            };

            RotireMatrice(m);


        }
    }
}
