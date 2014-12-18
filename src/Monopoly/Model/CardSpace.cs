using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class CardSpace : Space
    {
        private Card _card;

        public CardSpace(Card card)
        {
            _card = card;
        }

        public override void playAction()
        {
            _card.applyAction();
        }
    }
}
