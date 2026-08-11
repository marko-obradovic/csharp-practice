using System;

namespace Arrays
{
  class Program
  {
    static void Main(string[] args)
    {
      var numbers = new int[] {3, 7, 9, 2, 14, 6};

      // Length()
      Console.WriteLine("Length()");
      Console.WriteLine("Length: {0}", numbers.Length);
      Console.WriteLine("Original values");
      printValues(numbers);

      Console.WriteLine("\nIndexOf()");
      var numToFind = 9;

      var indexValue = Array.IndexOf(numbers, numToFind);
      Console.WriteLine("index of {0}: {1}", numToFind, indexValue);

      Console.WriteLine("\nClear()");
      Array.Clear(numbers, 0, 2);

      printValues(numbers);

      Console.WriteLine("\nCopy()");
      var newNumbers = new int[3];

      Array.Copy(numbers, 2, newNumbers, 0, 3);

      printValues(newNumbers);

      Console.WriteLine("\nSort()");
      Array.Sort(numbers);
      printValues(numbers);

      Console.WriteLine("\nReverse()");
      Array.Reverse(numbers);
      printValues(numbers);
    }

    static void printValues(int[] array)
    {
      for (int i = 0; i < array.Length; i++)
      {
        Console.WriteLine(array[i]);
      }
    }
  }
}
