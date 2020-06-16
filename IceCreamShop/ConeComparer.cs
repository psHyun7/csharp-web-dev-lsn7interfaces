using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace IceCreamShop
{
    class ConeComparer : IComparer<Cone>
    {
        public int Compare([AllowNull] Cone x, [AllowNull] Cone y)
        {
            double result = (x.Cost - y.Cost);
            if (result < 0)
            { 
                return -1; 
            }
            if (result > 0)
            { 
                return 1; 
            }
            return 0;
        }
    }
}
