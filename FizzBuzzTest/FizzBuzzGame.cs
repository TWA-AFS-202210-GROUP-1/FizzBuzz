using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
  public class FizzBuzzGameTest
  {
    [Fact]
    public void Should_return_normal_number_when_countoff_given_normal_number()
    {
      // given
      FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
      int number = 1;

      // when
      string result = fizzBuzzGame.CountOff(number);

      // then
      Assert.Equal("1", result);
    }

    [Fact]
    public void Should_return_Fizz_when_countoff_given_multiples_of_3()
    {
      // given
      FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
      int number = 3;

      // when
      string result = fizzBuzzGame.CountOff(number);

      // then
      Assert.Equal("Fizz", result);
    }

    [Fact]
    public void Should_return_Buzz_when_countoff_given_multiples_of_5()
    {
      // given
      FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
      int number = 5;

      // when
      string result = fizzBuzzGame.CountOff(number);

      // then
      Assert.Equal("Buzz", result);
    }

    [Fact]
    public void Should_return_Whizz_when_countoff_given_multiples_of_7()
    {
      // given
      FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
      int number = 7;

      // when
      string result = fizzBuzzGame.CountOff(number);

      // then
      Assert.Equal("Whizz", result);
    }
  }
}