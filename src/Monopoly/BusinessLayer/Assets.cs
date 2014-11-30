using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    abstract class Assets
    {
        public abstract int getRentPrice();

        public abstract int getSellingPrice();

        private bool _isMortgaged;
        public bool isMortgaged
        {
            get { return _isMortgaged; }
            set { _isMortgaged = value; }
        }

        private Player _ownedBy;
        public Player ownedBy
        {
            get { return _ownedBy; }
            set { _ownedBy = value; }
        }

        public Assets()
        {
            _ownedBy = null;
            _isMortgaged = false;
        }
    }

    class PropertySpace : Assets
    {
        // TODO: it can be enum for color
        private int _colorGroup;
        public int colorGroup
        {
            get { return _colorGroup; }
            set { _colorGroup = value; }
        }

        private int _housePrice;
        public int housePrice
        {
            get { return _housePrice; }
            set { _housePrice = value; }
        }

        private int _numberOfHouses;
        public int numberOfHouses
        {
            get { return _numberOfHouses; }
            set { _numberOfHouses = value; }
        }

        private int rentPrice;
        public override int getRentPrice()
        {
            return rentPrice;
        }

        private int sellingPrice;
        public override int getSellingPrice()
        {
            return sellingPrice;
        }

        public PropertySpace(int _rentPrice, int _sellingPrice)
        {
            rentPrice = _rentPrice;
            sellingPrice = _sellingPrice;

            _colorGroup = -1;
            _housePrice = 0;
            _numberOfHouses = 0;
        }
    }

    class RailroadSpace : Assets
    {
        private int rentPrice;
        public override int getRentPrice()
        {
            return rentPrice;
        }

        private int sellingPrice;
        public override int getSellingPrice()
        {
            return sellingPrice;
        }

        public RailroadSpace(int _rentPrice, int _sellingPrice)
        {
            rentPrice = _rentPrice;
            sellingPrice = _sellingPrice;
        }
    }

    class UtilitySpace : Assets
    {
        private int rentPrice;
        public override int getRentPrice()
        {
            return rentPrice;
        }

        private int sellingPrice;
        public override int getSellingPrice()
        {
            return sellingPrice;
        }

        public UtilitySpace(int _rentPrice, int _sellingPrice)
        {
            rentPrice = _rentPrice;
            sellingPrice = _sellingPrice;
        }
    }
}
