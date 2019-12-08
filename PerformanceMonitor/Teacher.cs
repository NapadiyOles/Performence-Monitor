using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceMonitor
{
    public class Teacher : User
    {
        public string Subject { get; private set; }
        public Teacher(string Name, string Password, string Subject) : base(Name, Password, "teacher")
        {
            this.Subject = Subject;
        }

        public void SetMarks(string Number, int Marks, bool Visit)
        {
            GradeBook.AddMarks(Number, Marks, Visit, Subject);
        }
    }
}
