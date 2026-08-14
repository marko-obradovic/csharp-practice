using System;

namespace ReverseName
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Please enter your name:");
      var name = Console.ReadLine();
      var reversedName = new List<char>();

      for (int i = 0; i < name.Length; i++)
      {
        var reversedIndex = (name.Length-1)-i;
        reversedName.Add(name[reversedIndex]);
      }

      Console.WriteLine(string.Join("", reversedName));
    }
  }
}
