using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork31._07._23
{
    internal class DataList<T>
    {
        private T[] _datas;

        public DataList()
        {
            _datas = Array.Empty<T>();
        }

        public void Add(T item)
        {
            Array.Resize(ref _datas, _datas.Length + 1);
            _datas[_datas.Length - 1] = item;
        }

        public T[] GetAll()
        {
            return _datas;
        }
    }
}
