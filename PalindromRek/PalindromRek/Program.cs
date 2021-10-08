using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromRek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PalCheck("anabna"));
            Console.WriteLine(PalCheck("ana"));
            Console.ReadLine();
        }
        static Boolean PalCheck(String a)
        {

            if (a.Length == 0 || a.Length == 1)
                return true;
            if (a[0] == a[a.Length - 1])
                return PalCheck (a.Substring(1, a.Length - 2));
            return false;
                
            
        }
    }
}
