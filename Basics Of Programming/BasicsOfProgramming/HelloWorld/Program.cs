#region Namespace Imports

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotnetTraining.NamespaceDemo.Library;
#endregion

//Name Space Declaration
namespace HelloWorld
{
    // Class
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        // Methods (Main Method)
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.Read();

            int myFirstInteger;
            myFirstInteger = 10;
            Console.WriteLine(myFirstInteger);
            myFirstInteger = 20;
            Console.WriteLine(myFirstInteger);

            //const int myFirstConstantInteger = 10;
            //myFirstConstantInteger = 20;

            Television t = new Television();
            t.Display();

            Student student = new Student();
            student.DepartmentId = 10;
            student.StudentId = 1;
            Console.WriteLine(student.TakeBook(10));
            Student.AddCount();
            Console.WriteLine(Student.GetCount());

            Student student2 = new Student();
            Student.AddCount();
            student2.DepartmentId = 11;
            student2.StudentId = 2;
            Console.WriteLine(Student.GetCount());
            //Console.WriteLine(student.)

            int number = 5;
            MyNumber myNumber = new MyNumber(number);
            if(myNumber.IsEven())
            {
                Console.WriteLine("Even");
                Console.WriteLine(myNumber.GetSignalColorPremium());
            }
            else
            {
                Console.WriteLine("Odd");
            }

        }

        
    }
}
