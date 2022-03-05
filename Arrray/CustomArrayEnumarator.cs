using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrray
{
    public class CustomArrayEnumerator : IEnumerator
    {
        public Object[] _array;
        private int index;
        public object Current => _array[index];

        public CustomArrayEnumerator(Object[] sourceArray)
        {
            _array = sourceArray;
            index = -1; //index'ler 0'dan başladığı için.
        }


        public bool MoveNext()
        {
            if (index < _array.Length - 1)
            {
                index++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
