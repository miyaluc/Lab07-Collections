using System;
using System.Collections.Generic;
using System.Text;

namespace lab07_miya
{
    class Product
    {
        public Sample ShopList { get; set; }
    }
    enum Sample : int
    {
        Lotion = 1,
        Bodywash,
        HandSoap,
        Loofah,
        ShowerHead,
        Towel,
        Razor
    }
}
