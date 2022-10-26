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
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_buzz_when_countoff_given_only_multipy_of_five()
        {
            var fizzbuzz = new FizzBuzz.Class1();
            var num = 5;

            var result = fizzbuzz.CountOff(num);

            //then
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Should_return_whizz_when_countoff_given_only_multipy_of_seven()
        {
            var fizzbuzz = new FizzBuzz.Class1();
            var num = 7;

            var result = fizzbuzz.CountOff(num);

            //then
            Assert.Equal("Whizz", result);
        }

        [Fact]
        public void Should_return_fizz_when_countoff_given_contains_three()
        {
            var fizzbuzz = new FizzBuzz.Class1();
            var num = 315;

            var result = fizzbuzz.CountOff(num);

            //then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_fizzbuzz_when_countoff_given_multiply_three_and_five()
        {
            var fizzbuzz = new FizzBuzz.Class1();
            var num = 15;

            var result = fizzbuzz.CountOff(num);

            //then
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void Should_return_fizzwhizz_when_countoff_given_multiply_three_and_seven()
        {
            var fizzbuzz = new FizzBuzz.Class1();
            var num = 21;

            var result = fizzbuzz.CountOff(num);

            //then
            Assert.Equal("FizzWhizz", result);
        }

        [Fact]
        public void Should_return_buzzwhizz_when_countoff_given_multiply_five_and_seven()
        {
            var fizzbuzz = new FizzBuzz.Class1();
            var num = 70;

            var result = fizzbuzz.CountOff(num);

            //then
            Assert.Equal("BuzzWhizz", result);
        }

        [Fact]
        public void Should_return_fizzbuzzwhizz_when_countoff_given_multiply_three_five_and_seven()
        {
            var fizzbuzz = new FizzBuzz.Class1();
            var num = 105;

            var result = fizzbuzz.CountOff(num);

            //then
            Assert.Equal("FizzBuzzWhizz", result);
        }
    }
}