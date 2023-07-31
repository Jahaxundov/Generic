using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork31._07._23
{
    internal class StringList
    {
        private string[] _stringList;

        public StringList()
        {
            _stringList = new string[0];
        }

        public void AddStr(string str)
        {
            Array.Resize(ref _stringList, _stringList.Length + 1);
            _stringList[_stringList.Length - 1] = str;
        }

        public string[] GetAll()
        {
            return _stringList; 
        }
    }
}
