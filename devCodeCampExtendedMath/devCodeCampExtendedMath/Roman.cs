using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devCodeCampExtendedMath
{
    public class Roman
    {
        public static void goingRoman(ref int number)
        {
            StringBuilder result = new StringBuilder();
            int[] digits = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            string[] romanDigits = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
            while (number > 0)
            {
                for (int toRoman = digits.Count() - 1; toRoman >= 0; toRoman--)
                    if (number / digits[toRoman] >= 1)
                    {
                        number -= digits[toRoman];
                        result.Append(romanDigits[toRoman]);
                        break;
                    }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
