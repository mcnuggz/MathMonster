using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace devCodeCampExtendedMath
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find its GCD:");
            int gcd1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number to find its GCD:");
            int gcd2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter how many faces the shape has: ");
            int faces = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter how many vertices the shape has: ");
            int vertices = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter how many edges the shape has: ");
            int edges = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What number would you like to Romanize?");
            int romanInput = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("How many happy numbers do you want?: ");
            int happiness = Convert.ToInt32(Console.ReadLine());


            Math.getGCD(gcd1, gcd2);
            Math.polyhedral(ref vertices, ref edges, ref faces);
            Math.goingRoman(ref romanInput);
            Math.isHappy(happiness);
            Console.ReadLine();
        }

    }
}
