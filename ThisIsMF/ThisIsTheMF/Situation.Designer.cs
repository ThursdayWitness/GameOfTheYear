
namespace ThisIsTheMF
{
    partial class Situation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.descriptionText = new System.Windows.Forms.Label();
            this.MainStudentBox = new System.Windows.Forms.ComboBox();
            this.MainStudentLabel = new System.Windows.Forms.Label();
            this.HelperLabel = new System.Windows.Forms.Label();
            this.HelperStudent = new System.Windows.Forms.ComboBox();
            this.SendTroops = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionText
            // 
            this.descriptionText.AutoSize = true;
            this.descriptionText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionText.Location = new System.Drawing.Point(14, 12);
            this.descriptionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionText.MaximumSize = new System.Drawing.Size(583, 0);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(49, 48);
            this.descriptionText.TabIndex = 0;
            this.descriptionText.Text = "hi";
            // 
            // MainStudentBox
            // 
            this.MainStudentBox.FormattingEnabled = true;
            this.MainStudentBox.Location = new System.Drawing.Point(14, 75);
            this.MainStudentBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainStudentBox.Name = "MainStudentBox";
            this.MainStudentBox.Size = new System.Drawing.Size(140, 25);
            this.MainStudentBox.TabIndex = 1;
            this.MainStudentBox.SelectionChangeCommitted += new System.EventHandler(this.MainStudentSelected);
            // 
            // MainStudentLabel
            // 
            this.MainStudentLabel.Location = new System.Drawing.Point(14, 120);
            this.MainStudentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MainStudentLabel.Name = "MainStudentLabel";
            this.MainStudentLabel.Size = new System.Drawing.Size(117, 30);
            this.MainStudentLabel.TabIndex = 2;
            this.MainStudentLabel.Text = "label1";
            // 
            // HelperLabel
            // 
            this.HelperLabel.Location = new System.Drawing.Point(14, 150);
            this.HelperLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HelperLabel.Name = "HelperLabel";
            this.HelperLabel.Size = new System.Drawing.Size(117, 30);
            this.HelperLabel.TabIndex = 3;
            this.HelperLabel.Text = "label1";
            this.HelperLabel.Visible = false;
            // 
            // HelperStudent
            // 
            this.HelperStudent.FormattingEnabled = true;
            this.HelperStudent.Location = new System.Drawing.Point(162, 75);
            this.HelperStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HelperStudent.Name = "HelperStudent";
            this.HelperStudent.Size = new System.Drawing.Size(140, 25);
            this.HelperStudent.TabIndex = 4;
            this.HelperStudent.Visible = false;
            // 
            // SendTroops
            // 
            this.SendTroops.AutoSize = true;
            this.SendTroops.Location = new System.Drawing.Point(466, 282);
            this.SendTroops.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SendTroops.Name = "SendTroops";
            this.SendTroops.Size = new System.Drawing.Size(140, 30);
            this.SendTroops.TabIndex = 5;
            this.SendTroops.Text = "Отправить бедолагу";
            this.SendTroops.UseVisualStyleBackColor = true;
            this.SendTroops.Click += new System.EventHandler(this.SendTroops_Click);
            // 
            // Situation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 378);
            this.Controls.Add(this.SendTroops);
            this.Controls.Add(this.HelperStudent);
            this.Controls.Add(this.HelperLabel);
            this.Controls.Add(this.MainStudentLabel);
            this.Controls.Add(this.MainStudentBox);
            this.Controls.Add(this.descriptionText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Situation";
            this.Text = "Situation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button SendTroops;

        private System.Windows.Forms.Label MainStudentLabel;

        private System.Windows.Forms.Label HelperLabel;
        private System.Windows.Forms.ComboBox HelperStudent;

        private System.Windows.Forms.ComboBox MainStudentBox;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Label descriptionText;

        private System.Windows.Forms.Label anchorLabel;

        #endregion

        private System.Windows.Forms.Label label1;
    }
}