using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThisIsTheMF
{
    public partial class Situation : Form
    {
        private static readonly List<string> Locations = new()
        {
            "Матфаке", "СоцГуме", "ФЭИ", "СОКе"
        };

        private Tuple<int, int> RequiredStat { get; } //Значение статы, Код статы
        //Коды стат:
        //0 - инта, 1 - красноречие, 2 - дерзость, 3 - сочувствие
        //Крч, идея такова:
        //У каждой миссии есть стата, которую нужно удовлетворить
        //( Стата студента не меньше требуемой )
        //Проверяем это, в зависимости от результата происходит что-либо
        //Фишки статов расписал в Map.cs

        public Situation()
        {
            InitializeComponent();
            var missionLocation = Locations[new Random().Next(0, Locations.Count)];
            RequiredStat = new Tuple<int, int>(new Random().Next(0, 8), new Random().Next(0,2));

            var missionDescriptions = new Dictionary<int, string>
            {
                //Описания - своего рода подсказки к требуемой стате
                [0] = $"Кто-нибудь понял последнюю тему и может её пояснить? Я жду в {missionLocation}.",
                [1] = $"Не могу сдать лабу, преподаватель отказывается меня слушать! Есть кто в {missionLocation}?",
                [2] = $"Дед снова за своё, так мы никогда не получим баллы! Нужно подкрепление в {missionLocation}."
            };
            
            var description = $"Хэй хэй, {Player.Name}! Нужна помощь! " + missionDescriptions[RequiredStat.Item2];
            descriptionText.Text = description;
            foreach (var student in Player.StudentsList)
            {
                MainStudentBox.Items.Add(student.Name);
            }

            MainStudentLabel.Text = "Основной студент";
            MainStudentLabel.Location = new Point(MainStudentLabel.Width/2,318-MainStudentLabel.Height*2);
            MainStudentBox.Location = new Point(MainStudentLabel.Width/2,MainStudentLabel.Bottom);
            SendTroops.Location = new Point(MainStudentBox.Right+SendTroops.Width,MainStudentLabel.Bottom);
            //Насрать на помощников, долго, нудно, забагованно. Мб потом.
            //HelperLabel.Text = "Студент-помощник";
            //HelperLabel.Location = new Point(MainStudentBox.Right, MainStudentLabel.Bottom);
            //HelperStudent.Location = new Point(HelperLabel.Size.Width / 2, HelperLabel.Bottom);
            ShowDialog();
        }

        private void MainStudentSelected(object sender, EventArgs e)
        {
            //Метод нахрен не нужен, но удалив его придётся разбираться с ошибками,
            //это недолго, но мне леееееень
            //_availableHelpers.Remove((Student)MainStudentBox.SelectedItem);
        }

        private void SendTroops_Click(object sender, EventArgs e)
        {
            var name = MainStudentBox.Text;
            if (Player.GetStudent(name).Stats[RequiredStat.Item2] >= RequiredStat.Item1)
            {
                MessageBox.Show("Красава, респект тебе и твоим работягам. Ещё сочтёмся!", "От души душевно в душу");
                Player.TakeReputation();
            }
            else
            {
                MessageBox.Show("Не, ну у меня бы в одиночку лучше вышло, теперь ещё больше проблем");
                Player.TakeDamage();
                Map.UpdateLabel();
            }
            Close();
        }
    }
}