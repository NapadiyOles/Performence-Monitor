using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceMonitor
{
    public class GradeBook
    {
        private const string studentDataPath = "data/student_data.txt";

        private List<int> marks;
        private List<int> visits;
        public GradeBook(string Number)
        {
            using (StreamReader reader = new StreamReader(studentDataPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Substring(0, Number.Length) == Number)
                    {
                        FillFeelds(line);
                        break;
                    }
                }
            }
        }

        public static void AddGradeBook(string Number)
        {
            using (StreamWriter writer = new StreamWriter(studentDataPath, true))
            {
                writer.Write($"{Number}");
                for (int i = 0; i < Subject.Subjects.Count; i++)
                {
                    writer.Write(";0;0");
                }
                writer.WriteLine();
            }
        }

        public static void DeleteGradeBook(string Number)
        {
            List<string> lines = new List<string>();
            using (StreamReader reader = new StreamReader(studentDataPath))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    if (line.Substring(0, Number.Length) != Number)
                        lines.Add(line);
                }
            }
            using(StreamWriter writer = new StreamWriter(studentDataPath))
            {
                foreach(string line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }

        private void FillFeelds(string line)
        {
            string[] info = line.Split(';');

            marks = new List<int>();
            visits = new List<int>();

            for (int i = 1; i < info.Length; i++)
            {
                marks.Add(int.Parse(info[i++]));
                visits.Add(int.Parse(info[i]));
            }
        }

        public static void AddVoidNumbers()
        {
            if (Admin.usersAlreadyExists("student"))
            {
                List<string> lines = new List<string>();
                using (StreamReader reader = new StreamReader(studentDataPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        line += ";0;0";
                        lines.Add(line);
                    }
                }
                using(StreamWriter writer = new StreamWriter(studentDataPath))
                {
                    foreach(string line in lines)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
        }

        public static void DeleteNumbers(int Position)
        {
            if (Admin.usersAlreadyExists("student"))
            {
                List<string> lines = new List<string>();
                List<string> info = new List<string>();
                using (StreamReader reader = new StreamReader(studentDataPath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        line.Remove(Position * 4 + 6, 4);
                        lines.Add(line);
                    }
                }
                using (StreamWriter writer = new StreamWriter(studentDataPath))
                {
                    foreach (string line in lines)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
        }

        public List<Tuple<string, int, int>> GetFullInfo()
        {
            int i = 0;
            List<Tuple<string, int, int>> FullInfo = new List<Tuple<string, int, int>>();
            foreach (string subject in Subject.Subjects)
            {
                FullInfo.Add(Tuple.Create(subject, marks[i], visits[i++]));
            }
            return FullInfo;
        }

        public Tuple<int, int> GetSubjectInfo(string subject)
        {
            int i = 0;
            foreach (string mySubject in Subject.Subjects)
            {
                if (mySubject == subject)   
                {
                    return new Tuple<int, int>(marks[i], visits[i]);
                }
                else { i++; }
            }
            return null;
        }

        public static void AddMarks(string Number, int Mark, bool Visit, string subject)
        {
            List<string> lines = new List<string>();
            using (StreamReader reader = new StreamReader(studentDataPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if(line.Substring(0, Number.Length) == Number)
                    {
                        string[] info = line.Split(';');
                        int Position = (Subject.GetPosition(subject) * 2) + 1;

                        int mark = int.Parse(info[Position]) + Mark;
                        if (mark < 0)
                            mark = 0;
                        else if (mark > 100)
                            mark = 100;
                        info[Position] = mark.ToString();

                        if (Visit)
                            info[++Position] = (int.Parse(info[Position]) + 1).ToString();

                        line = info[0];
                        for (int i = 1; i < info.Length; i++)
                            line += $";{info[i]}";
                    }
                    lines.Add(line);
                }
            }
            using(StreamWriter writer = new StreamWriter(studentDataPath))
            {
                foreach(string line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }
        public static Tuple<string, string> GetSubjectInfo(string subject, string Number)
        {
            using (StreamReader reader = new StreamReader(studentDataPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Substring(0, Number.Length) == Number)
                    {
                        string[] info = line.Split(';');
                        int Position = (Subject.GetPosition(subject) * 2) + 1;

                        return Tuple.Create(info[Position++], info[Position]);
                    }
                }
            }
            return null;

        }
    }
}
