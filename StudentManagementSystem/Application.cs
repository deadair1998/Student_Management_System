using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagementSystem
{
  #region : Application :
  class Application
  {
    #region Methods...

    #region DisplayListStudent
    //Press 3 => Display a list of student
    public void DisplayListStudent(List<Student> students)
    {

      Console.WriteLine("|	ID	|	Grade	|");
      foreach (var student in students)
      {
        Console.WriteLine("|	{0}	|	{1}	|", student.Id, student.Grade);
      }
    }
    #endregion

    #region EnterListStudent
    //Press 1 => Enter a list of students
    public void EnterListStudent(List<Student> students)
    {

      Console.WriteLine("Enter a number of student: ");
      int number = int.Parse(Console.ReadLine());

      for (int i = 0; i < number; i++)
      {
        EnterSingleStudent(students);
      }
    }
    #endregion

    #region EnterSingleStudent
    //Press 2 => Enter a single student
    public void EnterSingleStudent(List<Student> students)
    {
      Console.WriteLine("Enter information of student from the keyboard.");
      int id = InputId(students);
      double grade = InputGrade();
      Student student = new Student(id, grade);
      students.Add(student);
    }
    #endregion

    #region FindHighestGrade
    // Press 5 => Find a student who has a highest grade
    public void FindHighestGrade(List<Student> students)
    {

      double highestGrade = 0;
      foreach (var student in students)
      {
        if (student.Grade > highestGrade)
        {
          highestGrade = student.Grade;
        }
      }
      Console.WriteLine("|	ID	|	Grade	|");
      foreach (var student in students)
      {
        if (student.Grade == highestGrade)
        {
          Console.WriteLine("|	{0}	|	{1}	|", student.Id, student.Grade);
        }
      }
    }
    #endregion

    #region FindLowestGrade
    //Press 6 => Find a student who has a lowest grade
    public void FindLowestGrade(List<Student> students)
    {

      double lowestGrade = 10;
      foreach (var student in students)
      {
        if (student.Grade < lowestGrade)
        {
          lowestGrade = student.Grade;
        }
      }
      Console.WriteLine("|	ID	|	Grade	|");
      foreach (var student in students)
      {
        if (student.Grade == lowestGrade)
        {
          Console.WriteLine("|	{0}	|	{1}	|", student.Id, student.Grade);
        }
      }
    }
    #endregion

    #region GetUserChoice
    public int GetUserChoice()
    {
      int choice;

      Console.WriteLine("==========STUDENT MANAGEMENT===========");
      Console.WriteLine("Choose one of the following options:");
      Console.WriteLine("Press 1. Enter a list of student.");
      Console.WriteLine("Press 2. Enter a single student into this list.");
      Console.WriteLine("Press 3. Display list of student. ");
      Console.WriteLine("Press 4. Search a student by ID.");
      Console.WriteLine("Press 5. Find student having the highest grades.");
      Console.WriteLine("Press 6. Find student having the lowest grades.");
      Console.WriteLine("Press 7. Sorting a list by ID.");
      Console.WriteLine("Press 8. Sorting a list by grade.");
      Console.WriteLine("Press 0. Exit");
      Console.WriteLine("=======================================");
      Console.WriteLine(" Enter choice (0 -> 5): ");

      choice = int.Parse(Console.ReadLine());
      return choice;
    }
    #endregion

    #region InputGrade
    //input Grade
    public double InputGrade()
    {
      double gradeTemp;
      do
      {
        Console.WriteLine("Enter student grade: ");
        gradeTemp = double.Parse(Console.ReadLine());
      } while (gradeTemp < 0 || gradeTemp > 10);
      return gradeTemp;
    }
    #endregion

    #region InputId
    //input ID
    public int InputId(List<Student> students)
    {
      int idTemp;
      bool isDuplicated;
      do
      {
        Console.WriteLine("Enter student ID: ");
        idTemp = int.Parse(Console.ReadLine());
        isDuplicated = IsIdDuplicated(students, idTemp);
        if (isDuplicated) Console.WriteLine("This Id is already in used, please enter another Id !!!");
      } while (idTemp < 100 || idTemp > 999 || isDuplicated == true);
      return idTemp;
    }
    #endregion

    #region IsIdDuplicated
    //check an entered ID is duplicated or not
    public bool IsIdDuplicated(List<Student> students, int idTemp)
    {
      foreach (var student in students)
      {
        if (student.Id == idTemp) return true;

      }
      return false;
    }
    #endregion

    #region RunProgram
    public void RunProgram()
    {
      int userChoice;
      List<Student> students = new List<Student>();
      do
      {
        userChoice = GetUserChoice();
        switch (userChoice)
        {
          case 1:
            EnterListStudent(students);
            break;
          case 2:
            EnterSingleStudent(students);
            break;
          case 3:
            DisplayListStudent(students);
            break;
          case 4:
            SearchById(students);
            break;
          case 5:
            FindHighestGrade(students);
            break;
          case 6:
            FindLowestGrade(students);
            break;
          case 7:
            students = students.OrderBy(a => a.Id).ToList();
            DisplayListStudent(students);
            break;
          case 8:
            students = students.OrderBy(a => a.Grade).ToList();
            DisplayListStudent(students);
            break;
          case 0:
            Console.WriteLine("Good bye, see you again :)))");
            break;
          default:
            Console.WriteLine("Invalid choice. Please input choice (0 -> 8).");
            break;
        }
      } while (userChoice != 0);

    }
    #endregion

    #region SearchById
    //Press 4 => Search a student by an ID
    public void SearchById(List<Student> students)
    {

      Console.WriteLine("Enter student ID: ");
      int id = int.Parse(Console.ReadLine());
      bool isFound = false;
      foreach (var student in students)
      {
        if (id == student.Id)
        {
          Console.WriteLine("Student has {0} ID has grade {1}", id, student.Grade);
          isFound = true;
        }
      }
      if (!isFound) Console.WriteLine("Can't find any student depend id : {0}", id);


    }
    #endregion

    #endregion
  }
  #endregion
}