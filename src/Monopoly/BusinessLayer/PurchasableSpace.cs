using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    class PurchasableSpace : Space
    {
        public abstract int getRentPrice();

        public abstract int getSellingPrice();

        public abstract bool isMortgaged();

        public abstract Player ownedBy();
    }
}
