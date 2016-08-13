using CodeFirstDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student s = new Student
            //{
            //    Name = "Siva",
            //    Standard = 10,
            //    Comments="Dont have any"
            //};

            //Student s1 = new Student
            //{
            //    Name="Bhavana",
            //    Standard=10,

            //};

            //Teacher t = new Teacher
            //{
            //    Name = "Siva",
            //    Students = new[] { s, s1 }
            //};

            //using (SchoolContext context = new SchoolContext())
            //{
            //    context.Students.Add(s);
            //    context.Students.Add(s1);
            //    context.SaveChanges();
            //    context.Teachers.Add(t);
            //    context.SaveChanges();
            //}

            using (SchoolContext context = new SchoolContext())
            {
                Console.WriteLine("Enter Sports Event Name");
                SportsEvent sp = new SportsEvent();
                sp.EventName = Console.ReadLine();
                sp.EventDate = DateTime.Now;
                sp.ParticipatingStudents = context.Students.ToList();
                context.SportsEvents.Add(sp);
                context.SaveChanges();
            }

        }
    }
}
