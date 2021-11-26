using System;
using System.Collections.Generic;

namespace RangeTernary2s
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter int a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("enter int b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Converter converter = new Converter();
            List<string> rangeTernaryItems = new List<string>();

            if (a > b)
            {
                int c = a + b;
                a = c - a;
                b = c - b;
            }

            for (; a <= b; a++)
            {
                char[] ternaryItem = converter.DecimalToTernary(a).ToCharArray();
                int count = 0;
                for (int j = 0; j < ternaryItem.Length; j++)
                {
                    if (ternaryItem[j] == '2')
                    {
                        count++;
                    }
                }

                if (count == 2)
                {
                    rangeTernaryItems.Add(converter.DecimalToTernary(a));
                }

            }

            for (int i = 0; i < rangeTernaryItems.Count; i++)
            {
                Console.WriteLine(rangeTernaryItems[i]);
            }
        }
    }
}
