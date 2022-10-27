using System;

namespace FizzBuzz
{
    public class FizzBuzzWhizz
    {
        private readonly int firstSpecialNum = 3;
        private readonly int secondSpecialNum = 5;
        private readonly int thirdSpecialNum = 7;
        public string CountOff(int num)
        {
            var num2Str = num.ToString();

            if (num2Str.Contains(firstSpecialNum.ToString()))
            {
                return "Fizz";
            }

            if (num % firstSpecialNum == 0)
            {
                if (num % secondSpecialNum == 0 && num % thirdSpecialNum == 0)
                {
                    return "FizzBuzzWhizz";
                }
                else if (num % secondSpecialNum == 0)
                {
                    return "FizzBuzz";
                }
                else if (num % thirdSpecialNum == 0)
                {
                    return "FizzWhizz";
                }
                else
                {
                    return "Fizz";
                }
            }
            else if (num % secondSpecialNum == 0)
            {
                if (num % thirdSpecialNum == 0)
                {
                    return "BuzzWhizz";
                }
                else
                {
                    return "Buzz";
                }
            }
            else if (num % thirdSpecialNum == 0)
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
