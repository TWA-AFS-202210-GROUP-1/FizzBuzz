﻿using System;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        private string fizz = "Fizz";
        private string buzz = "Buzz";
        private string whizz = "Whizz";
        public string CountOff(int number)
        {
            if (number % 3 == 0 && number % 5 != 0 && number % 7 != 0)
            {
                return fizz;
            }
            else if (number % 5 == 0 && number % 3 != 0 && number % 7 != 0)
            {
                return buzz;
            }
            else if (number % 7 == 0 && number % 3 != 0 && number % 5 != 0)
            {
                return whizz;
            }
            else if (number % 3 == 0 && number % 5 == 0 && number % 7 != 0)
            {
                return fizz + buzz;
            }

            return number.ToString();
        }
    }
}
