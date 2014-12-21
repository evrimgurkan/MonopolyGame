using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Dice
    {
        #region Props

        private int diceOneValue;
        public int diceOne
        {
            get { return diceOneValue; }
        }

        private int diceTwoValue;
        public int diceTwo
        {
            get { return diceTwoValue; }
        }

        private int doubleScoreCount;
        public int doubleCount
        {
            get { return doubleScoreCount; }
        }

        #endregion

        #region Constructor

        public Dice()
        {
            diceOneValue = 0;
            diceTwoValue = 0;
            doubleScoreCount = 0;
        }

        #endregion

        #region Methods

        public bool isDiceDouble()
        {
            bool isScoreDouble = false;
            if (diceOneValue == diceTwoValue)
            {
                isScoreDouble = true;
            }
            return isScoreDouble;
        }

        public void rollDice()
        {
            // TODO: check two dice values are different or not
            Random diceRandom = new Random();
            diceOneValue = diceRandom.Next(1, 7);
            diceTwoValue = diceRandom.Next(1, 7);
        }

        #endregion

    }
}
