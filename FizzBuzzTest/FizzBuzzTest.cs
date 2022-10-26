namespace FizzBuzzTest
{
    using Xunit;
    using FizzBuzz;

    public class FizzBuzzTest
    {
        [Fact]
        public void Should_return_normal_number_when_count_off_given_normal_number()
        {
            //given
            var fizzBuzz = new FizzBuzz();
            int number = 1;

            //when
            var result = fizzBuzz.CountOff(number);

            //then
            Assert.Equal("1", result);
        }

        [Fact]
        public void Should_return_Fizz_when_count_off_given_only_multiple_of_three()
        {
            //given
            var fizzBuzz = new FizzBuzz();
            int number = 3;

            //when
            var result = fizzBuzz.CountOff(number);

            //then
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void Should_return_Fizz_when_count_off_given_only_multiple_of_five()
        {
            //given
            var fizzBuzz = new FizzBuzz();
            int number = 5;

            //when
            var result = fizzBuzz.CountOff(number);

            //then
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void Should_return_Fizz_when_count_off_given_only_multiple_of_seven()
        {
            //given
            var fizzBuzz = new FizzBuzz();
            int number = 7;

            //when
            var result = fizzBuzz.CountOff(number);

            //then
            Assert.Equal("Whizz", result);
        }
    }
}