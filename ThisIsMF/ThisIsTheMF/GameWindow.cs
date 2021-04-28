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
            //Игрок вводит своё имя, появляется новое окно со списком доступных
            //для выбора студентов. Изначально можно выбрать Четверых.
            //Студенты генерируются случайно
            Player player = new Player(gameCharName.Text);
            
        }
    }
}