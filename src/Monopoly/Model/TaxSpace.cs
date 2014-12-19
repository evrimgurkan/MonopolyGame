using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class TaxSpace : NonPurchasableSpace
    {
        private Tax _tax;

        public TaxSpace(Tax tax)
        {
            _tax = tax;
        }

        public override void playAction()
        {
            _tax.applyAction();
        }
    }
}
