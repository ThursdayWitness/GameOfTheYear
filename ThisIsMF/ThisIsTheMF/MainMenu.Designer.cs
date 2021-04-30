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
            ((System.ComponentModel.ISupportInitialize) (this.titleImage)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 375);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(139, 37);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 174);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(139, 37);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Начать игру";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // titleImage
            // 
            this.titleImage.Image = ((System.Drawing.Image) (resources.GetObject("titleImage.Image")));
            this.titleImage.ImageLocation = "";
            this.titleImage.Location = new System.Drawing.Point(210, 12);
            this.titleImage.Name = "titleImage";
            this.titleImage.Size = new System.Drawing.Size(578, 400);
            this.titleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titleImage.TabIndex = 2;
            this.titleImage.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.titleLabel.Location = new System.Drawing.Point(12, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(139, 130);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "This is the MathFK";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleImage);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.exitButton);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "ThisIsTheMathFK";
            ((System.ComponentModel.ISupportInitialize) (this.titleImage)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label titleLabel;

        private System.Windows.Forms.PictureBox titleImage;
        
        private System.Windows.Forms.Button startButton;

        private System.Windows.Forms.Button exitButton;

        #endregion
    }
}