using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagementSystem
{
    class Program
    {
		static int inputId(List<Student> students)
		{
			int idTmp;
			bool checkIdStatus;
			do
			{
				Console.WriteLine("Enter student ID: ");
				idTmp = int.Parse(Console.ReadLine());
				checkIdStatus = checkIdDuplicate(students, idTmp);
				if (checkIdStatus) Console.WriteLine("This Id is already in used, please enter another Id !!!");
			} while (idTmp < 100 || idTmp > 999 || checkIdStatus == true);
			return idTmp;
		}
		static double inputGrade()
		{
			double gradeTmp;
			do
			{
				Console.WriteLine("Enter student grade: ");
				gradeTmp = double.Parse(Console.ReadLine());
			} while (gradeTmp < 0 || gradeTmp > 10);
			return gradeTmp;
		}
		static bool checkIdDuplicate(List<Student> students, int idTmp)
		{
            foreach (var student in students)
            {
				if (student.id == idTmp) return true;

			}
			return false;
		}
		static void enterListStudent(List<Student> students)
		{
			
			Console.WriteLine("Enter a number of student: ");
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				enterSingleStudent(students);
			}
		}
		static void enterSingleStudent(List<Student> students)
		{
			Console.WriteLine("Enter information of student from the keyboard.");
			int id = inputId(students);
			double grade = inputGrade();
			Student student = new Student(id, grade);
			students.Add(student);
		}
		static void searchById(List<Student> students)
		{
			
			Console.WriteLine("Enter student ID: ");
			int id = int.Parse(Console.ReadLine());
			bool isFinded = false;
			foreach (var student in students)
			{
				if (id == student.id)
				{
					Console.WriteLine("Student has {0} ID has grade {1}", id, student.grade);
					isFinded = true;
				}
			}
			if (!isFinded) Console.WriteLine("Can't find any student depend id : {0}", id);


		}
		static void findHighestGrade(List<Student> students)
		{

			double highestGrade = 0;
			foreach(var student in students)
			{
				if(student.grade > highestGrade)
				{
					highestGrade = student.grade;
				}
			}
			Console.WriteLine("|	ID	|	Grade	|");
			foreach (var student in students)
			{
				if(student.grade == highestGrade)
				{
					Console.WriteLine("|	{0}	|	{1}	|", student.id, student.grade);
				}
			}
			//var max = student.Max(s => s.Marks);
			//var studentsWithMaxMark = student.Where(s => s.Marks == max);
			//var names = String.Join(",", studentsWithMaxMark.Select(s => s.Name);
		}
		static void findLowestGrade(List<Student> students)
		{

			double lowestGrade = 10;
			foreach (var student in students)
			{
				if (student.grade < lowestGrade)
				{
					lowestGrade = student.grade;
				}
			}
			Console.WriteLine("|	ID	|	Grade	|");
			foreach (var student in students)
			{
				if (student.grade == lowestGrade)
				{
					Console.WriteLine("|	{0}	|	{1}	|", student.id, student.grade);
				}
			}
		}
		static void displayListStudent(List<Student> students)
		{
			
			Console.WriteLine("|	ID	|	Grade	|");
			foreach (var student in students)
			{
				Console.WriteLine("|	{0}	|	{1}	|", student.id, student.grade);
			}
		}
		static int getUserChoice()
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
		static void Main(string[] args)
        {
			int userChoice;
			List<Student> students = new List<Student>();
			do
			{
				userChoice = getUserChoice(); 
				switch(userChoice)
				{
					case 1:
						enterListStudent(students);
						break;
					case 2:
						enterSingleStudent(students);
						break;
					case 3:
						displayListStudent(students);
						break;
					case 4:
						searchById(students);
						break;
					case 5:
						findHighestGrade(students);
						break;
					case 6:
						findLowestGrade(students);
						break;
					case 7:
						students = students.OrderBy(a => a.id).ToList();
						displayListStudent(students);
						break;
					case 8:
						students = students.OrderBy(a => a.grade).ToList();
						displayListStudent(students);
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
