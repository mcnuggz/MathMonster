using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devCodeCampExtendedMath
{
    public class Polyhedral
    {      
        public static void polyhedral(ref int vertices, ref int edges, ref int faces)
        {
            int total = vertices + faces - edges;

            if (total != 2) {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }

        }
    }
}
