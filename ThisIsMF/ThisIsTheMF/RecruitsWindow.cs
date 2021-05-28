using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ThisIsTheMF
{
    public partial class RecruitsWindow : Form
    {
        List<Student> studentsList = new();
        
        public RecruitsWindow()
        {
            //Меню выбора рекрутируемых студентов
            InitializeComponent();
            GenerateStudent();
            //studentsList.Add(new Student());
            //RecruitBox.Name = studentsList.Last().Name;
        }
        
        private void recruitStudent_Click(object sender, EventArgs e)
        {
            studentsList.Add(new Student());
            recruitsLimit.Text = (int.Parse(recruitsLimit.Text) - 1).ToString();
            if (int.Parse(recruitsLimit.Text) == 0)
            {
                Player.StudentsList = studentsList;
                var mapWindow = new Map();
                mapWindow.ShowDialog();
            }
            GenerateStudent();
        }

        private void generateStudentButton_Click(object sender, EventArgs e)
        {
            GenerateStudent();
        }

        private void GenerateStudent()
        {
            if(studentsList.Count != 0) studentsList.Remove(studentsList.Last());
            studentsList.Add(new Student());
            RecruitBox.Text = studentsList.Last().Name;
            knowledgeStat.Text = studentsList.Last().Stats[0].ToString();
            speakingStat.Text = studentsList.Last().Stats[1].ToString();
            proficiencyStat.Text = studentsList.Last().Stats[2].ToString();
            gutsStat.Text = studentsList.Last().Stats[3].ToString();
            kindnessStat.Text = studentsList.Last().Stats[4].ToString();
        }
        
    }
}