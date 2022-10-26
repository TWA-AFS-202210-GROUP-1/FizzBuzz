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
    }
}