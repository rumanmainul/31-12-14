using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEntryApp
{
    class Department
    {
        public string Code { private set; get; }
        public string DepartmentName { private set; get; }
        private List<Student> studentsList;

        public Department(string code, string deapartment):this()
        {
            Code = code;
            DepartmentName = deapartment;
           
        }

        public Department()
        {
            studentsList = new List<Student>();
        }

        public string AddStudent(Student objStudent)
        {
            if (studentsList.Count <= 2)
            {
                if (HasStudentReg(objStudent.RegNo))
                {
                    return "Student AllReady Added";
                }
                studentsList.Add(objStudent);
                return "Add Student";
            }
            else
            {
                return "Overflow";
            }
        }

        private bool HasStudentReg(string reg)
        {
            foreach (Student studentReg in studentsList)
            {
                if (studentReg.RegNo == reg)
                {
                    return true;
                }
            }
            return false;
        }

        public Student[] GetStudents()
        {
            return studentsList.ToArray();
        }
    }
}
