using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.CommandOperations;
using Model.IteratorOperations;

namespace Model
{
    public class Player : CommandReceiver
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

        private int player_id;
        public int playerID
        {
            get { return player_id; }
            set { player_id = value; }
        }

        private Iterator playerIterator;
        private List<Cell> Assets;
        #endregion

        #region Constructor
        public Player(string _name, int _cash, Symbol _symbol)
        {
            playerName = _name;
            cashAmount = 1000;
            playerSymbol = _symbol;
            Assets = new List<Cell>();
        }

        public Player() 
        {
            playerName = "Player";
            cashAmount = 0;
            playerSymbol = null;
        }
        #endregion

        #region Methods
        public void CreateIterator(SpaceList sList)
        {
            playerIterator =  new SpaceIterator(sList);
        }

        public Iterator GetIterator()
        {
            return playerIterator;
        }

        public int GetTotalAssetsAmount()
        {
            return 0; // Calculate
        }

        public void AddAssest(Cell assset)
        {
            Assets.Add(assset);
        }

        public void RemoveAssest(Cell assset)
        {
            Assets.Remove(assset);
        }
        #endregion

    }
}
