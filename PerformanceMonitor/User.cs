using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceMonitor
{
    public abstract class User
    {
        public string Name { get; set; }
        public string Role { get; set; }
        private string Password { get; set; }

        public User(string Name, string Password, string Role)
        {
            this.Name = Name;
            this.Password = Password;
            this.Role = Role;
        }
    }
}
