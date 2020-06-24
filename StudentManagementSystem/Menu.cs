using System;
using System.Collections.Generic;
using System.Text;

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
            Console.WriteLine("Press 7. Sorting a list by ID.");
            Console.WriteLine("Press 8. Sorting a list by grade.");
            Console.WriteLine("Press 0. Exit");
            Console.WriteLine("=======================================");
            Console.WriteLine(" Enter choice (0 -> 5): ");

            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
