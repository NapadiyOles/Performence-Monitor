using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceMonitor
{
    public class Student : User
    {
        public string Number { get; protected set; }
        public GradeBook gradeBook { get; protected set; }

        public Student(string Name, string Password, string Number) : base(Name, Password, "student")
        {
            this.Number = Number;
            gradeBook = new GradeBook(Number);
        }
    }
}
