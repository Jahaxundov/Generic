using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork31._07._23
{
    internal class IntList
    {
        private int[] _intList;
        public IntList()
        {
            _intList = new int[0];
        }

        public void Add(int num)
        {
            Array.Resize(ref _intList,_intList.Length+1);
            _intList[_intList.Length-1] = num;
        }

        public int[] GetAll()
        {
            return _intList;
        }
    }
}
