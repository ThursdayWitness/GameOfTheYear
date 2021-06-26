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
            this.panelStudents = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureMap = new System.Windows.Forms.PictureBox();
            this.timerEvent = new System.Windows.Forms.Timer(this.components);
            this.timerStartSession = new System.Windows.Forms.Timer(this.components);
            this.panelNews = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dialogEvent)).BeginInit();
            this.panelStudents.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMap)).BeginInit();
            this.SuspendLayout();
            // 
            // dialogEvent
            // 
            this.dialogEvent.BackColor = System.Drawing.Color.Transparent;
            this.dialogEvent.Image = ((System.Drawing.Image)(resources.GetObject("dialogEvent.Image")));
            this.dialogEvent.Location = new System.Drawing.Point(393, 182);
            this.dialogEvent.Name = "dialogEvent";
            this.dialogEvent.Size = new System.Drawing.Size(160, 160);
            this.dialogEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dialogEvent.TabIndex = 5;
            this.dialogEvent.TabStop = false;
            this.dialogEvent.Click += new System.EventHandler(this.dialogEvent_Click);
            // 
            // panelStudents
            // 
            this.panelStudents.Controls.Add(this.flowLayoutPanel1);
            this.panelStudents.Controls.Add(this.button1);
            this.panelStudents.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStudents.Location = new System.Drawing.Point(0, 0);
            this.panelStudents.Name = "panelStudents";
            this.panelStudents.Size = new System.Drawing.Size(269, 743);
            this.panelStudents.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 334);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(257, 252);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 8.150943F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ум - способность студента справиться с заданиями о теме предмета";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 8.150943F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 8.150943F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(247, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Красноречие - шанс избежать негативных последствий при провале";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 8.150943F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 8.150943F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 48);
            this.label8.TabIndex = 6;
            this.label8.Text = "Дерзость - повышает шанс успеха на задании даже при нехватки определенных навыков" +
    "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 8.150943F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(7, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 8.150943F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(3, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(249, 64);
            this.label10.TabIndex = 8;
            this.label10.Text = "Сочувствие - помощник может добавить половину соответствующей характеристики в со" +
    "ответствии с требованиями миссии\r\n";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(29, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Показать подсказки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureMap
            // 
            this.pictureMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureMap.Image = ((System.Drawing.Image)(resources.GetObject("pictureMap.Image")));
            this.pictureMap.Location = new System.Drawing.Point(0, 0);
            this.pictureMap.Name = "pictureMap";
            this.pictureMap.Size = new System.Drawing.Size(1488, 743);
            this.pictureMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMap.TabIndex = 6;
            this.pictureMap.TabStop = false;
            // 
            // timerEvent
            // 
            this.timerEvent.Interval = 1000;
            this.timerEvent.Tick += new System.EventHandler(this.timerEvent_Tick);
            // 
            // panelNews
            // 
            this.panelNews.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelNews.Location = new System.Drawing.Point(1239, 0);
            this.panelNews.Name = "panelNews";
            this.panelNews.Size = new System.Drawing.Size(249, 743);
            this.panelNews.TabIndex = 8;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 743);
            this.Controls.Add(this.dialogEvent);
            this.Controls.Add(this.panelNews);
            this.Controls.Add(this.panelStudents);
            this.Controls.Add(this.pictureMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Map";
            this.Text = "Map";
            this.Load += new System.EventHandler(this.Map_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dialogEvent)).EndInit();
            this.panelStudents.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dialogEvent;
        private System.Windows.Forms.Panel panelStudents;
        private System.Windows.Forms.PictureBox pictureMap;
        private System.Windows.Forms.Timer timerEvent;
        private System.Windows.Forms.Timer timerStartSession;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelNews;
    }
}