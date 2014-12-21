using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace MonopolyController
{
    public class DiceController
    {
        private Dice dice = new Dice();
        public int getDieOneValue()
        {
            dice.rollDice();
            return dice.diceOne;
        }
        public int getDieTwoValue()
        {
            return dice.diceTwo;
        }
        public bool isDiceDouble()
        {
            return dice.isDiceDouble();
        }
    }
}
