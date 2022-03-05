using System.Collections;

namespace DataStructures.Arrray;

public class Array : ICloneable, IEnumerable
{
    private Object[] InnerArray { get; set; }
    public int Length => InnerArray.Length;

    public Array(int defaultSize = 16)
    {
        InnerArray = new Object[defaultSize];
    }

    public Array(params Object[] sourceArray) : this(sourceArray.Length)
    {
        //for (int i = 0; i < sourceArray.Length; i++)
        //{
        //    innerArray[i] = sourceArray[i];
        //}

        System.Array.Copy(sourceArray, InnerArray, sourceArray.Length);
    }




    public void SetValue(Object value, int index)
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

    public Object GetValue(int index)
    {
        if (!(index >= 0 && index < InnerArray.Length))
        {
            throw new ArgumentException();
        }
        Console.WriteLine(InnerArray[index]);
        return InnerArray[index];

    }

    public object Clone()
    {
        return MemberwiseClone();

    }

    public IEnumerator GetEnumerator()
    {
        return InnerArray.GetEnumerator(); //GetEnumerator() ifadesi System.Array'den geldi 
    }
}
