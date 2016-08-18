using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Razordemo.Models
{
    public class Student
    {
        public int Id { set; get; }

        public string Name { set; get; }

        public string Standard { set; get; }

        public bool IsFeePaid { set; get; }

        public Gender Gender { set; get; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}