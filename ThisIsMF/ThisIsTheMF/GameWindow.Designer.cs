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
            this.SuspendLayout();
            // 
            // gameCharName
            // 
            this.gameCharName.Location = new System.Drawing.Point(304, 110);
            this.gameCharName.Name = "gameCharName";
            this.gameCharName.Size = new System.Drawing.Size(100, 20);
            this.gameCharName.TabIndex = 0;
            this.gameCharName.TextChanged += new System.EventHandler(this.playerNameBox_Set);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameCharName);
            this.Name = "GameWindow";
            this.Text = "gameWindow";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox gameCharName;

        #endregion
    }
}