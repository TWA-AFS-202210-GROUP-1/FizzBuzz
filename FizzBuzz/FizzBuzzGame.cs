namespace FizzBuzz
{
  public class FizzBuzzGame
  {
    public string CountOff(int number)
    {
      if (number.ToString().Contains('3'))
      {
        return "Fizz";
      }
      else if (number % 3 == 0)
      {
        if (number % 5 == 0)
        {
          if (number % 7 == 0)
          {
            return "FizzBuzzWhizz";
          }
          else
          {
            return "FizzBuzz";
          }
        }
        else if (number % 7 == 0)
        {
          return "FizzWhizz";
        }
        else
        {
          return "Fizz";
        }
      }
      else if (number % 5 == 0)
      {
        if (number % 7 == 0)
        {
          return "BuzzWhizz";
        }
        else
        {
          return "Buzz";
        }
      }
      else if (number % 7 == 0)
      {
        return "Whizz";
      }
      else
      {
        return number.ToString();
      }
    }
  }
}
