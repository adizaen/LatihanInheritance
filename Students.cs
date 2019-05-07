using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Students : Person
    {
        public string StudentId { get; set; }
        public string Email { get; set; }

        public Students(string name, int age, string studentid, string email) : base(name, age)
        {
            StudentId = studentid;
            Email = email;
        }
    }
}
