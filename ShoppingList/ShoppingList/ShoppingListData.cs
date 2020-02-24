﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ShoppingList
{
    class ShoppingListData : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        List<string> items = new List<string>();

        public IEnumerable<string> Items => items.ToArray();

        public void Add(string item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        public void Remove(string item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}
