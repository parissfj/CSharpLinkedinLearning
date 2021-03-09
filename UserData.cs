using System;

public static class UserData {



    public static void Ask() {
    // We need:
    // 1. Users Name - What is your name?
    // 2. Age - How old are you?
    // 3. Month - What month were you born?
    // 4. Output the answer back to the user.
    ExceptionHandler exception = new ExceptionHandler();
    Console.WriteLine("What is your name?");
    string name = exception.TryAgain();

    Console.WriteLine("How old are you?");
    string age = exception.TryAgain();

    Console.WriteLine("What month were you born?");
    string birthMonth = exception.TryAgain();

    Console.WriteLine("Name: {0} age: {1} birthMonth: {2}", name, age, birthMonth);

    Console.WriteLine("Please Hit Enter to Start Again");
    Console.ReadLine();
    MainClass.UserOptions();
  }

}