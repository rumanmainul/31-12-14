using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmissionApp
{
    class Student
    {
        private string StudentName { get; set; }
       private string StudentRoll { get; set; }
       private string StudentDepartment { get; set; }


        public Student(string studentname, string roll, string department)
        {
            StudentName = studentname;
            StudentRoll = roll;
            StudentDepartment = department;
        }
    }
}
