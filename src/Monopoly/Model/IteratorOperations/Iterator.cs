using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.IteratorOperations
{
    public abstract class Iterator
    {
        public abstract Space First();
        public abstract Space Next();
        public abstract Space Prev();
        public abstract bool IsDone();
        public abstract bool IsStartPoint();
        public abstract int CurrentIndex();
        public abstract Space CurrentItem();
    }
}
