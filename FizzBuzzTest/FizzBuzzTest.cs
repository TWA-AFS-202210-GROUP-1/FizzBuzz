
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    using FizzBuzz;
    public class FizzBuzzTest
    {
        [Fact]
        public void Should_return_normal_number_when_call_countoff_given_normal_number()
        {
            //given
            FizzBuzz fizzBuzz = new FizzBuzz();
            //when
            var res = fizzBuzz.CountOff(1);

            //then
            Assert.Equal("1", res);
        }

        [Fact]
        public void Should_return_fizz_when_call_countoff_given_multiple_of_three()
        {
            //given
            FizzBuzz fizzBuzz = new FizzBuzz();
            //when
            var res = fizzBuzz.CountOff(3);

            //then
            Assert.Equal("Fizz", res);
        }

        [Fact]
        public void Should_return_fizz_when_call_countoff_given_number_contain_three()
        {
            //given
            FizzBuzz fizzBuzz = new FizzBuzz();
            //when
            var res = fizzBuzz.CountOff(30);

            //then
            Assert.Equal("Fizz", res);
        }

        [Fact]
        public void Should_return_buzz_when_call_countoff_given_multiple_of_five()
        {
            //given
            FizzBuzz fizzBuzz = new FizzBuzz();
            //when
            var res = fizzBuzz.CountOff(5);

            //then
            Assert.Equal("Buzz", res);
        }

        [Fact]
        public void Should_return_whizz_when_call_countoff_given_multiple_of_seven()
        {
            //given
            FizzBuzz fizzBuzz = new FizzBuzz();
            //when
            var res = fizzBuzz.CountOff(7);

            //then
            Assert.Equal("Whizz", res);
        }

        [Fact]
        public void Should_return_fizzbuzz_when_call_countoff_given_multiple_of_three_and_five()
        {
            //given
            FizzBuzz fizzBuzz = new FizzBuzz();
            //when
            var res = fizzBuzz.CountOff(15);

            //then
            Assert.Equal("FizzBuzz", res);
        }

        [Fact]
        public void Should_return_fizzwhizz_when_call_countoff_given_multiple_of_three_and_seven()
        {
            //given
            FizzBuzz fizzBuzz = new FizzBuzz();
            //when
            var res = fizzBuzz.CountOff(21);

            //then
            Assert.Equal("FizzWhizz", res);
        }

        [Fact]
        public void Should_return_buzzwhizz_when_call_countoff_given_multiple_of_five_and_seven()
        {
            //given
            FizzBuzz fizzBuzz = new FizzBuzz();
            //when
            var res = fizzBuzz.CountOff(175);

            //then
            Assert.Equal("BuzzWhizz", res);
        }

        [Fact]
        public void Should_return_fizzbuzzwhizz_when_call_countoff_given_multiple_of_three_and_five_and_seven()
        {
            //given
            FizzBuzz fizzBuzz = new FizzBuzz();
            //when
            var res = fizzBuzz.CountOff(105);

            //then
            Assert.Equal("FizzBuzzWhizz", res);
        }
    }
}