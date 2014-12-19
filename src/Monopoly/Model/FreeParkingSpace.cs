﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    class FreeParkingSpace : NonPurchasableSpace
    {
        private string spaceName;
        public string name
        {
            get { return spaceName; }
        }

        public FreeParkingSpace(string _name)
        {
            spaceName = _name; 
        }

        public override void playAction()
        {
            // Do something
        }
    }
}