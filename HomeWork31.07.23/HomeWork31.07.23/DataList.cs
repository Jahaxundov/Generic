using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork31._07._23
{
    internal class DataList<T> where T:BaseEntity
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

        public T GetById(int id)
        {
            foreach (var item in _datas)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }

        public T[] Delete(int id)
        {
            T[] newArray = new T[_datas.Length - 1];

            foreach (var item in _datas)
            {
                if (item.Id == id)
                {
                    for (int i = id; i < newArray.Length; i++)
                    {
                        newArray[i] = _datas[i];
                    }
                }
            }
            return newArray;
        }

    }

}
