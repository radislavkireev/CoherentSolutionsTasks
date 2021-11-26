using System;
using System.Linq;
using System.Text;

namespace ISBNTask
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Input 9 digit number: ");
            
            string number = Console.ReadLine();
            StringBuilder strNumber = new StringBuilder();
            int sum = 0;
            int count = 10;

            for (int i = 0; i < number.Length; i++)
            {
                strNumber.Append(number[i]);
            }

            int[] numberElements = new int[number.Length];

            for (int i = 0; i < numberElements.Length; i++)
            {
                numberElements[i] = int.Parse(number[i].ToString());
            }

            foreach (var item in numberElements)
            {
                sum += item * count;
                count--;
            }

            int remainder = sum % 11;
            int checkDigit = 11 - remainder;

            if (checkDigit != 10)
            {
                strNumber.Append(checkDigit.ToString());
                Console.Write("IBSN: ");
                foreach (var item in strNumber.ToString())
                {
                    Console.Write(item);
                }
            }
            else
            {
                strNumber.Append("X");
                Console.Write("IBSN: ");
                foreach (var item in strNumber.ToString())
                {
                    Console.Write(item);
                }
            }

            Console.WriteLine();
        }
    }
}
