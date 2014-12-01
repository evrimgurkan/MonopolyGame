using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public enum CardColor
    {
        Red,
        Blue,
        Yellow,
        Green,
        Orange,
        Brown,
        Cyan,
        Purple
    }

    abstract class Assets
    {
        public abstract int getRentPrice();

        public abstract int getSellingPrice();

        public abstract bool isMortgaged();

        public abstract Player ownedBy();
    }

    class PropertySpace : Assets
    {
        private CardColor colorGroup;
        public CardColor getColorGroup()
        {
            return colorGroup;
        }

        private int housePrice;
        public int getHousePrice()
        {
            return housePrice;
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

        private bool mortgaged;
        public override bool isMortgaged()
        {
            return mortgaged;
        }

        private Player owner;
        public override Player ownedBy()
        {
            return owner;
        }

        public PropertySpace(int _rentPrice, int _sellingPrice, 
            CardColor _colorGroup, int _housePrice, 
            bool _mortgaged, Player _owner)
        {
            rentPrice = _rentPrice;
            sellingPrice = _sellingPrice;
            colorGroup = _colorGroup;
            housePrice = _housePrice;
            mortgaged = _mortgaged;
            owner = _owner;

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

        private bool mortgaged;
        public override bool isMortgaged()
        {
            return mortgaged;
        }

        private Player owner;
        public override Player ownedBy()
        {
            return owner;
        }

        public RailroadSpace(int _rentPrice, int _sellingPrice,
            bool _mortgaged, Player _owner)
        {
            rentPrice = _rentPrice;
            sellingPrice = _sellingPrice;
            mortgaged = _mortgaged;
            owner = _owner;
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

        private bool mortgaged;
        public override bool isMortgaged()
        {
            return mortgaged;
        }

        private Player owner;
        public override Player ownedBy()
        {
            return owner;
        }

        public UtilitySpace(int _rentPrice, int _sellingPrice,
            bool _mortgaged, Player _owner)
        {
            rentPrice = _rentPrice;
            sellingPrice = _sellingPrice;
            mortgaged = _mortgaged;
            owner = _owner;
        }
    }
}
