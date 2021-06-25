using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ThisIsTheMF
{
    public partial class RecruitsWindow : Form
    {
        public static readonly Map Map = new();
        public readonly List<Student> StudentsList = new();
        private Student _currentStudent;
        public RecruitsWindow()
        {
            InitializeComponent();
            GenerateStudent();
        }
        
        private void recruitStudent_Click(object sender, EventArgs e)
        {
            StudentsList.Add(_currentStudent);
            Student.StudentNames.Remove(_currentStudent.Name);
            recruitsLimit.Text = (int.Parse(recruitsLimit.Text)-1).ToString();
            if (int.Parse(recruitsLimit.Text) == 0)
            {
                Player.StudentsList = StudentsList;
                Map.ShowDialog();
                Close();
            }
            GenerateStudent();
        }

        private void generateStudentButton_Click(object sender, EventArgs e)
        {
            GenerateStudent(); 
        }

        private void GenerateStudent()
        {
            _currentStudent = new Student();
            RecruitBox.Text = _currentStudent.Name;
            knowledgeStat.Text = _currentStudent.Stats[0].ToString();
            speakingStat.Text = _currentStudent.Stats[1].ToString();
            gutsStat.Text = _currentStudent.Stats[2].ToString();
            kindnessStat.Text = _currentStudent.Stats[3].ToString();
        }
    }
}