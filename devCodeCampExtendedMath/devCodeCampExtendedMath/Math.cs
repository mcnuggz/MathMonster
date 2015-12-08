using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devCodeCampExtendedMath
{
    public class Math
    {
        
        public static int getGCD(int firstNumber, int secondNumber)
        {
            if (0 == secondNumber)
                return firstNumber;
            else
                return getGCD(secondNumber, firstNumber % secondNumber);
        }
        public static void polyhedral(ref int vertices, ref int edges, ref int faces)
        {

            int total = vertices + faces - edges;

            if (total != 2)
            {
                Console.WriteLine("Shape does not exist");
            }
            else
            {
                Console.WriteLine("True");
            }

        }
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
        //squares a number
        //splits the results into two integers
        //squares integers
        //repeats until number = 1
        public static bool findHappy(int number)
        {
            List<int> happyStash = new List<int>();
            int sum = 0;

            while (number != 1)
            {
                if (happyStash.Contains(number))
                {
                    return false;
                }
                happyStash.Add(number);
                while (number != 0)
                {
                    int digit = number % 10;
                    sum += digit * digit;
                    number /= 10;
                }
                number = sum;
                sum = 0;
            }
            return true;
        }
        public static void isHappy(int number)
        {
            int initialNum = 1;
            List<int>happyNumbahs = new List<int>();

            while (happyNumbahs.Count < number)
            {
                if (findHappy(initialNum))
                {
                    happyNumbahs.Add(initialNum);
                }
                initialNum++;
            }
            foreach(int num in happyNumbahs)
            {
                Console.WriteLine(num);
            }
           
        }
    }
}
