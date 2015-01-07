using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEntryApp
{
    public partial class StudentEntryUI : Form
    {
        public StudentEntryUI()
        {
            InitializeComponent();
        }

        private Department aDepartment;
        private void save_Department_Button_Click(object sender, EventArgs e)
        {
            aDepartment = new Department(codeTextBox.Text, departmentTextBox.Text);
            MessageBox.Show("Department Created");
        }

        private void Student_Save_Button_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student(nameTextBox.Text, emailTextBox.Text, rollTextBox.Text);
            string alert = aDepartment.AddStudent(aStudent);
            MessageBox.Show(alert);
        }

        private void ShowDetails_Button_Click(object sender, EventArgs e)
        {
            string DepartmentInfo = aDepartment.DepartmentName + " " + aDepartment.Code+"\n";
            string preRoows = "Name \t RegNO \t Email \n";
            foreach (Student aStudent in aDepartment.GetStudents())
            {
                string studentRow = aStudent.Name + "\t " + aStudent.RegNo + "\t " + aStudent.Email+"\n";
                preRoows += studentRow;
            }
            MessageBox.Show(DepartmentInfo + "" + preRoows);
        }

    }
}
