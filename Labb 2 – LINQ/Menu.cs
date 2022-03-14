using Labb_2___LINQ.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_2___LINQ
{
    public class Menu
    {
        public void MainMenu(Labb_2DbContext context)
        {
            Logic l = new Logic();

            bool loop = true;
            while (loop == true)
            {
                Console.Clear();
                Console.WriteLine("Input the number corresponding the choice you would like to make.");
                Console.WriteLine("(1) --- Print out all the teachers who teach mathematics.");
                Console.WriteLine("(2) --- Print out all the students together with their teachers.");
                Console.WriteLine("(3) --- Check whether Programming 1 is an available subject or not.");
                Console.WriteLine("(4) --- Change subject Programming 2 to OOP.");
                Console.WriteLine("(5) --- Change a student’s teacher from Anas to Reidar.");
                Console.WriteLine("(6) --- Close the application.");

                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        l.PrintAllTeachersWhoTeachMathematics(context);
                        break;

                    case "2":
                        l.PrintAllStudentsTogetherWithTheirTeachers(context);
                        break;

                    case "3":
                        l.CheckWhetherProgramming1IsAnAvailableSubjectOrNot(context);
                        break;

                    case "4":
                        l.ChangeSubjectProgramming2ToOOP(context);
                        break;

                    case "5":
                        l.ChangeTeacher(context);
                        break;

                    case "6":
                        loop = false;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
