using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetTraining.NamespaceDemo.Library
{
    public class Student
    {
        public Student():this(0,0)
        {
            //studentId = 0;
            //DepartmentId = 0;   
        }

        public Student(int deptId, int studentId)
        {
            this.studentId = studentId;
            DepartmentId = deptId;
        }
        private static int count = 0;

        public static void AddCount()
        {
            count++;
        }

        public static int GetCount()
        {
            return count;
        }

        /// <summary>
        /// This method allows student to take a book
        /// </summary>
        /// <param name="bookId">book id</param>
        /// <returns>true if succesfully taken the book or false otherwise</returns>
        public bool TakeBook(int bookId)
        {
            Console.WriteLine("Taking Book");
            return false;
        }

        

        internal bool ReturnBook(int id)
        {
            Console.WriteLine("Returning Book");
            return false;
        }

        internal bool ReturnBook()
        {
            return false;
        }

        private void PayFine(double amount)
        {
            Console.WriteLine("Paying Fine");

        }

        public int StudentId
        {
            get
            {
                //Console.WriteLine("get student Id");
                return studentId;
            }
            set
            {
                studentId = value;
            }
        }
        private int studentId;

        /// <summary>
        /// Auto properties
        /// </summary>
        public int DepartmentId {  set; get; }



        

        //private int departmentId;


    }
}
