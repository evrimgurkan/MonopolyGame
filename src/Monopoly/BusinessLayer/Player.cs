using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class Player
    {
        #region Properties

        private string playerName;
        public string name
        {
            get { return playerName; }
        }

        private Symbol playerSymbol;
        public Symbol symbol
        {
            get { return playerSymbol; }
        }

        private int cashAmount;
        public int cash
        {
            get { return cashAmount; }
            set { cashAmount = value; }
        }

        private bool isInJail;
        public bool inJail
        {
            get { return isInJail; }
            set { isInJail = value; }
        }

        private IteratorOperations.Iterator playerIterator;
        #endregion

        #region Constructor
        public Player(string _name, int _cash, Symbol _symbol)
        {
            playerName = _name;
            cashAmount = _cash;
            playerSymbol = _symbol;
        }

        public Player() 
        {
            playerName = "Player";
            cashAmount = 0;
            playerSymbol = null;
        }
        #endregion

        #region Methods
        public void CreateIterator(IteratorOperations.SpaceList sList)
        {
            playerIterator =  new IteratorOperations.SpaceIterator(sList);
        }

        public IteratorOperations.Iterator GetIterator()
        {
            return playerIterator;
        }
        #endregion


    }
}
