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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ActiveForm?.Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            
            var gameWindow = new GameWindow();
            gameWindow.Show();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
            titleLabel.Text = @"Аве Четверг!";
        }
    }
}