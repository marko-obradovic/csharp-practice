using System;

namespace CalculateSumOfInputs
{
  class Program
  {
    static void Main(string[] args)
    {
      int numbersSum = 0;

      while (true)
      {
        Console.WriteLine("Type a number to add to the list, or 'ok' to exit");
        var input = Console.ReadLine();

        if (input.ToLower() == "ok")
        {
          Console.WriteLine("Sum of numbers: {0}", numbersSum);
          return;
        }

        try
        {
          var numInput = Int32.Parse(input);
          numbersSum += numInput;
        }
        catch
        {
          Console.WriteLine("{0} is not valid. Type a number to add to the list, or 'ok' to exit", input);
          continue;
        }
      }
    }
  }
}
