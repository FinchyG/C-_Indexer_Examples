using System;
using System.Collections.Generic;
using System.Text;

namespace IndexerDemo
{
    class MyArray
    {
        int _lowerBound;
        int _upperBound;
        string[] _items;

        public MyArray(int lowerBound, int upperBound)
        {
            _lowerBound = lowerBound;
            _upperBound = upperBound;
            _items = new string[1 + upperBound - lowerBound];
        }

        public string this[int index]
        {
            get { return _items[index - _lowerBound]; }
            set { _items[index - _lowerBound] = value; }
        }
    }
}
