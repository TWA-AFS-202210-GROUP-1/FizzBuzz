using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Should_return_normal_number_When_call_countOff_Given_normal_number()
        {
            //given
            FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
            int inputNumber = 1;

            //when
            string countOffReturnResult = fizzBuzzGame.CountOff(inputNumber);

            //then
            Assert.Equal("1", countOffReturnResult);
        }

        [Fact]
        public void Should_return_Fizz_When_call_countOff_Given_number_can_divided_by_3()
        {
            //given
            FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
            int inputNumber = 3;

            //when
            string countOffReturnResult = fizzBuzzGame.CountOff(inputNumber);

            //then
            Assert.Equal("Fizz", countOffReturnResult);
        }

        [Fact]
        public void Should_return_Buzz_When_call_countOff_Given_number_can_divided_by_5()
        {
            //given
            FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
            int inputNumber = 5;

            //when
            string countOffReturnResult = fizzBuzzGame.CountOff(inputNumber);

            //then
            Assert.Equal("Buzz", countOffReturnResult);
        }

        [Fact]
        public void Should_return_Whizz_When_call_countOff_Given_number_can_divided_by_7()
        {
            //given
            FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
            int inputNumber = 7;

            //when
            string countOffReturnResult = fizzBuzzGame.CountOff(inputNumber);

            //then
            Assert.Equal("Whizz", countOffReturnResult);
        }

        [Fact]
        public void Should_return_FizzBuzz_When_call_countOff_Given_number_can_divided_by_3_and_5()
        {
            //given
            FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
            int inputNumber = 15;

            //when
            string countOffReturnResult = fizzBuzzGame.CountOff(inputNumber);

            //then
            Assert.Equal("FizzBuzz", countOffReturnResult);
        }

        [Fact]
        public void Should_return_FizzWhizz_When_call_countOff_Given_number_can_divided_by_3_and_7()
        {
            //given
            FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
            int inputNumber = 21;

            //when
            string countOffReturnResult = fizzBuzzGame.CountOff(inputNumber);

            //then
            Assert.Equal("FizzWhizz", countOffReturnResult);
        }

        [Fact]
        public void Should_return_BuzzWhizz_When_call_countOff_Given_number_can_divided_by_5_and_7()
        {
            //given
            FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
            int inputNumber = 70;

            //when
            string countOffReturnResult = fizzBuzzGame.CountOff(inputNumber);

            //then
            Assert.Equal("BuzzWhizz", countOffReturnResult);
        }

        [Fact]
        public void Should_return_FizzBuzzWhizz_When_call_countOff_Given_number_can_divided_by_3_5_and_7()
        {
            //given
            FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
            int inputNumber = 105;

            //when
            string countOffReturnResult = fizzBuzzGame.CountOff(inputNumber);

            //then
            Assert.Equal("FizzBuzzWhizz", countOffReturnResult);
        }

        [Fact]
        public void Should_return_Fizz_When_call_countOff_Given_number_contains_3()
        {
            //given
            FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
            int inputNumber = 13;

            //when
            string countOffReturnResult = fizzBuzzGame.CountOff(inputNumber);

            //then
            Assert.Equal("Fizz", countOffReturnResult);
        }
    }
}