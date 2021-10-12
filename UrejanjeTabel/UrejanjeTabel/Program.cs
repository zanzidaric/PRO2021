using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrejanjeTabel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 50000;
            int[] a = new int[n];
            Random r = new Random();
            for(int k = 0; k < n; k++)
            {
                a[k] = r.Next(n);
            }
            DateTime d = DateTime.Now;
            Vstavljanje(a);
            DateTime d1 = DateTime.Now;
            TimeSpan ts = d1 - d;
            Console.WriteLine("Cas za vstavljanje je "+ts.TotalMilliseconds+" ms");
            for(int k = 0; k < n; k++)
            {
                a[k] = r.Next(n);
            }          
               
            d = DateTime.Now;
            izbiranje(a);
            d1 = DateTime.Now;
            ts = d1 - d;
            Console.WriteLine("Cas za vstavljanje je " + ts.TotalMilliseconds + " ms");

            Console.ReadLine();


            //int[] a = { 6, 24, 80, 4, 19, 1, 10, 13, 7 };
            /*Console.WriteLine("Neurejena");
            izpis(a);
            Vstavljanje(a);
            Console.WriteLine("Urejeno");
            izpis(a);
            Console.ReadLine();*/
            
        }
        static void izbiranje(int[] a)
        {
            for (int k = 0; k < a.Length; k++)
            {
                //poišči minimum
                int min = a[k];
                int minIndeks = k;
                for (int j = k; j < a.Length-1; j++)
                {
                    if (a[j] < min)
                    {
                        min = a[j];
                        minIndeks = j;
                    }
                }
                //zamenjaj k-ti in najmansi element
                int temp = a[k];
                a[k] = a[minIndeks];
                a[minIndeks] = temp;
                //izpis(a);

            }
        }
        static void Vstavljanje(int[] a)
        {
            for(int k = 1; k < a.Length; k++)
            {
                int j = k;
                int temp = a[k];
                while(j > 0 && a[j - 1] > temp) //pogrezannje
                {
                    a[j] = a[j - 1];
                    j--;
                }
                a[j] = temp;
                //izpis(a);
            }
        }
        static void izpis(int [] a)
        {
            for(int k=0;k<a.Length;k++)
            {
                Console.Write(a[k]+"\t");
            }
            Console.WriteLine();
        }
    }
}
