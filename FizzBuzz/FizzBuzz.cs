using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string CountOff(int number)
        {
            if (IsContains3(number))
            {
                return FizzBuzzType.Fizz.ToString();
            }

            var fizzBuzzString = string.Empty;

            foreach (FizzBuzzType type in Enum.GetValues(typeof(FizzBuzzType)))
            {
                fizzBuzzString += GenerateFizzBuzz(type, number);
            }

            return string.IsNullOrEmpty(fizzBuzzString) ? number.ToString() : fizzBuzzString;
        }

        private bool IsContains3(int number)
        {
            return number.ToString().Contains("3");
        }

        private string GenerateFizzBuzz(FizzBuzzType type, int number)
        {
            if (number % (int)type == 0)
            {
                return type.ToString();
            }

            return string.Empty;
        }
    }
}
