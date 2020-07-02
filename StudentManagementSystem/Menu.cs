using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
	class Menu
	{
		public static int GetUserChoice()
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
			Console.WriteLine("Press 7. Sorting a list by ID in ascending order.");
			Console.WriteLine("Press 8. Sorting a list by grade in ascending order.");
			Console.WriteLine("Press 9. Sorting a list by ID in descending order.");
			Console.WriteLine("Press 10. Sorting a list by grade in descending order.");
			Console.WriteLine("=======================================");
			Console.WriteLine(" Enter choice (0 -> 10): ");

			choice = int.Parse(Console.ReadLine());
			return choice;
		}

		public static double InputGrade()
		{
			double gradeTemp;
			do
			{
				Console.WriteLine("Enter student grade: ");
				gradeTemp = double.Parse(Console.ReadLine());
			} while (gradeTemp < 0 || gradeTemp > 10);
			return gradeTemp;
		}

		public static int InputId()
		{
			int idTemp;
			do
			{
				Console.WriteLine("Enter student ID: ");
				idTemp = int.Parse(Console.ReadLine());
			} while (idTemp < 100 || idTemp > 999);
			return idTemp;
		}

		public static List<Student> GetStudents(int studentNumber)
		{
			List<Student> students = new List<Student>();
			int id;
			double grade;
			for (int i = 0; i < studentNumber; i++)
			{
				id = InputId();
				foreach (var student in students)
				{
					while (students.Find(x => x.Id.Equals(id)) != null)
					{
						Console.WriteLine("Duplicate ID! Please try again!");
						id = InputId();
					}
				}
				grade = InputGrade();
				students.Add(new Student(id, grade));
			}
			return students;
		}
		public static void PrintInfo(Student student)
		{
			Console.WriteLine("ID: {0}, Grade: {1}", student.Id, student.Grade);
		}
		public static void DisplayListStudent(List<Student> students)
		{

			Console.WriteLine("|	ID	|	Grade	|");
			foreach (var student in students)
			{
				Console.WriteLine("|	{0}	|	{1}	|", student.Id, student.Grade);
			}
		}

	}
}
