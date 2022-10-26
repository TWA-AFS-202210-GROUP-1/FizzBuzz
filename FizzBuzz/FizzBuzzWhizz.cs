using System;

namespace FizzBuzz
{
    public class FizzBuzzWhizz
    {
        public string CountOff(int num)
        {
            string num2Str = num.ToString();

            if (num2Str.Contains("3"))
            {
                return "Fizz";
            }

            if (num % 3 == 0)
            {
                if (num % 5 == 0 && num % 7 == 0)
                {
                    return "FizzBuzzWhizz";
                }
                else if (num % 5 == 0)
                {
                    return "FizzBuzz";
                }
                else if (num % 7 == 0)
                {
                    return "FizzWhizz";
                }
                else
                {
                    return "Fizz";
                }
            }
            else if (num % 5 == 0)
            {
                if (num % 7 == 0)
                {
                    return "BuzzWhizz";
                }
                else
                {
                    return "Buzz";
                }
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
