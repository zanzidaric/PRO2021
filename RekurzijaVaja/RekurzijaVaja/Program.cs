using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekurzijaVaja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PotencaIterativno(10));          
            Console.WriteLine(PotencaRekurzivno(10));
            Console.WriteLine(Fib(7));
            Console.WriteLine(nal3(2));
            Console.WriteLine(nal3(5));
            Console.WriteLine("xd"+nal4(2));
            Console.WriteLine("xd"+nal4(5));
            Console.WriteLine(nal5(3));
            Console.WriteLine(nal6(3));
            Console.ReadLine();
        }
        static int PotencaIterativno(int n)
        {
            int potenca = 1;
            for (int k = 1; k <= n; k++)
            {
                potenca = potenca * 2;

            }
            return potenca;
        }
        static int PotencaRekurzivno(int n)
        {
            if (n == 0)
                return 1;
            return 2 * PotencaRekurzivno(n - 1);

        }
        static int Fib(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            return Fib(n - 1) + Fib(n - 2);

        }
        static int nal3(int n)
        {
            if (n == 1 || n == 2)
                return 2;
            return nal3(n - 2) * nal3(n - 1) - 1;
        }
        static int nal4(int n)
        {
            if (n == 1)
                return 2;
            return 3 * nal4(n - 1) + 2;
        }
        static int nal5(int n)
        {
            if (n == 1)
                return 1;
            if (n == 2)
                return 2;
            return nal5(n - 1) * 2+ nal5(n-2);
            
        }
        static int nal6(int n)
        {
            if (n == 1)
                return 1;
            if (n == 2)
                return 4;
            return nal6(n - 1) + 2;
        }

            
          
            

    }
}
