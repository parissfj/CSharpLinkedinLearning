using System;

public static class LoopCounting {
  public static void Count() {  

      int n = 1;

      while(n <= 5)
      {
        Console.WriteLine("Counting in increasing order");

        for(int i = 1; i <= 10; i++)
        {
          Console.WriteLine("\n{0}", i);
        }

        Console.WriteLine("Counting in reverse order");

        for(int j = 10; j > 0; j--)
        {
          Console.WriteLine("\n{0}", j);
        }
        n++;
      }
      Console.WriteLine("Please Hit Enter to Start Again");
      Console.ReadLine();
      MainClass.UserOptions();
  }
}