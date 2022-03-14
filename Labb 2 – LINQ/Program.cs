using Labb_2___LINQ.Models;
using System;

namespace Labb_2___LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            using Labb_2DbContext context = new Labb_2DbContext();

            Menu m = new Menu();
            m.MainMenu(context);

            //Course c1 = new Course()
            //{
            //    CourseName = "Class A"
            //};
            //context.Add(c1);

            //Course c2 = new Course()
            //{
            //    CourseName = "Class B"
            //};
            //context.Add(c2);

            //Course c3 = new Course()
            //{
            //    CourseName = "Class C"
            //};
            //context.Add(c3);



            //Subject su1 = new Subject()
            //{
            //    SubjectName = "Programming 1"
            //};
            //context.Add(su1);

            //Subject su2 = new Subject()
            //{
            //    SubjectName = "Programming 2"
            //};
            //context.Add(su2);

            //Subject su3 = new Subject()
            //{
            //    SubjectName = "Mathematics 2"
            //};
            //context.Add(su3);

            //Subject su4 = new Subject()
            //{
            //    SubjectName = "English 6"
            //};
            //context.Add(su4);



            //Teacher t1 = new Teacher()
            //{
            //    TeacherFirstName = "Anas",
            //    TeacherLastName = "A",
            //    TeacherGender = "Male",
            //    TeacherDateOfBirth = new DateTime(1985, 05, 20),
            //};
            //context.Add(t1);

            //Teacher t2 = new Teacher()
            //{
            //    TeacherFirstName = "Tobias",
            //    TeacherLastName = "L",
            //    TeacherGender = "Male",
            //    TeacherDateOfBirth = new DateTime(1985, 03, 24),
            //};
            //context.Add(t2);

            //Teacher t3 = new Teacher()
            //{
            //    TeacherFirstName = "Reidar",
            //    TeacherLastName = "R",
            //    TeacherGender = "Male",
            //    TeacherDateOfBirth = new DateTime(1975, 07, 15),
            //};
            //context.Add(t3);



            //Student st1 = new Student()
            //{
            //    StudentFirstName = "Daniel",
            //    StudentLastName = "Gyrén",
            //    StudentGender = "Male",
            //    StudentDateOfBirth = new DateTime(1997, 01, 04),
            //    Course = c1,
            //};
            //context.Add(st1);

            //Student st2 = new Student()
            //{
            //    StudentFirstName = "Sofia",
            //    StudentLastName = "Anderson",
            //    StudentGender = "Female",
            //    StudentDateOfBirth = new DateTime(1997, 10, 21),
            //    Course = c1
            //};
            //context.Add(st2);

            //Student st3 = new Student()
            //{
            //    StudentFirstName = "Amanda",
            //    StudentLastName = "Gustafson",
            //    StudentGender = "Female",
            //    StudentDateOfBirth = new DateTime(1998, 02, 28),
            //    Course = c2
            //};
            //context.Add(st3);

            //Student st4 = new Student()
            //{
            //    StudentFirstName = "Alexander",
            //    StudentLastName = "Nilsson",
            //    StudentGender = "Male",
            //    StudentDateOfBirth = new DateTime(1998, 06, 25),
            //    Course = c2
            //};
            //context.Add(st4);

            //Student st5 = new Student()
            //{
            //    StudentFirstName = "Sara",
            //    StudentLastName = "Larsson",
            //    StudentGender = "Female",
            //    StudentDateOfBirth = new DateTime(1999, 11, 30),
            //    Course = c3
            //};
            //context.Add(st5);



            //StudentSubject ss1 = new StudentSubject()
            //{
            //    Student = st1,
            //    Subject = su1
            //};
            //context.Add(ss1);

            //StudentSubject ss2 = new StudentSubject()
            //{
            //    Student = st1,
            //    Subject = su2
            //};
            //context.Add(ss2);


            //StudentSubject ss3 = new StudentSubject()
            //{
            //    Student = st2,
            //    Subject = su3
            //};
            //context.Add(ss3);

            //StudentSubject ss4 = new StudentSubject()
            //{
            //    Student = st2,
            //    Subject = su4
            //};
            //context.Add(ss4);


            //StudentSubject ss5 = new StudentSubject()
            //{
            //    Student = st3,
            //    Subject = su2
            //};
            //context.Add(ss5);

            //StudentSubject ss6 = new StudentSubject()
            //{
            //    Student = st3,
            //    Subject = su4
            //};
            //context.Add(ss6);


            //StudentSubject ss7 = new StudentSubject()
            //{
            //    Student = st4,
            //    Subject = su1
            //};
            //context.Add(ss7);

            //StudentSubject ss8 = new StudentSubject()
            //{
            //    Student = st4,
            //    Subject = su4
            //};
            //context.Add(ss8);


            //StudentSubject ss9 = new StudentSubject()
            //{
            //    Student = st5,
            //    Subject = su2
            //};
            //context.Add(ss9);

            //StudentSubject ss10 = new StudentSubject()
            //{
            //    Student = st5,
            //    Subject = su3
            //};
            //context.Add(ss10);


            //TeacherSubject ts1 = new TeacherSubject()
            //{
            //    Teacher = t1,
            //    Subject = su1,
            //};
            //context.Add(ts1);

            //TeacherSubject ts2 = new TeacherSubject()
            //{
            //    Teacher = t1,
            //    Subject = su2,
            //};
            //context.Add(ts2);

            //TeacherSubject ts3 = new TeacherSubject()
            //{
            //    Teacher = t2,
            //    Subject = su3,
            //};
            //context.Add(ts3);

            //TeacherSubject ts4 = new TeacherSubject()
            //{
            //    Teacher = t2,
            //    Subject = su4,
            //};
            //context.Add(ts4);

            //TeacherSubject ts5 = new TeacherSubject()
            //{
            //    Teacher = t3,
            //    Subject = su2,
            //};
            //context.Add(ts5);

            //TeacherSubject ts6 = new TeacherSubject()
            //{
            //    Teacher = t3,
            //    Subject = su3,
            //};
            //context.Add(ts6);

            //TeacherSubject ts7 = new TeacherSubject()
            //{
            //    Teacher = t3,
            //    Subject = su4,
            //};
            //context.Add(ts7);



            // context.SaveChanges();
        }
    }
}
