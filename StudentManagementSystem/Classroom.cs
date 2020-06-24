using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem
{
    class Classroom
    {
        public List<Student> Students = new List<Student>();

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

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void EnterListStudent(List<Student> students)
        {

            Console.WriteLine("Enter a number of student: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                EnterSingleStudent(students);
            }
        }

        public void EnterSingleStudent(List<Student> students)
        {
            Console.WriteLine("Enter information of student from the keyboard.");
            int id = InputId(students);
            double grade = InputGrade();
            Student student = new Student(id, grade);
            students.Add(student);
        }

        public void DisplayListStudent()
        {

            Console.WriteLine("|	ID	|	Grade	|");
            foreach (var student in Students)
            {
                Console.WriteLine("|	{0}	|	{1}	|", student.Id, student.Grade);
            }
        }

        public bool IsIdDuplicated(List<Student> students, int idTemp)
        {
            foreach (var student in students)
            {
                if (student.Id == idTemp) return true;

            }
            return false;
        }

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
    }
}
