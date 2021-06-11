using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ThisIsTheMF
{
    public partial class RecruitsWindow : Form
    {
        List<Student> studentsList = new();
        private Student _currentStudent;
        public RecruitsWindow()
        {
            //Меню выбора рекрутируемых студентов
            InitializeComponent();
            GenerateStudent();
        }
        
        private void recruitStudent_Click(object sender, EventArgs e)
        {
            studentsList.Add(_currentStudent);
            Student._studentNames.Remove(_currentStudent.Name);
            recruitsLimit.Text = (int.Parse(recruitsLimit.Text)-1).ToString();
            if (int.Parse(recruitsLimit.Text) == 0)
            {
                //studentsList.Remove(studentsList.Last());
                //Из-за какого-то косяка в коде, добавляется лишний студент, как будет время - исправим адекватно. Пока так.
                Player.StudentsList = studentsList;
                new Map().ShowDialog();
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
            //if (studentsList.Count != 0) studentsList.Remove(studentsList.Last());
            _currentStudent = new Student();
            RecruitBox.Text = _currentStudent.Name;
            knowledgeStat.Text = _currentStudent.Stats[0].ToString();
            speakingStat.Text = _currentStudent.Stats[1].ToString();
            gutsStat.Text = _currentStudent.Stats[2].ToString();
            kindnessStat.Text = _currentStudent.Stats[3].ToString();
        }
    }
}