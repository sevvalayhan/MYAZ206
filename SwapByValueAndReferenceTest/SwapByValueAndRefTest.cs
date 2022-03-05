using ValueAndReferenceTypes;
using Xunit;

namespace SwapByValueAndReferenceTest
{
    public class SwapByValueAndRefTest
    {
        [Fact]
        public void SwapByValueTest1()
        {
            //Arrange 
            var valueType = new ValueType();
            int a = 23, b = 55;

            //Act
            valueType.SwapByValue(a, b);

            //Assert
            Assert.Equal(23, a);
            Assert.Equal(55, b);

        }

        [Fact]
        public void SwapByReferenceTest()
        {
            //Arrange
            var referenceType = new ReferenceType();
            int a = 23, b = 55;

            //Act
            referenceType.SwapByRef(ref a, ref b);

            //Assert

            Assert.Equal(55, a);
            Assert.Equal(23, b);
        }
    }
}