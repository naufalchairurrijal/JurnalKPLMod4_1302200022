using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPL_MOD4_1302200022_RFL
{
    internal class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(double v, T a, T b, T c)
        {
            dynamic TempA = a;
            dynamic TempB = b;
            dynamic TempC = c;

            return TempA + TempB + TempC;
        }
    }
}
