using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagementSystem
{

     class Application
    {
        public Classroom Classroom = new Classroom();

        public void RunProgram()
        {
            List<Student> students = Classroom.Students;
            int userChoice;

            do
            {
                userChoice = Menu.GetUserChoice();
                switch (userChoice)
                {
                    case 1:
                        Classroom.EnterListStudent(students);
                        break;
                    case 2:
                        Classroom.EnterSingleStudent(students);
                        break;
                    case 3:
                        Classroom.DisplayListStudent();
                        break;
                    case 4:
                        Classroom.SearchById(students);
                        break;
                    case 5:
                        Classroom.FindHighestGrade(students);
                        break;
                    case 6:
                        Classroom.FindLowestGrade(students);
                        break;
                    case 7:
                        students = students.OrderBy(a => a.Id).ToList();
                        Classroom.DisplayListStudent();
                        break;
                    case 8:
                        students = students.OrderBy(a => a.Grade).ToList();
                        Classroom.DisplayListStudent();
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
    }

}