using System;
using System.Collections.Generic;

namespace StudentManagementSystem
{
	class Classroom
	{
		public List<Student> Students = new List<Student>();

		public void AddStudent(Student student)
		{
			Students.Add(student);
		}

		public void EnterListStudent(List<Student> students)
		{

			foreach (var student in students)
			{
				Students.Add(student);
			}
		}

		public void EnterSingleStudent(int id, double grade)
		{
			if (!IsIdDuplicated(id))
			{
				Student student = new Student(id, grade);
				Students.Add(student);
				Console.WriteLine("Succeed ...");
			}
			else
				Console.WriteLine("Failed...");
		}
		public bool IsIdDuplicated(int idTemp)
		{
			foreach (var student in Students)
			{
				if (student.Id == idTemp) return true;

			}
			return false;
		}

		public Student SearchById(int id)
		{
			foreach (var student in Students)
			{
				if (id == student.Id)
				{
					Console.WriteLine("Student has {0} ID has grade {1}", id, student.Grade);
					return student;
				}
			}
			return null;
		}

		public double FindHighestGrade()
		{
			double highestGrade = 0;
			foreach (var student in Students)
			{
				if (student.Grade > highestGrade)
				{
					highestGrade = student.Grade;
				}
			}
			return highestGrade;
		}
		public List<Student> GetAllHighestStudents(double highestGrade)
		{
			List<Student> listHighestGrade = new List<Student>();
			foreach (var student in Students)
			{
				if (student.Grade == highestGrade)
				{
					listHighestGrade.Add(student);
				}
			}
			return listHighestGrade;
		}

		public double FindLowestGrade()
		{
			double lowestGrade = 10;
			foreach (var student in Students)
			{
				if (student.Grade < lowestGrade)
				{
					lowestGrade = student.Grade;
				}
			}
			return lowestGrade;
		}
		public List<Student> GetAllLowestStudents(double highestGrade)
		{
			List<Student> listLowestGrade = new List<Student>();
			foreach (var student in Students)
			{
				if (student.Grade == highestGrade)
				{
					listLowestGrade.Add(student);
				}
			}
			return listLowestGrade;
		}
		public void SortIdAsc()
		{
			Student studentTemp;
			int i, j;
			for (i = 0; i < Students.Count; i++)
			{
				for (j = i + 1; j < Students.Count; j++)
				{
					if (Students[i].Id > Students[j].Id)
					{
						studentTemp = Students[i];
						Students[i] = Students[j];
						Students[j] = studentTemp;
					}
				}
			}
		}
		public void SortGradeAsc()
		{
			Student studentTemp;
			int i, j;
			for (i = 0; i < Students.Count; i++)
			{
				for (j = i + 1; j < Students.Count; j++)
				{
					if (Students[i].Grade > Students[j].Grade)
					{
						studentTemp = Students[i];
						Students[i] = Students[j];
						Students[j] = studentTemp;
					}
				}
			}
		}
		public void SortIdDes()
		{
			Student studentTemp;
			int i, j;
			for (i = 0; i < Students.Count; i++)
			{
				for (j = i + 1; j < Students.Count; j++)
				{
					if (Students[i].Id < Students[j].Id)
					{
						studentTemp = Students[i];
						Students[i] = Students[j];
						Students[j] = studentTemp;
					}
				}
			}
		}
		public void SortGradeDes()
		{
			Student studentTemp;
			int i, j;
			for (i = 0; i < Students.Count; i++)
			{
				for (j = i + 1; j < Students.Count; j++)
				{
					if (Students[i].Grade < Students[j].Grade)
					{
						studentTemp = Students[i];
						Students[i] = Students[j];
						Students[j] = studentTemp;
					}
				}
			}
		}
	}
}
