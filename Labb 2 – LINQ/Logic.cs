using Labb_2___LINQ.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Labb_2___LINQ
{
    public class Logic
    {
        public void PrintAllTeachersWhoTeachMathematics(Labb_2DbContext context)
        {
            var AllMathTeachers = (from MathTeachers in context.TeachersSubjects

                                   join Teachers in context.Teachers
                                   on MathTeachers.TeacherID equals Teachers.TeacherID

                                   join Subjects in context.Subjects
                                   on MathTeachers.SubjectID equals Subjects.SubjectID

                                   where Subjects.SubjectID == 3
                                   select new
                                   {
                                       TeacherFirstName = Teachers.TeacherFirstName,
                                       TeacherLastName = Teachers.TeacherLastName,
                                       TeacherGender = Teachers.TeacherGender,
                                       TeacherDateOfBirth = Teachers.TeacherDateOfBirth,
                                       SubjectName = Subjects.SubjectName
                                   }
                                   ).ToList();

            Console.WriteLine("The following teachers all teach mathematics:");
            Console.WriteLine();
            foreach (var mathTeachers in AllMathTeachers)
            {
                Console.WriteLine($"Teacher's first name: {mathTeachers.TeacherFirstName}. Teacher's last name: {mathTeachers.TeacherLastName}. Teacher’s gender: {mathTeachers.TeacherGender}. Teacher’s date of birth: {mathTeachers.TeacherDateOfBirth}. Teacher’s subject: {mathTeachers.SubjectName}.");
                Console.WriteLine();
            }

            Console.WriteLine("------Press any key to return to the main menu.------");
            Console.ReadKey();
        }



        public void PrintAllStudentsTogetherWithTheirTeachers(Labb_2DbContext context)
        {
            var AllStudentsWithTheirTeachers = (from StudentsTogetherWithTheirTeachers in context.StudentsTeachers

                                                join Students in context.Students
                                                on StudentsTogetherWithTheirTeachers.StudentID equals Students.StudentID

                                                join Teachers in context.Teachers
                                                on StudentsTogetherWithTheirTeachers.TeacherID equals Teachers.TeacherID

                                                select new
                                                {
                                                    StudentFirstName = Students.StudentFirstName,
                                                    StudentLastName = Students.StudentLastName,
                                                    StudentGender = Students.StudentGender,
                                                    StudentDateOfBirth = Students.StudentDateOfBirth,
                                                    StudentCourse = Students.Course.CourseName,

                                                    TeacherFirstName = Teachers.TeacherFirstName,
                                                    TeacherLastName = Teachers.TeacherLastName,
                                                    TeacherGender = Teachers.TeacherGender,
                                                    TeacherDateOfBirth = Teachers.TeacherDateOfBirth,
                                                }
                                                ).ToList();

            Console.WriteLine("The following shows all the students and their teachers:");
            Console.WriteLine();
            foreach (var studentsAndTheirTeachers in AllStudentsWithTheirTeachers)
            {
                Console.WriteLine($"Student's first name: ({studentsAndTheirTeachers.StudentFirstName}). Student's last name: ({studentsAndTheirTeachers.StudentLastName}). Student’s gender: ({studentsAndTheirTeachers.StudentGender}). Student’s date of birth: ({studentsAndTheirTeachers.StudentDateOfBirth}). Student’s course: ({studentsAndTheirTeachers.StudentCourse}).");

                Console.WriteLine($"({studentsAndTheirTeachers.StudentFirstName})'s teacher's first name: ({studentsAndTheirTeachers.TeacherFirstName}). ({studentsAndTheirTeachers.StudentFirstName})'s teacher's last name: ({studentsAndTheirTeachers.TeacherLastName}). ({studentsAndTheirTeachers.StudentFirstName})'s teacher’s gender: ({studentsAndTheirTeachers.TeacherGender}). ({studentsAndTheirTeachers.StudentFirstName})'s teacher’s date of birth: ({studentsAndTheirTeachers.TeacherDateOfBirth}).");

                Console.WriteLine();
            }

            Console.WriteLine("------Press any key to return to the main menu.------");
            Console.ReadKey();
        }



        public void CheckWhetherProgramming1IsAnAvailableSubjectOrNot(Labb_2DbContext context)
        {
            bool doesItExist = context.Subjects.Any(p1 => p1.SubjectName == "Programming 1");

            if (doesItExist == true)
            {
                Console.WriteLine("One of the available subjects is Programming 1.");
            }
            else
            {
                Console.WriteLine("Programming 1 is not an available subject!");
            }

            Console.WriteLine("------Press any key to return to the main menu.------");
            Console.ReadKey();
        }



        public void ChangeSubjectProgramming2ToOOP(Labb_2DbContext context)
        {
            var newSubject = (from NewSubject in context.Subjects where NewSubject.SubjectName == "Programming 2" select NewSubject);

            foreach (Subject ns in newSubject)
            {
                ns.SubjectName = "OOP";
            }
            Console.WriteLine("The subject Programming 2 has been successfully replaced by the new subject, OOP.");
            context.SaveChanges();

            Console.WriteLine("------Press any key to return to the main menu.------");
            Console.ReadKey();
        }



        public void ChangeTeacher(Labb_2DbContext context)
        {
            var changeTeacher = (from ChangeTeacher in context.StudentsTeachers where ChangeTeacher.StudentTeacherID == 1 select ChangeTeacher);

            foreach (StudentTeacher ct in changeTeacher)
            {
                ct.TeacherID = 3;
            }
            Console.WriteLine("The student’s teacher has been changed from Anas to Reidar.");
            context.SaveChanges();

            Console.WriteLine("------Press any key to return to the main menu.------");
            Console.ReadKey();
        }
    }
}
