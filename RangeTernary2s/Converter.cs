﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RangeTernary2s
{
    class Converter
    {
        public string DecimalToTernary(int n)
        {
            StringBuilder str = new StringBuilder();
            StringBuilder strTernary = new StringBuilder();

            while (n != 0)
            {
                str.Append(n % 3);
                n /= 3;
            }

            char[] charArray = str.ToString().ToCharArray();
            Array.Reverse(charArray);

            for (int i = 0; i < charArray.Length; i++)
            {
                strTernary.Append(charArray[i]);
            }
           
            return strTernary.ToString();
        }
    }
}