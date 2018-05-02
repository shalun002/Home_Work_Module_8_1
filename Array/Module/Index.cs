using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Module
{
    public class Index
    {
        private int[] _array;

        public Index()
        {
            Size = 1;
            _array = new int[Size];
        }

        public Index(int size)
        {
            Size = size;
            _array = new int[Size];
        }

        public int Size { get; set; }

        public int this[int i]
        {
            get
            {
                return _array[i];
            }
            set
            {
                _array[i] = (int)Math.Pow((double)value, 2);
            }
        }
    }
}
