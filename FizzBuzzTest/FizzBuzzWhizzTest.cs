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

        [Fact]
        public void Should_return_Fizz_when_input_only_multiple_of_3()
        {
            //give
            FizzBuzzWhizz fizzBuzzWhizz = new FizzBuzzWhizz();
            int num = 6;

            //when
            string result = fizzBuzzWhizz.CountOff(num);

            //then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_Fizz_when_input_only_multiple_of_5()
        {
            //give
            FizzBuzzWhizz fizzBuzzWhizz = new FizzBuzzWhizz();
            int num = 10;

            //when
            string result = fizzBuzzWhizz.CountOff(num);

            //then
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Should_return_Fizz_when_input_only_multiple_of_7()
        {
            //give
            FizzBuzzWhizz fizzBuzzWhizz = new FizzBuzzWhizz();
            int num = 14;

            //when
            string result = fizzBuzzWhizz.CountOff(num);

            //then
            Assert.Equal("Whizz", result);
        }
    }
}