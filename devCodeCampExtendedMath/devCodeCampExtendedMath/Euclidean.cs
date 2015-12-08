using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devCodeCampExtendedMath
{
    public class Euclidean
    {
        public static int getGCD(int firstNumber, int secondNumber)
        {
            if (0 == secondNumber)
                return firstNumber;
            else
                return getGCD(secondNumber, firstNumber % secondNumber);
        }
    }
}
