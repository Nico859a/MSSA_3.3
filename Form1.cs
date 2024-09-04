using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3._3
{
    public partial class Form1 : Form
    {
        private List<StudentInfo> studentRepository = new List<StudentInfo>();
        public Form1()
        {
            InitializeComponent();
            PopulateMonthOfAdmissionComboBox();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            int studentID = int.Parse(tb_StudentID.Text);
            string firstName = tb_FirstName.Text;
            string lastName = tb_LastName.Text;
            string address = tb_Address.Text;
            MonthOfAdmission moOfAdmis = (MonthOfAdmission)cb_MonthOfAdmission.SelectedItem;
            char gradeToKeep = char.Parse(tb_GradeNeeded.Text);

            StudentInfo newStudent = new StudentInfo(studentID, firstName, lastName, address, moOfAdmis, gradeToKeep);

            studentRepository.Add(newStudent);
            RefreshGrid();
            ClearFields();

        }
        private void PopulateMonthOfAdmissionComboBox()
        {
            cb_MonthOfAdmission.DataSource = Enum.GetValues(typeof(MonthOfAdmission));
        }
        private void button1Delete_Click(object sender, EventArgs e)
        {
            int inputedStudentID = Int32.Parse(tb_StudentID.Text);
            var student = studentRepository.FirstOrDefault(s => s.StudentID == inputedStudentID);
            studentRepository.Remove(student);
            RefreshGrid();
            ClearFields();
        }
        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = studentRepository;
        }
        private void ClearFields()
        {
            tb_StudentID.Clear();
            tb_FirstName.Clear();
            tb_LastName.Clear();
            tb_Address.Clear();
            tb_GradeNeeded.Clear();
        }
        public enum MonthOfAdmission
        {
            January, February, March, April, May, June, July, August, September, October, November, December
        }
        public struct StudentInfo
        {

            private int _stuID;
            private string _firstName;
            private string _lastName;
            private string _address;
            private MonthOfAdmission _monthOfAdmisstion;
            private char _gradeToHold;

            public StudentInfo(int StudentID, string FirstName, string Lastname, string Address, MonthOfAdmission MoOfAdmission, char GradeToHold)
            {
                _stuID = StudentID;
                _firstName = FirstName;
                _lastName = Lastname;
                _address = Address;
                _monthOfAdmisstion = MoOfAdmission;
                _gradeToHold = GradeToHold;
            }
            public int StudentID
            { get { return _stuID; } set { _stuID = value; } }
            public string FirstName
            { get { return _firstName; } set { _firstName = value; } }
            public string LastName
            { get { return _lastName; } set { _lastName = value; } }
            public string Address
            { get { return _address; } set { _address = value; } }
            public MonthOfAdmission MonthOfAdmission
            { get { return _monthOfAdmisstion; } set { _monthOfAdmisstion = value; } }
            public char GradeToHold
            { get { return _gradeToHold; } set { _gradeToHold = value; } }
        }
    }
}

