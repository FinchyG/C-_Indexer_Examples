using System;
using System.Collections.Generic;
using System.Text;

namespace Multidimensional_Indexer
{
    class TimesTables
    {
        private int[,] productsArr = new int[3, 3];
        
        public int this[int index1, int index2]
        {
            get
            {
                return productsArr[index1, index2];
            }

            set
            {
                productsArr[index1, index2] = value;
            }
        }


    }
}
