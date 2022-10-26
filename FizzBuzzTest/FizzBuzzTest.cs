using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Test1()
        {
            FizzBuzz.FizzBuzz fizzBuzz = new FizzBuzz.FizzBuzz();

            //then
            Assert.NotNull(fizzBuzz);
        }
    }
}