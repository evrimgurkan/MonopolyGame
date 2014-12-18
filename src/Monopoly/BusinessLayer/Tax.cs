using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    abstract class Tax
    {
        public enum TaxType
        {
            TYPE_INCOME,
            TYPE_LUXURY
        }

        public enum PaymentType
        {
            TYPE_TEN_PERCENT_AMOUNT,
            TYPE_CONSTANT_AMOUNT
        }

        public abstract int getTaxPrice(PaymentType type);
        public abstract TaxType getTaxType();
        public abstract string getLabel();
        public abstract void applyAction();
    }
}
