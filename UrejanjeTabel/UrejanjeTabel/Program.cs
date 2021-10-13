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
            /*
            for(int k = 0; k < n; k++)
            {
                a[k] = r.Next(n);
            }          
               
            d = DateTime.Now;
            izbiranje(a);
            d1 = DateTime.Now;
            ts = d1 - d;
            Console.WriteLine("Cas za vstavljanje je " + ts.TotalMilliseconds + " ms");
            */
            for (int k = 0; k < n; k++)
            {
                a[k] = r.Next(n);
            }
            d = DateTime.Now;

            //int[] a = { 6,24,80,4,19,84,1,10,13,7};
            //Console.WriteLine("Neurejena");
            //izpis(a);

            quicksort(0, a.Length - 1, a);
            d1 = DateTime.Now;
            ts = d1 - d;
            Console.WriteLine("Cas za quicksort je " + ts.TotalMilliseconds + " ms");

            //Console.WriteLine("Urejeno");
            //izpis(a);

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
        static int Pivot(int zac,int kone,int [] tab)
        {
            int p = tab[zac];
            int m = zac;
            int n = kone + 1;
            //poisci z m prvega, ki je vecji od p
            do
            {
                m = m + 1;
            } while (tab[m] <= p & m < kone);
            do
            {
                n = n - 1;
            } while (tab[n] > p);
            //tab[m] je vecji od p
            //tab[n] je vecji od p
            //zamenjaj jih
            while (m < n)
            {
                int temp = tab[m];
                tab[m] = tab[n];
                tab[n] = temp;
                do
                {
                    m = m + 1;
                } while (tab[m] <= p);
                do
                {
                    n = n - 1;
                } while (tab[n] > p);
            }
            //zamenjaj pivotni element, z elementom tab[n]
            int temp2 = tab[n];
            tab[n] = tab[zac];
            tab[zac] = temp2;
            //izpis(tab);
            return n;
        }
        static void quicksort(int zac, int konec, int[] tab)
        {
            if (zac >= konec)
                return;
            int a = Pivot(zac, konec, tab);
            quicksort(zac, a - 1, tab);//levi del
            quicksort(a + 1, konec, tab);//desni del
            
                
        }
    }
}
