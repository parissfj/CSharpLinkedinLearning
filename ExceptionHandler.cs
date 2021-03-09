using System;
public class ExceptionHandler
{
  public string TryAgain()
  {
    string input = Console.ReadLine();
    while (input == "")
    {
      Console.WriteLine("You didn't enter anything, Please try again");
      input = Console.ReadLine();
      //return input;
    }
    return input;
  }
}
