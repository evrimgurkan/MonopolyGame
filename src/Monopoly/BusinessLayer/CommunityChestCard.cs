using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    class CommunityChestCard : Card
    {
        private CardType _type;
        private string _label;

        public CommunityChestCard(string label)
        {
            _type = CardType.TYPE_CCHEST;
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
