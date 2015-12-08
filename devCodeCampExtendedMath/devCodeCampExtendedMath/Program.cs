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
            Polyhedral polyhedral = new Polyhedral();
            Euclidean gcd = new Euclidean();

            Console.WriteLine("Enter how many faces the shape has: ");
            int faces = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter how many vertices the shape has: ");
            int vertices = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter how many edges the shape has: ");
            int edges = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What number would you like to Romanize?" );
            int romanInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number to find its GCD:");
            int gcd1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number to find its GCD:");
            int gcd2 = Convert.ToInt32(Console.ReadLine());

            

            Euclidean.getGCD(gcd1, gcd2);
            Polyhedral.polyhedral(ref vertices, ref edges, ref faces);
            Roman.goingRoman(ref romanInput);
            Console.ReadLine();
        }
    }
}
