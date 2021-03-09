using System;
public static class StudentManager{
//Get student name and grade from console input
//Able to handle any number of students
//Display all students names and grades once the user finishes adding students
  public static void studentManager()
  {
    string name = "";
    int grade = 0; 
  
    Console.WriteLine("How many students do you want to add?:");

    int numberOfRecords = int.Parse(Console.ReadLine());
    string[] studentRecords = new string[numberOfRecords];

    ExceptionHandler exceptionHandler = new ExceptionHandler();

    for(int i = 0; i <= studentRecords.Length-1; i++)
    {
      Console.WriteLine("Please enter the student {0} name:", (i+1));
      name = exceptionHandler.TryAgain();

      Console.WriteLine("Please enter the student {0} grade:", (i+1));
      grade = int.Parse(exceptionHandler.TryAgain());

      studentRecords[i] = $"name: {name}, Grade: {grade}";
    }

    for(int i = 0; i <= studentRecords.Length-1; i++)
    {
      Console.WriteLine("Student Record {0}: {1}", (i+1), studentRecords[i]);
    }
  }
}