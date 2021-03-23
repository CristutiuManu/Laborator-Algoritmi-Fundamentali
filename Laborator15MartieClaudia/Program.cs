using System;
using System.Collections.Generic;

namespace Laborator15MartieClaudia
{
    class Program
    {

        // Problema 1: 
        /*
             BitStone -> biTstonE -> EnotsTib
                Cerinta:
                Se dau N nume, sa se afiseze toate numele transformate.

                Input:
                Pe prima linie se va afla un numar natural N, reprezentand numarul de nume.
                Pe fiecare din urmatoarele N linii se va gasi cate un nume care trebuie transformat.

                Output:
                Se vor afisa cele N nume transformate, fiecare pe cate o linie, in ordinea in care au fost citite in input.

                Restrictions:
                numele unei firme incepe cu litera mare
                suma lungimilor numelor <= 10.000
                Examples:
                Input:	
                3
                BitStone
                Output:
                BITStone
                ABcD
                EnotsTib
                EnotsTIB
                DCbA 
        */
        // Problema 1
        public static void Reverse(string name)
        {
            List<int> list = new List<int>();

            int count = 1;
            for (int i = 1; i < name.Length; i++)
            {
                if (char.IsUpper(name[i]))
                {
                    list.Add(count);
                    count = 1;
                }
                else count++;
            }
            list.Add(count);
            char[] v = name.ToCharArray();
            Array.Reverse(v);

            int k = 0;
            for (int i = list.Count - 1; i >= 0; i--)
            {
                v[k] = Char.ToUpper(v[k]);
                k++;
                for (int j = 1; j < list[i]; j++)
                {
                    v[k] = char.ToLower(v[k]);
                    k++;
                }
            }

            for (int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(Reverse("awalaaa"));
            Reverse("BitStone");
            Reverse("BITStone");
            Reverse("ABcD");
        }
    }
}
