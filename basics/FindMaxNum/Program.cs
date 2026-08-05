using System;
using System.Linq;

namespace FindMaxNum
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter a series of numbers separated by a comma. This program will find the largest number you provide.");
      string[] input = Console.ReadLine().Split(',');

      var numbers = new List<int>();

      for (int i = 0; i < input.Length; i++)
      {
        numbers.Add(Int32.Parse(input[i]));
      }

      Console.WriteLine(MaxNum(numbers));
    }

    static int MaxNum(List<int> numbers)
    {
      int largestNum = 0;
      for (int i = 0; i < numbers.Count; i++)
      {
        // if the current number is larger than largestNum, Update the largestNum to it.
        if (numbers[i] > largestNum)
        {
          largestNum = numbers[i];
        }
      }
      return largestNum;
    }
  }
}
