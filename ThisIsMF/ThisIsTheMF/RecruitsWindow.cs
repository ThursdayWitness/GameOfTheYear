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

        private void GenerateStat(string statName, GroupBox box)
        {
            var label = new Label
            {
                Name = $"{statName}" + Controls.Count,
                Text = studentsList.Last().Stats[0].ToString(),
                Location = new Point(box.Bottom, box.Left),
            };
        }
        
        private void GenerateStudentProfile(GroupBox recruitBox)
        {
            recruitBox.Text = studentsList.Last().Name;
            GenerateStat("knowledgeStat"+controlsCounter, recruitBox);
            GenerateStat("speakingStat"+controlsCounter, recruitBox);
            GenerateStat("proficiencyStat"+controlsCounter, recruitBox);
            GenerateStat("gutsStat"+controlsCounter, recruitBox);
            GenerateStat("kindnessStat"+controlsCounter, recruitBox);
            
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
                    Size = new Size(200,250), // изначально 125 на 219
                    Visible = true
                };
                recruitBox.Location = new Point(4 + controlsCounter * recruitBox.Width, 44); 
                //{ radioButton1, radioButton2, radioButton3 });
                
                //dynamicbutton.Click += new System.EventHandler(menuItem_Click);
                //Это полезно стырить, когда сделаем профили студентов кликабельными.
                recruitBox.Show();
                Controls.Add(recruitBox);
                controlsCounter++;
                studentsList.Add(new Student());
                GenerateStudentProfile(recruitBox);
                recruitBox.Controls.AddRange(new Control[]
                {
                    knowledgeLabel, speakingLabel, proficiencyLabel, gutsLabel, kindnessLabel,
                    knowledgeStat, speakingStat, proficiencyStat, gutsStat, kindnessStat
                });
                knowledgeStat.Location = new Point(knowledgeLabel.Right, knowledgeLabel.Top);
                speakingStat.Location = new Point(speakingLabel.Right, speakingLabel.Top);
                proficiencyStat.Location = new Point(proficiencyLabel.Right, proficiencyLabel.Top);
                gutsStat.Location = new Point(gutsLabel.Right, gutsLabel.Top);
                kindnessStat.Location = new Point(kindnessLabel.Right, kindnessLabel.Top);
                // Это вообще жесть, а не код, но пока хз, что с этим делать.
            }
        }
    }
}