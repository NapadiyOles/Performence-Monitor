using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceMonitor
{
    public class Admin : User
    {
        /// <summary>
        /// Path to txt file with list of all users
        /// </summary>
        private const string userPath = @"data\users.txt";

        /// <summary>
        /// Searching for users by name
        /// </summary>
        /// <param name="Name">The key of searching</param>
        /// <returns>
        /// If true -> all user info
        /// If false -> null
        /// </returns>
        /// 

        public static bool UserFileExist()
        {
            return File.Exists(userPath);
        }

        public static void WriteDefaultAdmin()
        {
            if (!Directory.Exists("data"))
                Directory.CreateDirectory("data");
            using (StreamWriter writer = new StreamWriter(userPath))
            {
                writer.WriteLine("admin;adminadmin;admin;-");
            }
        }

        public static Tuple<string, string, string> Check(string Name)
        {
            using (StreamReader reader = new StreamReader(userPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] info = line.Split(';');
                    if (info[0] == Name)
                    {
                        return Tuple.Create<string, string, string>(info[1], info[2], info[3]);
                    }
                }
                return null;
            }
        }

        public static bool numberAlreadyExist(string Number)
        {
            using (StreamReader reader = new StreamReader(userPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] info = line.Split(';');
                    if (info[3] == Number)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public static bool usersAlreadyExists(string Role)
        {
            using (StreamReader reader = new StreamReader(userPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] info = line.Split(';');
                    if (info[2] == Role)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        //TODO: Закінчити клас Admin
        //Методи: Видалення предметів, (Дадавання студентів, Видалення студентів, Додавання викладачів, Видалення викладачів)
        public Admin(string Name, string Password) : base(Name, Password, "admin") { }

        public bool AddNewUser(string Name, string Password, string Role, string Addings)
        {
            string line;
            using(StreamReader reader = new StreamReader(userPath))
            {
                while((line = reader.ReadLine()) != null)
                {
                    if (line.Substring(0, Name.Length) == Name)
                        return false;
                }
            }
            using(StreamWriter writer = new StreamWriter(userPath, true))
            {
                writer.WriteLine($"{Name};{Password};{Role};{Addings}");
            }

            if (Role == "teacher")
                Subject.AddSubject(Addings);
            else
                GradeBook.AddGradeBook(Addings);

            return true;
        }

        public static void ChangeUser(string OldName, string Name, string Password, string Role, string Addings)
        {
            List<string> lines = new List<string>();

            using (StreamReader reader = new StreamReader(userPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
            }

            using (StreamWriter writer = new StreamWriter(userPath))
            {
                foreach (string line in lines)
                {
                    if (line.Substring(0, OldName.Length) == OldName)
                        writer.WriteLine($"{Name};{Password};{Role};{Addings}");
                    else
                        writer.WriteLine(line);
                }
            }
        }

        public bool DeleteUser(string Name, string Role, string Addings)
        {
            bool UserFound = false;
            List<string> lines = new List<string>();
            using (StreamReader reader = new StreamReader(userPath))
            {
                string line;
                while ((line = reader.ReadLine())!= null)
                {
                    string[] info = line.Split(';');
                    if (info[0] == Name && info[3] == Addings)
                        UserFound = true;
                    else
                        lines.Add(line);
                }
            }
            if (!UserFound)
                return false;

            using (StreamWriter writer = new StreamWriter(userPath))
            {
                foreach(string line in lines)
                {
                    writer.WriteLine(line);
                }
            }


            if (Role == "teacher")
                Subject.DeleteSubject(Addings);
            else
                GradeBook.DeleteGradeBook(Addings);

            return true;
        }
        
    }
}
