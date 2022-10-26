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
            else
            { return num.ToString(); }
        }
    }
}
