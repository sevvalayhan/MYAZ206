using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrray.Generic
{
    public class Array<T> : ICloneable, IEnumerable<T>
    {
        public T[] InnerArray { get; set; }
        public int Length => InnerArray.Length;


        public Array()
        {
            InnerArray = new T[Length];
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public T GetValue(int index)
        {
            if (!(index >= 0 && index < InnerArray.Length))
            {
                throw new ArgumentException();
            }
            Console.WriteLine(InnerArray[index]);
            return InnerArray[index];
        }

        public IEnumerator<T> GetEnumerator()
        {
            return InnerArray.Take(Length).GetEnumerator();

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();

        }


        public void SetValue(T value, int index)
        {
            if (!(index >= 0 && index < InnerArray.Length))
            {
                throw new ArgumentException();
            }
            if (value == null)
            {
                throw new ArgumentException();
            }

            InnerArray[index] = value;
            return;
        }
    }
}
