namespace ThisIsTheMF
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.exitButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.titleImage = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.difficultyLevelBox = new System.Windows.Forms.ComboBox();
            this.gameCharName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.titleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(14, 490);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(162, 48);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.exitButton_MouseEnter);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(14, 228);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(162, 48);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Начать игру";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // titleImage
            // 
            this.titleImage.Image = ((System.Drawing.Image)(resources.GetObject("titleImage.Image")));
            this.titleImage.ImageLocation = "";
            this.titleImage.Location = new System.Drawing.Point(221, 16);
            this.titleImage.Margin = new System.Windows.Forms.Padding(4);
            this.titleImage.Name = "titleImage";
            this.titleImage.Size = new System.Drawing.Size(674, 522);
            this.titleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titleImage.TabIndex = 2;
            this.titleImage.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(14, 16);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(162, 170);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "This is the MathFK";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // difficultyLevelBox
            // 
            this.difficultyLevelBox.FormattingEnabled = true;
            this.difficultyLevelBox.Items.AddRange(new object[] {
            "Легко",
            "Ничё так",
            "Сложно"});
            this.difficultyLevelBox.Location = new System.Drawing.Point(14, 318);
            this.difficultyLevelBox.Margin = new System.Windows.Forms.Padding(4);
            this.difficultyLevelBox.Name = "difficultyLevelBox";
            this.difficultyLevelBox.Size = new System.Drawing.Size(153, 25);
            this.difficultyLevelBox.TabIndex = 5;
            this.difficultyLevelBox.Text = "Выберите сложность";
            // 
            // gameCharName
            // 
            this.gameCharName.Location = new System.Drawing.Point(14, 284);
            this.gameCharName.Margin = new System.Windows.Forms.Padding(4);
            this.gameCharName.Name = "gameCharName";
            this.gameCharName.Size = new System.Drawing.Size(153, 25);
            this.gameCharName.TabIndex = 4;
            this.gameCharName.Text = "Введите имя игрока";
            this.gameCharName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gameCharName_MouseDown);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.difficultyLevelBox);
            this.Controls.Add(this.gameCharName);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleImage);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "ThisIsTheMathFK";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TrynaToEscape);
            ((System.ComponentModel.ISupportInitialize)(this.titleImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label titleLabel;

        private System.Windows.Forms.PictureBox titleImage;
        
        private System.Windows.Forms.Button startButton;

        private System.Windows.Forms.Button exitButton;

        #endregion
        private System.Windows.Forms.ComboBox difficultyLevelBox;
        private System.Windows.Forms.TextBox gameCharName;
    }
}