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

        [Fact]
        public void Should_return_fizz_when_countoff_given_only_multipy_of_three()
        {
            var fizzbuzz = new FizzBuzz.Class1();
            var num = 6;

            var result = fizzbuzz.CountOff(num);

            //then
            Assert.Equal("3", result);
        }

        [Fact]
        public void Should_return_buzz_when_countoff_given_only_multipy_of_five()
        {
            var fizzbuzz = new FizzBuzz.Class1();
            var num = 5;

            var result = fizzbuzz.CountOff(num);

            //then
            Assert.Equal("B", result);
        }

        [Fact]
        public void Should_return_buzz_when_countoff_given_only_multipy_of_seven()
        {
            var fizzbuzz = new FizzBuzz.Class1();
            var num = 7;

            var result = fizzbuzz.CountOff(num);

            //then
            Assert.Equal("Whizz", result);
        }
    }
}