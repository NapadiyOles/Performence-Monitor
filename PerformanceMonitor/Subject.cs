using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceMonitor
{
    
    public static class Subject
    {
        private const string subjectListPath = @"data\subject_list.txt";

        public static List<string> Subjects { get; private set; }

        public static bool FillSubjectList()
        {
            Subjects = new List<string>();
            bool InfoExists = false;
            if (File.Exists(subjectListPath))
            {
                using (StreamReader reader = new StreamReader(subjectListPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        InfoExists = true;
                        Subjects.Add(line);
                    }
                }
            }
            return InfoExists;
        }

        public static void AddSubject(string subject)
        {
            using (StreamWriter writer = new StreamWriter(subjectListPath, true))
            {
                writer.WriteLine(subject);
                Subjects.Add(subject);
            }
            
            GradeBook.AddVoidNumbers();
        }

        public static void DeleteSubject(string subject)
        {
            int position = 0, counter = 0;
            string line;
            Subjects.Clear();
            using(StreamReader reader = new StreamReader(subjectListPath))
            {
                while((line = reader.ReadLine()) != null)
                {
                    if (line != subject)
                    {
                        counter++;
                        Subjects.Add(line);
                    }
                    else
                        position = counter;
                }
            }
            GradeBook.DeleteNumbers(position);
            using (StreamWriter writer = new StreamWriter(subjectListPath))
            {
                foreach(string Subject in Subjects)
                {
                    writer.WriteLine(Subject);
                }
            }
        }

        public static int GetPosition(string Subject)
        {
            string line;
            int counter = 0;
            using (StreamReader reader = new StreamReader(subjectListPath))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if (line != Subject)
                    {
                        counter++;
                    }
                    else
                        return counter;
                }
                return 0;
            }
        }

        public static bool SubjectExist(string subject)
        {
            foreach (string Subject in Subjects)
            {
                if (string.Equals(Subject, subject))
                    return true;
            }
            return false;
        }
    }
}
