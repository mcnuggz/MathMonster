using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace devCodeCampExtendedMath
{
    public class Math
    {
        public static void Main()
        {
            Roman roman = new Roman();
            HappyNumber hn = new HappyNumber();
            hn.printHappyNumbers(50);

            Console.WriteLine(Roman.goingRoman(563));
            Console.WriteLine(Euclidean.getGCD(489, 36));
            Console.ReadLine();
        }
    }
}
