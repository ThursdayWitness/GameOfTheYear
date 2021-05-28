namespace ThisIsTheMF
{
    partial class Map
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            this.dialogEvent = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelNews = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelStudents = new System.Windows.Forms.Panel();
            this.pictureMap = new System.Windows.Forms.PictureBox();
            this.timerEvent = new System.Windows.Forms.Timer(this.components);
            this.timerStartSession = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dialogEvent)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelNews.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMap)).BeginInit();
            this.SuspendLayout();
            // 
            // dialogEvent
            // 
            this.dialogEvent.BackColor = System.Drawing.Color.Transparent;
            this.dialogEvent.Image = ((System.Drawing.Image)(resources.GetObject("dialogEvent.Image")));
            this.dialogEvent.Location = new System.Drawing.Point(561, 137);
            this.dialogEvent.Name = "dialogEvent";
            this.dialogEvent.Size = new System.Drawing.Size(160, 160);
            this.dialogEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dialogEvent.TabIndex = 5;
            this.dialogEvent.TabStop = false;
            this.dialogEvent.Click += new System.EventHandler(this.dialogEvent_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(184)))), ((int)(((byte)(127)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(275, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 56);
            this.panel1.TabIndex = 9;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(184)))), ((int)(((byte)(127)))));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(361, -1);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(47, 56);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(126, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "#";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Неделя";
            // 
            // panelNews
            // 
            this.panelNews.Controls.Add(this.label3);
            this.panelNews.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNews.Location = new System.Drawing.Point(1187, 0);
            this.panelNews.Name = "panelNews";
            this.panelNews.Size = new System.Drawing.Size(236, 719);
            this.panelNews.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 204);
            this.label3.TabIndex = 0;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // panelStudents
            // 
            this.panelStudents.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStudents.Location = new System.Drawing.Point(0, 0);
            this.panelStudents.Name = "panelStudents";
            this.panelStudents.Size = new System.Drawing.Size(235, 719);
            this.panelStudents.TabIndex = 7;
            // 
            // pictureMap
            // 
            this.pictureMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureMap.Image = ((System.Drawing.Image)(resources.GetObject("pictureMap.Image")));
            this.pictureMap.Location = new System.Drawing.Point(0, 0);
            this.pictureMap.Name = "pictureMap";
            this.pictureMap.Size = new System.Drawing.Size(1423, 719);
            this.pictureMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMap.TabIndex = 6;
            this.pictureMap.TabStop = false;
            // 
            // timerEvent
            // 
            this.timerEvent.Interval = 1000;
            // 
            // timerStartSession
            // 
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 719);
            this.Controls.Add(this.dialogEvent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelNews);
            this.Controls.Add(this.panelStudents);
            this.Controls.Add(this.pictureMap);
            this.Name = "Map";
            this.Text = "Map";
            ((System.ComponentModel.ISupportInitialize)(this.dialogEvent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelNews.ResumeLayout(false);
            this.panelNews.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dialogEvent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelNews;
        private System.Windows.Forms.Panel panelStudents;
        private System.Windows.Forms.PictureBox pictureMap;
        private System.Windows.Forms.Timer timerEvent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerStartSession;
    }
}