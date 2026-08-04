using System;

namespace GuessTheNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      Random randomNum = new Random();
      int answer = randomNum.Next(1, 10);

      Console.WriteLine("I'm thinking of a number from 1-10. What's my number?");
      Console.WriteLine("ANSWER: {0}", answer);

      for (int i = 1; i <= 4; i++)
      {

        Console.WriteLine("Attempt {0}", i);
        int input = Int32.Parse(Console.ReadLine());

        if (input == answer)
        {
          Console.WriteLine("You won!");
          return;
        }

        Console.WriteLine("Incorrect answer.");

        if (i == 4)
        {
          Console.WriteLine("You Lost.");
          return;
        }

        continue;
      }
    }
  }
}
