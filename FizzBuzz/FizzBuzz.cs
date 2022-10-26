using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public object CountOff(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }

            if (number % 5 == 0)
            {
                return "Buzz";
            }

            if (number % 7 == 0)
            {
                return "Whizz";
            }

            return number.ToString();
        }
    }
}
