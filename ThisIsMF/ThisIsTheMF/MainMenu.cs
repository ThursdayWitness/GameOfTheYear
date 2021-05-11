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

        private void trynaToEscape(object sender, FormClosingEventArgs e)
        {
            if (titleLabel.Text != @"Аве Четверг!")
            {
                const string message = "Думаешь, это так просто? Хрена с два";
                MessageBox.Show(message);
                e.Cancel = true;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            
            var gameWindow = new GameWindow();
            gameWindow.Show();
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
    }
}