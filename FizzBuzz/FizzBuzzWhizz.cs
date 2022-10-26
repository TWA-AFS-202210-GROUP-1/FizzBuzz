using System;

namespace FizzBuzz
{
    public class FizzBuzzWhizz
    {
        public string CountOff(int num)
        {
            if (num % 3 == 0)
            {
                return "Fizz";
            }
            else if (num % 5 == 0)
            {
                return "Buzz";
            }
            else if (num % 7 == 0)
            {
                return "Whizz";
            }
            else
            {
                return num.ToString();
            }
        }
    }
}
