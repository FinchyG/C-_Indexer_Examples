using System;
using System.Collections.Generic;
using System.Text;

namespace StoreIndexer
{
    class StoreLocations
    {
        private string[] StoreArr = new string[4];

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= StoreArr.Length)
                    throw new IndexOutOfRangeException("Index out of range.");

                return StoreArr[index];
            }
            set
            {
                if(index < 0 || index >= StoreArr.Length)
                    throw new IndexOutOfRangeException("Index out of range.");

                StoreArr[index] = value;
            }
        }
    }
}
