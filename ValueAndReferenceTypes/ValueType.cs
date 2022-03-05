﻿namespace ValueAndReferenceTypes
{
    public struct ValueType
    {
        public ValueType(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public void SwapByValue(int x, int y)
        {
            var temp = x;
            x = y;
            y = temp;

        }





    }
}