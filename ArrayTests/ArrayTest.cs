using Arrray;
using Xunit;

namespace ArrayTests
{
    public class ArrayTest
    {


        [Fact]
        public void ArraySetValueTest()
        {
            var arr = new DataStructures.Arrray.Array();

            arr.SetValue(10, 0);
            arr.SetValue(20, 1);
            arr.SetValue(30, 2);

            Assert.Equal(10, arr.GetValue(0));
            Assert.Equal(20, arr.GetValue(1));
            Assert.NotNull(arr.GetValue(2));
        }

        [Fact]
        public void CheckClonableTest()
        {
            var arr = new DataStructures.Arrray.Array(1, 5, 2, 4);
            arr.SetValue(1, 0);
            arr.SetValue(2, 0);
            arr.SetValue(3, 0);
            arr.SetValue(4, 0);
            arr.SetValue(5, 0);


            var cloneArr = arr.Clone() as DataStructures.Arrray.Array;

            Assert.NotNull(cloneArr);
            Assert.Equal(arr.Length, cloneArr.Length);

            Assert.NotEqual(arr.GetHashCode(), cloneArr.GetHashCode());
            //  Assert.IsType<DataStructures.Arrray.Array>(cloneArr);

        }


        [Theory]
        [InlineData(16)]
        [InlineData(32)]
        [InlineData(64)]
        public void CheckDefaultSizeFeature(int defaultSize)
        {
            //arrange
            var arr = new DataStructures.Arrray.Array(defaultSize);

            //Assert
            Assert.Equal(defaultSize, arr.Length);

        }

        [Fact]
        public void Check_Array_Constructor_with_params()
        {
            //Arrange
            var array = new DataStructures.Arrray.Array(1, 2, 3);

            //Act

            //Assert
            Assert.Equal(3, array.Length);
        }

        [Fact]
        public void Array_GetEnumerotor_Test()
        {
            //arrange
            var array = new DataStructures.Arrray.Array(10, 20, 30);


            string s = "";

            foreach (var item in array)
            {
                s += item;
            }

            Assert.Equal("102030", s);


            foreach (var item in array)
            {
                //int a=  item + 1; //int ve obj toplanamaz. string ve obj toplandý mantýðý nedir?

            }


        }



    }
}