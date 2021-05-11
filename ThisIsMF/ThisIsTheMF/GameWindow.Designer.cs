using System.ComponentModel;

namespace ThisIsTheMF
{
    partial class GameWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameCharName = new System.Windows.Forms.TextBox();
            this.difficultyLevelBox = new System.Windows.Forms.ComboBox();
            this.gameStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameCharName
            // 
            this.gameCharName.Location = new System.Drawing.Point(12, 12);
            this.gameCharName.Name = "gameCharName";
            this.gameCharName.Size = new System.Drawing.Size(132, 20);
            this.gameCharName.TabIndex = 0;
            this.gameCharName.Text = "Введите имя игрока";
            // 
            // difficultyLevelBox
            // 
            this.difficultyLevelBox.FormattingEnabled = true;
            this.difficultyLevelBox.Items.AddRange(new object[] {"Легко", "Ничё так", "Сложно"});
            this.difficultyLevelBox.Location = new System.Drawing.Point(12, 38);
            this.difficultyLevelBox.Name = "difficultyLevelBox";
            this.difficultyLevelBox.Size = new System.Drawing.Size(132, 21);
            this.difficultyLevelBox.TabIndex = 1;
            this.difficultyLevelBox.Text = "Выберите сложность";
            // 
            // gameStart
            // 
            this.gameStart.Location = new System.Drawing.Point(63, 65);
            this.gameStart.Name = "gameStart";
            this.gameStart.Size = new System.Drawing.Size(81, 23);
            this.gameStart.TabIndex = 2;
            this.gameStart.Text = "Ну допустим";
            this.gameStart.UseVisualStyleBackColor = true;
            this.gameStart.Click += new System.EventHandler(this.gameStart_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameStart);
            this.Controls.Add(this.difficultyLevelBox);
            this.Controls.Add(this.gameCharName);
            this.Name = "GameWindow";
            this.Text = "ThisIsTheMathFK";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox difficultyLevelBox;

        private System.Windows.Forms.Button gameStart;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.TextBox gameCharName;

        #endregion
    }
}