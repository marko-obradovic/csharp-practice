namespace CalculateSumOfInputs
{
  class Program
  {
    static void Main(string[] args)
    {
      while (true)
      {
        var numbers = new List<int>();

        Console.WriteLine("Type a number, or '0' to exit");

        int input = Int32.Parse(Console.ReadLine());

        if (input == 0)
        {
          int numbersSum = 0;
          for (int i = 0; i < 5; i++)
          {
            Console.WriteLine(i);
          //  numbersSum += numbers[i];
          }

          Console.WriteLine("Sum of numbers: {0}", numbersSum);
          return;
        }

        Console.WriteLine(numbers.Count());
        numbers.Add(1);
      }
      return;
    }
  }
}
