using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.IteratorOperations
{
    class SpaceIterator: Iterator
    {
        private SpaceList _listSpace;
        private int _current = 0;
 
        // Constructor
        public SpaceIterator(SpaceList lspace)
        {
            this._listSpace = lspace;
        }
 
        // Gets first iteration item
        public override Space First()
        {
            return _listSpace[0];
        }
 
        // Gets next iteration item
        public override Space Next()
        {
            Space ret = null;
            if (IsDone())
            {
                _current = -1;
            }
            if (_current < _listSpace.Count - 1)
            {
                ret = _listSpace[++_current];
            }
 
            return ret;
        }
 
        // Gets current iteration item
        public override Space CurrentItem()
        {
            return _listSpace[_current];
        }

        public override int CurrentIndex()
        {
            return _current;
        }
 
        // Gets whether iterations are complete
        public override bool IsDone()
        {
            return _current >= _listSpace.Count;
        }
    }
}
