namespace DisplayDivisibleNumbersInRange
{
  class Program
  {
    static void Main(string[] args)
    {
      int lowerRange = 1;
      int upperRange = 100;

      for (int i = lowerRange+1; i < upperRange; i++)
      {
        if (i % 3 == 0)
        {
          Console.WriteLine(i);
        }
      }
    }
  }
}
