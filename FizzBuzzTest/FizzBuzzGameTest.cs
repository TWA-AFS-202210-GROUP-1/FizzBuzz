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
    }
}