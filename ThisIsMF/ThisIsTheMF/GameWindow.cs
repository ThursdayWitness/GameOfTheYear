using System;
using System.Windows.Forms;

namespace ThisIsTheMF
{
    public partial class GameWindow : Form
    {
        public Player player;
        public Difficulty difficulty;

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
            // чем больше уровень сложности, тем меньше значение, тем меньше даётся рекрутов на выбор
        }
        
        private void gameStart_Click(object sender, EventArgs e)
        {
            if (gameCharName.Text is null or "Введите имя персонажа" || 
                difficultyLevelBox.Text is null or "Выберите сложность") return;
            player = new Player(gameCharName.Text, 4 );
            //difficulty.level = 10 / int.Parse(difficultyLevelBox.Text); 
            var recruitsWindow = new RecruitsWindow();
            recruitsWindow.Show();
        }
    }
}