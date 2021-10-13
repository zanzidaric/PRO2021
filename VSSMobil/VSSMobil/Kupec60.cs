using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSSMobil
{
    class Kupec60:Kupec
    {
        private int visjatarifaporabljeno; //koliko od 60 min je ze porabil
        public new void beleziklic(int minute, int tip)
        {
            switch(tip)
            {
                case 1:
                    stanje += minute * 0.2m;
                    break;
                case 2:
                    //prvih 60 min po 0.05
                    //vse ostale po 0.01
                    int vMinute, nMinute;
                    int seVMinute = (visjatarifaporabljeno < 60) ? 60 - visjatarifaporabljeno : 0;
                    if (minute > seVMinute)
                    {
                        vMinute = seVMinute;
                        nMinute = minute - vMinute;
                    }
                    else
                    {
                        vMinute = minute;
                        nMinute = 0;
                    }
                    stanje += vMinute * 0.05m + nMinute * 0.01m;
                    visjatarifaporabljeno += vMinute;
                    break;
            }
        }

        
    }
}
