using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Matrix
    {
        private int[,] arr = new int[,] { { 1, 2, 3 }, {4, 5, 6 } };
        public int this [int x, int y]
        {
            get
            {
                return arr[x, y];
            }
            //set
            //{
            //    arr[x, y] = value;
            //}
        }
    }
}
