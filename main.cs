using System;

public static class MainClass {
  public static void Main (string[] args) {
    UserOptions();
  }

  public static void UserOptions() {
    //Console.Clear();
    // Console.WriteLine("Please pick a program:" 
    // + "\n1: User Data" 
    // + "\n2: User Authentication"
    // + "\n3: Loop Counting");

        Console.WriteLine(@"Please pick a program: 
1: User Data
2: User Authentication
3: Loop Counting
4: Student Manager
");

    var selectedOption = Console.ReadLine();
    // Check if the user entered an empty string. If they did then call UserOptions again. Keep doing this until the user enters a correct option.
    while (selectedOption == "")
    {
      UserOptions();
    }

    switch(selectedOption) {
      case "1":
        UserData.Ask();
        break;
      case "2":
        UserAuthentication.Authenticate();
        break;
      case "3":
        LoopCounting.Count();
        break;
      case "4":
        StudentManager.studentManager();
        break;
      default:
        UserOptions();
        break;
    }
  }
}

