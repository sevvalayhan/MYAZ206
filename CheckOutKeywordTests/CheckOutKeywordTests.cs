using ValueAndReferenceTypes;
using Xunit;

namespace CheckOutKeywordTests
{
    public class CheckOutKeywordTests
    {
        [Fact]
        public void CheckOutKeywordByRef()
        {
            //Arrange
            var refType = new ReferenceType();
            int a = 50;


            //Act
            refType.CheckOutKeywordByRef(out a);
            //Assert
            Assert.Equal(100, a);
        }
    }
}