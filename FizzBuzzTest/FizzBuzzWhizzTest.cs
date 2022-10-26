using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzWhizzTest
    {
        [Fact]
        public void Should_return_normal_case_when_input_normal_case()
        {
            //give
            FizzBuzzWhizz fizzBuzzWhizz = new FizzBuzzWhizz();
            int num = 1;

            //when
            string result = fizzBuzzWhizz.CountOff(num);

            //then
            Assert.Equal("1", result);
        }
    }
}