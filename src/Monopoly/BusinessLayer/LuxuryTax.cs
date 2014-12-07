using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    class LuxuryTax : Tax
    {
        private TaxType _type;
        private string _label;
        private int taxAmount;

        public LuxuryTax(string label, int _taxAmount)
        {
            _type = TaxType.TYPE_LUXURY;
            _label = label;
            taxAmount = _taxAmount;
        }

        public override TaxType getTaxType()
        {
            return _type;
        }

        public override int getTaxPrice(PaymentType type)
        {
            return taxAmount;
        }

        public override string getLabel()
        {
            return _label;
        }

        public override void applyAction()
        {
            // Do something
        }
    }
}
