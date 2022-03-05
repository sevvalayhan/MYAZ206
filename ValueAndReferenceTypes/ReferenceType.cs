namespace ValueAndReferenceTypes
{
    public class ReferenceType
    {
        public int X { get; set; }
        public int Y { get; set; }

        public ReferenceType()
        {

        }
        public ReferenceType(int y, int x)
        {
            X = x;

            Y = y;
        }
        public void SwapByRef(ref int x, ref int y)
        {
            var temp = x;
            x = y;
            y = temp;
        }


        public void CheckOutKeywordByRef(out int x)
        {
            x = 100;
            return;
        }


    }
}