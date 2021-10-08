using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanojskiStolpi
{
    class Program
    {
        static void Main(string[] args)
        {
            Premakni(3, "a", "c", "b");
            Console.ReadLine();
        }
        static void Premakni(int n, string zacetni, string koncni, string pomozni)
        {
            if(n==1)
            {
                Console.WriteLine("Premakni iz " + zacetni + " na " + koncni);
                return;
            }
            Premakni(n - 1, zacetni, pomozni, koncni); //1. iz a na b, pomagaj si s c
            Console.WriteLine("Premakni iz " + zacetni + " na " + koncni);
            Premakni(n - 1, pomozni, koncni, zacetni);
         

        }
    }
}
