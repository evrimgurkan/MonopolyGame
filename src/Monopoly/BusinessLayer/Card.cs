using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    abstract class Card
    {
        public enum CardType
        {
            TYPE_CHANCE,
            TYPE_CCHEST
        }

        public override CardType getType();
        public override string getLabel();
        public override void applyAction();

    }
}
