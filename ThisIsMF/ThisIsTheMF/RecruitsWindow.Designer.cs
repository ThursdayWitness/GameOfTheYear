using System.ComponentModel;

namespace ThisIsTheMF
{
    partial class RecruitsWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecruitsWindow));
            this.RecruitBox = new System.Windows.Forms.GroupBox();
            this.kindnessStat = new System.Windows.Forms.Label();
            this.gutsStat = new System.Windows.Forms.Label();
            this.speakingStat = new System.Windows.Forms.Label();
            this.knowledgeStat = new System.Windows.Forms.Label();
            this.kindnessLabel = new System.Windows.Forms.Label();
            this.knowledgeLabel = new System.Windows.Forms.Label();
            this.gutsLabel = new System.Windows.Forms.Label();
            this.speakingLabel = new System.Windows.Forms.Label();
            this.recruitStudent = new System.Windows.Forms.Button();
            this.generateStudentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.recruitsLimit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RecruitBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecruitBox
            // 
            this.RecruitBox.Controls.Add(this.kindnessStat);
            this.RecruitBox.Controls.Add(this.gutsStat);
            this.RecruitBox.Controls.Add(this.speakingStat);
            this.RecruitBox.Controls.Add(this.knowledgeStat);
            this.RecruitBox.Controls.Add(this.kindnessLabel);
            this.RecruitBox.Controls.Add(this.knowledgeLabel);
            this.RecruitBox.Controls.Add(this.gutsLabel);
            this.RecruitBox.Controls.Add(this.speakingLabel);
            this.RecruitBox.Location = new System.Drawing.Point(14, 16);
            this.RecruitBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RecruitBox.Name = "RecruitBox";
            this.RecruitBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RecruitBox.Size = new System.Drawing.Size(146, 286);
            this.RecruitBox.TabIndex = 0;
            this.RecruitBox.TabStop = false;
            this.RecruitBox.Text = "студентнейм";
            // 
            // kindnessStat
            // 
            this.kindnessStat.Location = new System.Drawing.Point(111, 252);
            this.kindnessStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kindnessStat.Name = "kindnessStat";
            this.kindnessStat.Size = new System.Drawing.Size(28, 30);
            this.kindnessStat.TabIndex = 9;
            this.kindnessStat.Text = "0";
            // 
            // gutsStat
            // 
            this.gutsStat.Location = new System.Drawing.Point(111, 222);
            this.gutsStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gutsStat.Name = "gutsStat";
            this.gutsStat.Size = new System.Drawing.Size(28, 30);
            this.gutsStat.TabIndex = 8;
            this.gutsStat.Text = "0";
            // 
            // speakingStat
            // 
            this.speakingStat.Location = new System.Drawing.Point(111, 192);
            this.speakingStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.speakingStat.Name = "speakingStat";
            this.speakingStat.Size = new System.Drawing.Size(28, 30);
            this.speakingStat.TabIndex = 6;
            this.speakingStat.Text = "0";
            // 
            // knowledgeStat
            // 
            this.knowledgeStat.Location = new System.Drawing.Point(111, 162);
            this.knowledgeStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.knowledgeStat.Name = "knowledgeStat";
            this.knowledgeStat.Size = new System.Drawing.Size(28, 30);
            this.knowledgeStat.TabIndex = 5;
            this.knowledgeStat.Text = "0";
            // 
            // kindnessLabel
            // 
            this.kindnessLabel.Location = new System.Drawing.Point(7, 252);
            this.kindnessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kindnessLabel.Name = "kindnessLabel";
            this.kindnessLabel.Size = new System.Drawing.Size(117, 30);
            this.kindnessLabel.TabIndex = 4;
            this.kindnessLabel.Text = "Сочувствие";
            // 
            // knowledgeLabel
            // 
            this.knowledgeLabel.Location = new System.Drawing.Point(7, 162);
            this.knowledgeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.knowledgeLabel.Name = "knowledgeLabel";
            this.knowledgeLabel.Size = new System.Drawing.Size(117, 30);
            this.knowledgeLabel.TabIndex = 0;
            this.knowledgeLabel.Text = "Ум";
            // 
            // gutsLabel
            // 
            this.gutsLabel.Location = new System.Drawing.Point(7, 222);
            this.gutsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gutsLabel.Name = "gutsLabel";
            this.gutsLabel.Size = new System.Drawing.Size(117, 30);
            this.gutsLabel.TabIndex = 3;
            this.gutsLabel.Text = "Дерзость";
            // 
            // speakingLabel
            // 
            this.speakingLabel.Location = new System.Drawing.Point(7, 192);
            this.speakingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.speakingLabel.Name = "speakingLabel";
            this.speakingLabel.Size = new System.Drawing.Size(117, 30);
            this.speakingLabel.TabIndex = 1;
            this.speakingLabel.Text = "Красноречие";
            // 
            // recruitStudent
            // 
            this.recruitStudent.Location = new System.Drawing.Point(182, 141);
            this.recruitStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.recruitStudent.Name = "recruitStudent";
            this.recruitStudent.Size = new System.Drawing.Size(97, 30);
            this.recruitStudent.TabIndex = 1;
            this.recruitStudent.Text = "Завербовать";
            this.recruitStudent.UseVisualStyleBackColor = true;
            this.recruitStudent.Click += new System.EventHandler(this.recruitStudent_Click);
            // 
            // generateStudentButton
            // 
            this.generateStudentButton.Location = new System.Drawing.Point(182, 254);
            this.generateStudentButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generateStudentButton.Name = "generateStudentButton";
            this.generateStudentButton.Size = new System.Drawing.Size(97, 44);
            this.generateStudentButton.TabIndex = 2;
            this.generateStudentButton.Text = "Несите нового";
            this.generateStudentButton.UseVisualStyleBackColor = true;
            this.generateStudentButton.Click += new System.EventHandler(this.generateStudentButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(167, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ещё можно взять:";
            // 
            // recruitsLimit
            // 
            this.recruitsLimit.Location = new System.Drawing.Point(208, 41);
            this.recruitsLimit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.recruitsLimit.Name = "recruitsLimit";
            this.recruitsLimit.Size = new System.Drawing.Size(23, 30);
            this.recruitsLimit.TabIndex = 4;
            this.recruitsLimit.Text = "4";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(167, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 47);
            this.label2.TabIndex = 5;
            this.label2.Text = "Бесполезных куска студента";
            // 
            // RecruitsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 324);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recruitsLimit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateStudentButton);
            this.Controls.Add(this.recruitStudent);
            this.Controls.Add(this.RecruitBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RecruitsWindow";
            this.Text = "RecruitsWindow";
            this.RecruitBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label recruitsLimit;

        private System.Windows.Forms.Label label2;
        
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button generateStudentButton;
        private System.Windows.Forms.Button recruitStudent;

        private System.Windows.Forms.GroupBox RecruitBox;

        private System.Windows.Forms.Label knowledgeStat;
        private System.Windows.Forms.Label speakingStat;
        private System.Windows.Forms.Label gutsStat;
        private System.Windows.Forms.Label kindnessStat;
        private System.Windows.Forms.Label kindnessLabel;
        private System.Windows.Forms.Label gutsLabel;
        private System.Windows.Forms.Label speakingLabel;
        private System.Windows.Forms.Label knowledgeLabel;
        #endregion
    }
}