using System;

namespace All_Programs
{
  class Program
  {
    static void Main(string[] args)
    {
      for (int i = 0; i < 5; i++)
      {
        // Console.WriteLine("I love C#");
      }

      /*
      Console.Write("How many times do you want to say Hi: ");
      string userInput = Console.ReadLine()!;
      int counter = Convert.ToInt32(userInput);

      if (counter <= 0)
      {
        Console.WriteLine("Please enter above 0");
      }
      else
      {
        for (int i = 1; i <= counter; i++)
        {
          Console.WriteLine("Hi");
        }
      }
      */

      // Pattern 1
      int n = 4;

      for (int i = 1; i <= n; i++)
      {
        for (int j = 1; j <= i; j++)
        {
          Console.Write("*");
        }
        Console.WriteLine();
      }

      Console.WriteLine();
      Console.WriteLine();

      // Pattern 2
      int a = 1;

      for (int i = 5; i >= a; i--)
      {
        for (int j = 1; j <= i; j++)
        {
          Console.Write("*");
        }
        Console.WriteLine();
      }

      // Pattern 3
      int b = 5;

      for (int i = 1; i <= b; i++)
      {
        for (int j = 1; j <= i - 1; j++)
        {
          Console.Write(" ");
        }
        for (int j = 1; j <= b - i + 1; j++)
        {
          Console.Write("*");
        }
        Console.WriteLine();
      }

      // Pattern 4

      Console.WriteLine();
      Console.WriteLine();

      int c = 5;


      for (int i = 1; i <= c; i++)
      {
        for (int j = c - 1; j >= i; j--)
        {
          Console.Write(" ");
        }
        for (int j = 1; j <= i; j++)
        {
          Console.Write("*");
        }
        Console.WriteLine(" ");
      }

      Console.WriteLine();
      Console.WriteLine();

      // Pattern 5
      int d = 5;

      for (int i = 1; i <= d; i++)
      {
        for (int j = d - 1; j >= i; j--)
        {
          Console.Write(" ");
        }
        for (int j = 1; j <= (2 * i - 1); j++)
        {
          Console.Write("*");
        }
        Console.WriteLine();
      }

      Console.WriteLine();
      Console.WriteLine();

      // Pattern 6
      int e = 5;

      for (int i = 1; i <= e; i++)
      {
        for (int j = 1; j <= i - 1; j++)
        {
          Console.Write(" ");
        }
        for (int j = 1; j <= 2 * (e - i) + 1; j++)
        {
          Console.Write("*");
        }
        Console.WriteLine();
      }

    }
  }
}