using System;
using System.Windows.Forms;

namespace ThisIsTheMF
{
    public partial class GameWindow : Form
    {
        public GameWindow()
        {
            InitializeComponent();
        }

        private void playerNameBox_Set(object sender, EventArgs e)
        {
            //Игрок вводит своё имя и выбирает сложность.
            //Появляется новое окно со списком доступных для выбора студентов.
            //Изначально можно выбрать максимум Четверых.
            //Студенты генерируются случайно.
        }
        
        private void gameStart_Click(object sender, EventArgs e)
        {
            if (gameCharName.Text is null or "Введите имя персонажа") return;
            var recruitsWindow = new RecruitsWindow();
            recruitsWindow.Show();
        }
    }
}