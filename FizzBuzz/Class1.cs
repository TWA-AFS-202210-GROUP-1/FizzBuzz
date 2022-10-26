using System;

namespace FizzBuzz
{
    public class Class1
    {
        public string CountOff(int num)
        {
            var snum = num.ToString();
            //string[] numlist = snum.Split();
            bool b = snum.Contains("3");
            if (b)
            {
                return "Fizz";
            }
            else
            {
                if (num % 3 == 0 && num % 5 == 0 && num % 7 == 0)
                {
                    return "FizzBuzzWhizz";
                }
                else if (num % 3 == 0 && num % 5 == 0)
                {
                    return "FizzBuzz";
                }
                else if (num % 3 == 0 && num % 7 == 0)
                {
                    return "FizzWhizz";
                }
                else if (num % 5 == 0 && num % 7 == 0)
                {
                    return "BuzzWhizz";
                }
                else if (num % 3 == 0)
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
                    return snum;
                }
            }
        }
    }
}