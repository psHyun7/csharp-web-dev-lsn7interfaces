using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    class FlavorComparer : IComparer<Flavor>
    {
        // Compare using Names
        //public int Compare(Flavor x, Flavor y)
        //{
        //    return string.Compare(x.Name, y.Name);
        //}

        // Compare using Number of allergens
        public int Compare(Flavor x, Flavor y)
        {
            if (x.Allergens.Count < y.Allergens.Count)
            {
                return -1;
            }
            if (x.Allergens.Count > y.Allergens.Count)
            {
                return 1;
            }
            return 0;
        }
    }
}
