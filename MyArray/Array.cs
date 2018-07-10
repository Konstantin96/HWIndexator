using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    public class MyArr
    {
        private int[] _array;

        public MyArr()
        {
            Size = 1;
            _array = new int[Size];
        }

        public MyArr(int size)
        {
            Size = size;
            _array = new int[Size];
        }

        public int Size { get; set; }
        public int GetElem(int si)
        {
            return _array[si];
        }
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
