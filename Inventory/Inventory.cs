﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class Inventory
    {
        int slots;
        List<Item> items;
        
        public Inventory(int slots)
        {
            items = new List<Item>(slots);
        }

        public void Add(Item item)
        {
            items.Add(item);
        }

        public void Remove(Item item)
        {
            items.Remove(item);
        }
    }
}
