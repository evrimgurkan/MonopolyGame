using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public abstract class Cell
    {
        private CellGroup _cellGroup;
        public CellGroup cellGroup
        {
            get { return _cellGroup; }
            set { _cellGroup = value; }
        }

        private int _mortgageValue; // railroad has ?
        public int mortgageValue
        {
            get { return _mortgageValue; }
            set { _mortgageValue = value; }
        }

        private bool _mortgaged;
        public bool isMortgaged
        {
            get { return _mortgaged; }
            set { _mortgaged = value; }
        }

        private string _cellName;
        public string name
        {
            get { return _cellName; }
            set { _cellName = value; }
        }

        private Player _cellOwner;
        public Player owner
        {
            get { return _cellOwner; }
            set { _cellOwner = value; }
        }

        private bool _hasOwner;
        public bool hasOwner
        {
            get { return _hasOwner; }
            set { _hasOwner = value; }
        }

        private int _price;
        public int purchasePrice
        {
            get { return _price; }
            set { _price = value; }
        }

        public Cell()
        {
        }

        public abstract void applyAction();
    }
}
