
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
            this.descriptionText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.descriptionText.Location = new System.Drawing.Point(12, 9);
            this.descriptionText.MaximumSize = new System.Drawing.Size(500, 0);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(46, 45);
            this.descriptionText.TabIndex = 0;
            this.descriptionText.Text = "hi";
            // 
            // MainStudentBox
            // 
            this.MainStudentBox.FormattingEnabled = true;
            this.MainStudentBox.Location = new System.Drawing.Point(12, 57);
            this.MainStudentBox.Name = "MainStudentBox";
            this.MainStudentBox.Size = new System.Drawing.Size(121, 21);
            this.MainStudentBox.TabIndex = 1;
            this.MainStudentBox.SelectionChangeCommitted += new System.EventHandler(this.MainStudentSelected);
            // 
            // MainStudentLabel
            // 
            this.MainStudentLabel.Location = new System.Drawing.Point(12, 92);
            this.MainStudentLabel.Name = "MainStudentLabel";
            this.MainStudentLabel.Size = new System.Drawing.Size(100, 23);
            this.MainStudentLabel.TabIndex = 2;
            this.MainStudentLabel.Text = "label1";
            // 
            // HelperLabel
            // 
            this.HelperLabel.Location = new System.Drawing.Point(12, 115);
            this.HelperLabel.Name = "HelperLabel";
            this.HelperLabel.Size = new System.Drawing.Size(100, 23);
            this.HelperLabel.TabIndex = 3;
            this.HelperLabel.Text = "label1";
            this.HelperLabel.Visible = false;
            // 
            // HelperStudent
            // 
            this.HelperStudent.FormattingEnabled = true;
            this.HelperStudent.Location = new System.Drawing.Point(139, 57);
            this.HelperStudent.Name = "HelperStudent";
            this.HelperStudent.Size = new System.Drawing.Size(121, 21);
            this.HelperStudent.TabIndex = 4;
            this.HelperStudent.Visible = false;
            // 
            // SendTroops
            // 
            this.SendTroops.AutoSize = true;
            this.SendTroops.Location = new System.Drawing.Point(291, 136);
            this.SendTroops.Name = "SendTroops";
            this.SendTroops.Size = new System.Drawing.Size(120, 23);
            this.SendTroops.TabIndex = 5;
            this.SendTroops.Text = "Отправить бедолагу";
            this.SendTroops.UseVisualStyleBackColor = true;
            this.SendTroops.Click += new System.EventHandler(this.SendTroops_Click);
            // 
            // Situation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 289);
            this.Controls.Add(this.SendTroops);
            this.Controls.Add(this.HelperStudent);
            this.Controls.Add(this.HelperLabel);
            this.Controls.Add(this.MainStudentLabel);
            this.Controls.Add(this.MainStudentBox);
            this.Controls.Add(this.descriptionText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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