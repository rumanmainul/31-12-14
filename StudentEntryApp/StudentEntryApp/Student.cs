using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEntryApp
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string RegNo { set; get; }

        public Student(string name, string email, string regN0)
        {
            Name = name;
            Email = email;
            RegNo = regN0;
        }
    }
}
