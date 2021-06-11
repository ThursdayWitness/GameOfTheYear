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
        public MainMenu()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TrynaToEscape(object sender, FormClosingEventArgs e)
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
                difficultyLevelBox.Text is null or "Выберите сложность")
            {
                MessageBox.Show(Text = "Имя и/или сложность не выбраны", Name = "Ошибка");
                return;
            }
            Player.Name = gameCharName.Text;
            Difficulty.SetLevel(difficultyLevelBox.Text); 
            new RecruitsWindow().ShowDialog();
            Close();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
            titleLabel.Text = @"Аве Четверг!";
            exitButton.Location = new Point(12, 375);
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            if(titleLabel.Text != @"Аве Четверг!")
                exitButton.Location = new Point(new Random().Next(0,250), 
                                                new Random().Next(0,250));
        }

        private void gameCharName_MouseDown(object sender, MouseEventArgs e)
        {
            gameCharName.Clear();
        }
    }
}