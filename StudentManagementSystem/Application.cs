using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{

	class Application
	{
		public Classroom Classroom = new Classroom();

		public void RunProgram()
		{
			List<Student> students = new List<Student>() {
			new Student()};
			int userChoice;
			int id = 0;
			do
			{
				userChoice = Menu.GetUserChoice();
				switch (userChoice)
				{
					case 1: // Enter a list Student
						Console.WriteLine("Enter number of students");
						int numberStudents = int.Parse(Console.ReadLine());
						Classroom.EnterListStudent(Menu.GetStudents(numberStudents));
						break;
					case 2: // Enter a Single student
						id = Menu.InputId();
						while (Classroom.IsIdDuplicated(id))
						{
							Console.WriteLine("Duplicate ID! Please try again!");
							id = Menu.InputId();
						}
						double grade = Menu.InputGrade();
						Classroom.EnterSingleStudent(id, grade);
						break;
					case 3: // Display a list Student
						Menu.DisplayListStudent(Classroom.Students);
						break;
					case 4: //  Search student by ID
						id = Menu.InputId();
						var studentToFind = Classroom.SearchById(id);
						if (studentToFind != null) Menu.PrintInfo(studentToFind);
						else Console.WriteLine("Not Found...");
						break;
					case 5: //Print all students have the highest grade
						double highestGrade = Classroom.FindHighestGrade();
						Menu.DisplayListStudent(Classroom.GetAllHighestStudents(highestGrade));
						break;
					case 6: //Print all students have the lowest grade
						double lowestGrade = Classroom.FindLowestGrade();
						Menu.DisplayListStudent(Classroom.GetAllLowestStudents(lowestGrade));
						break;
					case 7: //Sort a list by IDs in the ascending order
						Classroom.SortIdAsc();
						Menu.DisplayListStudent(Classroom.Students);
						break;
					case 8: //Sort a list by grades in the ascending order
						Classroom.SortGradeAsc();
						Menu.DisplayListStudent(Classroom.Students);
						break;
					case 9: //Sort a list by IDs in the descending order
						Classroom.SortIdDes();
						Menu.DisplayListStudent(Classroom.Students);
						break;
					case 10: //Sort a list by grades in the descending order
						Classroom.SortGradeDes();
						Menu.DisplayListStudent(Classroom.Students);
						break;
					case 0: //Exit
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