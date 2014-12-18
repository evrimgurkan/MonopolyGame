using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class ChanceCard : Card
    {
        private CardType _type;
        private string _label;

        public ChanceCard(string label)
        {
            _type = CardType.TYPE_CHANCE;
            _label = label;
        }

        public override CardType getType()
        {
            return _type;
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
