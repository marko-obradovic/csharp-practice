using System;

namespace FacebookLikes
{
  class Program
  {
    static void Main(string[] args)
    {
      var names = new List<string>();
      Console.WriteLine("Enter a name:");

      while (true)
      {
        string name = Console.ReadLine();

        if (name == "")
        {
          PrintLikesMessage(names);
          return;
        }

        names.Add(name);
      }
    }

    static void PrintLikesMessage(List<string> names)
    {
      if (names.Count >= 3)
      {
        Console.WriteLine("{0}, {1}, and {2} others like your post.", names[0], names[1], names.Count - 2);
        return;
      }

      if (names.Count == 2)
      {
        Console.WriteLine("{0} and {1} like your post.", names[0], names[1]);
        return;
      }

      Console.WriteLine("{0} likes your post.", names[0]);

    }
  }
}
