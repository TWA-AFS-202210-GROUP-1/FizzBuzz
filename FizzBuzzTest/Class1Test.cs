using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class Class1Test
    {
        [Fact]
        public void Should_return_normal_number_when_countoff_given_normal_number()
        {
            var fizzbuzz = new FizzBuzz.Class1();
            var num = 1;

            var result = fizzbuzz.CountOff(num);

            //then
            Assert.Equal("1", result);
        }
    }
}