using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ThisIsTheMF
{
    public partial class MainMenu : Form
    {
        public Player player;
        public Difficulty difficulty;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void trynaToEscape(object sender, FormClosingEventArgs e)
        {
            //if (titleLabel.Text != @"Аве Четверг!")
            //{
            //    const string message = "Думаешь, это так просто? Хрена с два";
            //    MessageBox.Show(message);
            //    e.Cancel = true;
            //}

        }

        private void startButton_Click(object sender, EventArgs e)
        {

            if (gameCharName.Text is null or "Введите имя персонажа" ||
                difficultyLevelBox.Text is null or "Выберите сложность") return;
            player = new Player(gameCharName.Text, 4);
            //difficulty.level = 10 / int.Parse(difficultyLevelBox.Text); 
            var recruitsWindow = new RecruitsWindow();
            recruitsWindow.Show();

            //Игрок вводит своё имя и выбирает сложность.
            //Появляется новое окно со списком доступных для выбора студентов.
            //Изначально можно выбрать максимум Четверых.
            //Студенты генерируются случайно.
            // чем больше уровень сложности, тем меньше значение, тем меньше даётся рекрутов на выбор
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
            titleLabel.Text = @"Аве Четверг!";
            exitButton.Location = new Point(12, 375);
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            if(titleLabel.Text != @"Аве Четверг!")
                exitButton.Location = new Point(new Random().Next(), 
                                                new Random().Next());
        }

        private void gameCharName_MouseDown(object sender, MouseEventArgs e)
        {
            gameCharName.Clear();
        }
    }
}