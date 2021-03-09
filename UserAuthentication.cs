using System;

public static class UserAuthentication {
  public static void Authenticate() {
    // We need:
    // 1. Accept user input
    // 2. Check input against the word "secret"
    // 3. If input matches then authenticated, else not authenticated.
    string password="";
    while(password != "secret")
    {
        Console.WriteLine("Please enter your password: ");
        password = Console.ReadLine();

        if(password != "secret")
         Console.WriteLine("Wrong password!");
          
    }
    Console.WriteLine("You are Authenticated!");
    Console.WriteLine("Please Hit Enter to Start Again");
    Console.ReadLine();
    MainClass.UserOptions();
  }
}