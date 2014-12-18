using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class IncomeTax : Tax
    {

        private TaxType _type;
        private string _label;
        private int taxAmount;

        public IncomeTax(string label, int _taxAmount)
        {
            _type = TaxType.TYPE_INCOME;
            _label = label;
            taxAmount = _taxAmount;
        }

        public override TaxType getTaxType()
        {
            return _type;
        }

        public override int getTaxPrice(PaymentType type)
        {
            if (type == PaymentType.TYPE_CONSTANT_AMOUNT)
            {
                return taxAmount;
            }
            else
            {
                return 0; // Should be corrected later
            }
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
