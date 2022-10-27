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
      int number = 2;

      // when
      string result = fizzBuzzGame.CountOff(number);

      // then
      Assert.Equal("2", result);
    }

    [Fact]
    public void Should_return_Fizz_when_countoff_given_multiples_of_3()
    {
      // given
      FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
      int number = 6;

      // when
      string result = fizzBuzzGame.CountOff(number);

      // then
      Assert.Equal("Fizz", result);
    }

    [Fact]
    public void Should_return_Buzz_when_countoff_given_multiples_of_5_without_3()
    {
      // given
      FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
      int number = 10;

      // when
      string result = fizzBuzzGame.CountOff(number);

      // then
      Assert.Equal("Buzz", result);
    }

    [Fact]
    public void Should_return_Whizz_when_countoff_given_multiples_of_7_without_3()
    {
      // given
      FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
      int number = 14;

      // when
      string result = fizzBuzzGame.CountOff(number);

      // then
      Assert.Equal("Whizz", result);
    }

    [Fact]
    public void Should_return_FizzBuzz_when_countoff_given_multiples_of_3_and_5_without_3()
    {
      // given
      FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
      int number = 15;

      // when
      string result = fizzBuzzGame.CountOff(number);

      // then
      Assert.Equal("FizzBuzz", result);
    }

    [Fact]
    public void Should_return_FizzWhizz_when_countoff_given_multiples_of_3_and_7_without_3()
    {
      // given
      FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
      int number = 42;

      // when
      string result = fizzBuzzGame.CountOff(number);

      // then
      Assert.Equal("FizzWhizz", result);
    }

    [Fact]
    public void Should_return_BuzzWhizz_when_countoff_given_multiples_of_5_and_7_without_3()
    {
      // given
      FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
      int number = 70;

      // when
      string result = fizzBuzzGame.CountOff(number);

      // then
      Assert.Equal("BuzzWhizz", result);
    }

    [Fact]
    public void Should_return_FizzBuzzWhizz_when_countoff_given_multiples_of_3_and_5_and_7_without_3()
    {
      // given
      FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
      int number = 210;

      // when
      string result = fizzBuzzGame.CountOff(number);

      // then
      Assert.Equal("FizzBuzzWhizz", result);
    }

    [Fact]
    public void Should_return_Fizz_when_countoff_given_number_containing_3()
    {
      // given
      FizzBuzzGame fizzBuzzGame = new FizzBuzzGame();
      int number = 30;

      // when
      string result = fizzBuzzGame.CountOff(number);

      // then
      Assert.Equal("Fizz", result);
    }
  }
}