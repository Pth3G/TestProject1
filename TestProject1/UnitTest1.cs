using Xunit;
using Xunit.Sdk;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(expected: 4, actual: 2 + 2);

        }

        [Fact]
        public void Test2()
        {
        
            Assert.True("Jag har fyllt " + 29 == "Jag har fyllt 29");

        }

        [Fact]
        public void Test3()
        {
            int bigNumber = 231231;
            int biggerNumber = bigNumber + 1;

            Assert.True(biggerNumber > bigNumber);

        }
        [Fact]
        public void Test4()
        {
            string purchaseDrink;
            int age = 28;

            if (age > 18)
            {
                purchaseDrink = "Beer";

            }
            else
            {
                purchaseDrink = "Coca-cola";
            }
            Assert.Equal(expected: "Beer", actual: purchaseDrink);
        }


    }
}
