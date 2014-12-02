using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    abstract class EventSpace : Space
    {

    }

    class CardSpace : EventSpace
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

    class JailSpace : EventSpace
    {
        public JailSpace()
        {

        }

        public override void playAction()
        {
            // Do something
        }
    }

    class GoToJailSpace : EventSpace
    {
        public GoToJailSpace()
        {

        }

        public override void playAction()
        {
            // Do something
        }
    }

    class FreeParkingSpace : EventSpace
    {
        public FreeParkingSpace()
        {

        }

        public override void playAction()
        {
            // Do something
        }
    }

    class GoSpace : EventSpace // starting point
    {
        public GoSpace()
        {

        }

        public override void playAction()
        {
            // Do something
        }
    }
}
