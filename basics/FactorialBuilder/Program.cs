using System;

namespace FactorialBuild
{
  class Program
  {
    static void Main(string[] args)
    {
      int factorial = 0;

      Console.WriteLine("Enter a number");
      string input = Console.ReadLine();

      char[] splitInput = input.ToCharArray();

      for (int i = 0; i < input.Length; i++)
      {
        int intInputValue = splitInput[i] - '0';
        factorial += intInputValue;
      }
      Console.WriteLine(factorial);
    }
  }
}
