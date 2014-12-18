using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    abstract class Card
    {
        public enum CardType
        {
            TYPE_CHANCE,
            TYPE_CCHEST
        }

        public abstract CardType getType();
        public abstract string getLabel();
        public abstract void applyAction();

    }
}
