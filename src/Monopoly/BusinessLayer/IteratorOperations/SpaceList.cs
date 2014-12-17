using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.IteratorOperations
{
    class SpaceList
    {
        private List<Space> listSpace ;

        public SpaceList()
        {
            listSpace = new List<Space>();
        }

        // Gets item count
        public int Count
        {
            get { return listSpace.Count; }
        }

        // Indexer
        public Space this[int index]
        {
            get { return listSpace[index]; }
            set { listSpace.Insert(index, value); }
        }

        public void Add(Space _space)
        {
            listSpace.Add(_space);
        }
    }
}
