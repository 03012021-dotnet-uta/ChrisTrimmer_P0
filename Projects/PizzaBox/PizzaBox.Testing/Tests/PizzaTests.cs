using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing.Tests
{
    public class PizzaTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(5)]
//        [InlineData(6)]
        public void Test_PepperoniPizzaToppingsCount_Fact(int value)
        {
            var sut = new PepperoniPizza();
            var result = sut.ValidateToppingRange(value);
            Assert.True(result, $"{value} is not within range.");
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(5)]
        public void Test_VeggiePizzaToppingsCount_Fact(int value)
        {
            var sut = new PepperoniPizza();
            var result = sut.ValidateToppingRange(value);
            Assert.True(result, $"{value} is not within range.");
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(5)]
        public void Test_MeatLoversPizzaToppingsCount_Fact(int value)
        {
            var sut = new PepperoniPizza();
            var result = sut.ValidateToppingRange(value);
            Assert.True(result, $"{value} is not within range.");
        }


    }
}