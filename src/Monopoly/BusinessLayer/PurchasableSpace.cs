using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    class PurchasableSpace : Space
    {
        private Cell _pCell;
        public Cell pCell
        {
            get { return _pCell; }
            set { _pCell = value; }
        }

        public PurchasableSpace(Cell _cell)
        {
            _pCell = _cell;
        }

        public override void playAction()
        {
            // Do something
        }
    }
}
