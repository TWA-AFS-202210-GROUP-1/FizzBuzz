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
        public void Should_return_Buzz_when_input_only_multiple_of_5()
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
        public void Should_return_Whizz_when_input_only_multiple_of_7()
        {
            //give
            FizzBuzzWhizz fizzBuzzWhizz = new FizzBuzzWhizz();
            int num = 14;

            //when
            string result = fizzBuzzWhizz.CountOff(num);

            //then
            Assert.Equal("Whizz", result);
        }

        [Fact]
        public void Should_return_FizzBuzz_when_input_multiple_of_3_and_5()
        {
            //give
            FizzBuzzWhizz fizzBuzzWhizz = new FizzBuzzWhizz();
            int num = 15;

            //when
            string result = fizzBuzzWhizz.CountOff(num);

            //then
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void Should_return_FizzBuzzWhizz_when_input_multiple_of_3_and_5_and7()
        {
            //give
            FizzBuzzWhizz fizzBuzzWhizz = new FizzBuzzWhizz();
            int num = 105;

            //when
            string result = fizzBuzzWhizz.CountOff(num);

            //then
            Assert.Equal("FizzBuzzWhizz", result);
        }

        [Fact]
        public void Should_return_FizzWhizz_when_input_multiple_of_3_and_7()
        {
            //give
            FizzBuzzWhizz fizzBuzzWhizz = new FizzBuzzWhizz();
            int num = 21;

            //when
            string result = fizzBuzzWhizz.CountOff(num);

            //then
            Assert.Equal("FizzWhizz", result);
        }

        [Fact]
        public void Should_return_BuzzWhizz_when_input_multiple_of_5_and_7()
        {
            //give
            FizzBuzzWhizz fizzBuzzWhizz = new FizzBuzzWhizz();
            int num = 70;

            //when
            string result = fizzBuzzWhizz.CountOff(num);

            //then
            Assert.Equal("BuzzWhizz", result);
        }

        [Fact]
        public void Should_return_Fizz_when_input_contains_3()
        {
            //give
            FizzBuzzWhizz fizzBuzzWhizz = new FizzBuzzWhizz();
            int num = 35;

            //when
            string result = fizzBuzzWhizz.CountOff(num);

            //then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_Fizz_when_input_contains_3_ignore_rules()
        {
            //give
            FizzBuzzWhizz fizzBuzzWhizz = new FizzBuzzWhizz();
            int num = 63;

            //when
            string result = fizzBuzzWhizz.CountOff(num);

            //then
            Assert.Equal("Fizz", result);
        }
    }
}