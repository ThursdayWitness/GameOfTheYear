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
        private int controlsCounter = 0;
        // инкремент-говно для работы расположения окошек студентов.
        // Может потом поправлю на что-нибудь умное, но пока плевать.



        public RecruitsWindow()
        {
            //Меню выбора рекрутируемых студентов
            InitializeComponent();
            GenerateStudentBox();
        }



        private void GenerateStudentProfile(GroupBox recruitBox)
        {
            recruitBox.Text = studentsList.Last().Name;
            var knowledgeStat = new Label
            {
                Name = "knowledgeStat" + Controls.Count,
                Text = studentsList.Last().Stats[0].ToString(),
                Location = new Point(recruitBox.Bottom, recruitBox.Left),
            };
            Controls.Add(knowledgeStat);

            speakingStat.Text = studentsList.Last().Stats[1].ToString();
            proficiencyStat.Text = studentsList.Last().Stats[2].ToString();
            gutsStat.Text = studentsList.Last().Stats[3].ToString();
            kindnessStat.Text = studentsList.Last().Stats[4].ToString();
            //TODO:
            // Вот это говно выше надо бы зарефакторить
            //И сделать генерацию сразу нескольких студентов, но тут проблема с созданием новых
            //элементов в окне, хотя не, так-то не проблема, только что понял, как это сделать.

        }

        private void GenerateStudentBox(int count = 4)
        {
            while (count > 0)
            {
                count--;
                var recruitBox = new GroupBox
                {
                    Name = "recruit" + controlsCounter,
                };
                //dynamicbutton.Click += new System.EventHandler(menuItem_Click);
                //Это полезно стырить, когда сделаем профили студентов кликабельными.
                recruitBox.Show();
                Controls.Add(recruitBox);
                controlsCounter++;
                studentsList.Add(new Student());
                GenerateStudentProfile(recruitBox);
            }
        }

        private void btnChoose_Click(object sender, System.EventArgs e)
        {
            var mapWindow = new Map();
            mapWindow.ShowDialog();
        }
    }
}