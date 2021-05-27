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
            this.RecruitBox = new System.Windows.Forms.GroupBox();
            this.kindnessStat = new System.Windows.Forms.Label();
            this.gutsStat = new System.Windows.Forms.Label();
            this.proficiencyStat = new System.Windows.Forms.Label();
            this.speakingStat = new System.Windows.Forms.Label();
            this.knowledgeStat = new System.Windows.Forms.Label();
            this.kindnessLabel = new System.Windows.Forms.Label();
            this.knowledgeLabel = new System.Windows.Forms.Label();
            this.gutsLabel = new System.Windows.Forms.Label();
            this.speakingLabel = new System.Windows.Forms.Label();
            this.proficiencyLabel = new System.Windows.Forms.Label();
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
            this.RecruitBox.Controls.Add(this.proficiencyStat);
            this.RecruitBox.Controls.Add(this.speakingStat);
            this.RecruitBox.Controls.Add(this.knowledgeStat);
            this.RecruitBox.Controls.Add(this.kindnessLabel);
            this.RecruitBox.Controls.Add(this.knowledgeLabel);
            this.RecruitBox.Controls.Add(this.gutsLabel);
            this.RecruitBox.Controls.Add(this.speakingLabel);
            this.RecruitBox.Controls.Add(this.proficiencyLabel);
            this.RecruitBox.Location = new System.Drawing.Point(12, 12);
            this.RecruitBox.Name = "RecruitBox";
            this.RecruitBox.Size = new System.Drawing.Size(125, 219);
            this.RecruitBox.TabIndex = 0;
            this.RecruitBox.TabStop = false;
            this.RecruitBox.Text = "студентнейм";
            // 
            // kindnessStat
            // 
            this.kindnessStat.Location = new System.Drawing.Point(95, 193);
            this.kindnessStat.Name = "kindnessStat";
            this.kindnessStat.Size = new System.Drawing.Size(24, 23);
            this.kindnessStat.TabIndex = 9;
            this.kindnessStat.Text = "0";
            // 
            // gutsStat
            // 
            this.gutsStat.Location = new System.Drawing.Point(95, 170);
            this.gutsStat.Name = "gutsStat";
            this.gutsStat.Size = new System.Drawing.Size(24, 23);
            this.gutsStat.TabIndex = 8;
            this.gutsStat.Text = "0";
            // 
            // proficiencyStat
            // 
            this.proficiencyStat.Location = new System.Drawing.Point(95, 147);
            this.proficiencyStat.Name = "proficiencyStat";
            this.proficiencyStat.Size = new System.Drawing.Size(24, 23);
            this.proficiencyStat.TabIndex = 7;
            this.proficiencyStat.Text = "0";
            // 
            // speakingStat
            // 
            this.speakingStat.Location = new System.Drawing.Point(95, 124);
            this.speakingStat.Name = "speakingStat";
            this.speakingStat.Size = new System.Drawing.Size(24, 23);
            this.speakingStat.TabIndex = 6;
            this.speakingStat.Text = "0";
            // 
            // knowledgeStat
            // 
            this.knowledgeStat.Location = new System.Drawing.Point(95, 101);
            this.knowledgeStat.Name = "knowledgeStat";
            this.knowledgeStat.Size = new System.Drawing.Size(24, 23);
            this.knowledgeStat.TabIndex = 5;
            this.knowledgeStat.Text = "0";
            // 
            // kindnessLabel
            // 
            this.kindnessLabel.Location = new System.Drawing.Point(6, 193);
            this.kindnessLabel.Name = "kindnessLabel";
            this.kindnessLabel.Size = new System.Drawing.Size(100, 23);
            this.kindnessLabel.TabIndex = 4;
            this.kindnessLabel.Text = "Сочувствие";
            // 
            // knowledgeLabel
            // 
            this.knowledgeLabel.Location = new System.Drawing.Point(6, 101);
            this.knowledgeLabel.Name = "knowledgeLabel";
            this.knowledgeLabel.Size = new System.Drawing.Size(100, 23);
            this.knowledgeLabel.TabIndex = 0;
            this.knowledgeLabel.Text = "Ум";
            // 
            // gutsLabel
            // 
            this.gutsLabel.Location = new System.Drawing.Point(6, 170);
            this.gutsLabel.Name = "gutsLabel";
            this.gutsLabel.Size = new System.Drawing.Size(100, 23);
            this.gutsLabel.TabIndex = 3;
            this.gutsLabel.Text = "Дерзость";
            // 
            // speakingLabel
            // 
            this.speakingLabel.Location = new System.Drawing.Point(6, 124);
            this.speakingLabel.Name = "speakingLabel";
            this.speakingLabel.Size = new System.Drawing.Size(100, 23);
            this.speakingLabel.TabIndex = 1;
            this.speakingLabel.Text = "Красноречие";
            // 
            // proficiencyLabel
            // 
            this.proficiencyLabel.Location = new System.Drawing.Point(6, 147);
            this.proficiencyLabel.Name = "proficiencyLabel";
            this.proficiencyLabel.Size = new System.Drawing.Size(100, 23);
            this.proficiencyLabel.TabIndex = 2;
            this.proficiencyLabel.Text = "Смекалка";
            // 
            // recruitStudent
            // 
            this.recruitStudent.Location = new System.Drawing.Point(156, 108);
            this.recruitStudent.Name = "recruitStudent";
            this.recruitStudent.Size = new System.Drawing.Size(83, 23);
            this.recruitStudent.TabIndex = 1;
            this.recruitStudent.Text = "Завербовать";
            this.recruitStudent.UseVisualStyleBackColor = true;
            this.recruitStudent.Click += new System.EventHandler(this.recruitStudent_Click);
            // 
            // generateStudentButton
            // 
            this.generateStudentButton.Location = new System.Drawing.Point(156, 194);
            this.generateStudentButton.Name = "generateStudentButton";
            this.generateStudentButton.Size = new System.Drawing.Size(83, 34);
            this.generateStudentButton.TabIndex = 2;
            this.generateStudentButton.Text = "Несите нового";
            this.generateStudentButton.UseVisualStyleBackColor = true;
            this.generateStudentButton.Click += new System.EventHandler(this.generateStudentButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(143, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ещё можно взять:";
            // 
            // recruitsLimit
            // 
            this.recruitsLimit.Location = new System.Drawing.Point(178, 31);
            this.recruitsLimit.Name = "recruitsLimit";
            this.recruitsLimit.Size = new System.Drawing.Size(20, 23);
            this.recruitsLimit.TabIndex = 4;
            this.recruitsLimit.Text = "4";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(143, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Бесполезных куска студента";
            // 
            // RecruitsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 248);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recruitsLimit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateStudentButton);
            this.Controls.Add(this.recruitStudent);
            this.Controls.Add(this.RecruitBox);
            this.Name = "RecruitsWindow";
            this.Text = "RecruitsWindow";
            this.RecruitBox.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label recruitsLimit;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label recruitsLimitLabel;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button generateStudentButton;
        private System.Windows.Forms.Button recruitStudent;

        private System.Windows.Forms.GroupBox RecruitBox;

        private System.Windows.Forms.Label knowledgeStat;
        private System.Windows.Forms.Label speakingStat;
        private System.Windows.Forms.Label proficiencyStat;
        private System.Windows.Forms.Label gutsStat;
        private System.Windows.Forms.Label kindnessStat;
        private System.Windows.Forms.Label kindnessLabel;
        private System.Windows.Forms.Label gutsLabel;
        private System.Windows.Forms.Label proficiencyLabel;
        private System.Windows.Forms.Label speakingLabel;
        private System.Windows.Forms.Label knowledgeLabel;
        #endregion

        private System.Windows.Forms.Button btnChoose;
    }
}