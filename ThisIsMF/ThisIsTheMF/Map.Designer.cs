
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map));
            this.dialogEvent = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.panelStudents = new System.Windows.Forms.Panel();
            this.pictureMap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dialogEvent)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMap)).BeginInit();
            this.SuspendLayout();
            // 
            // dialogEvent
            // 
            this.dialogEvent.BackColor = System.Drawing.Color.Transparent;
            this.dialogEvent.Image = ((System.Drawing.Image)(resources.GetObject("dialogEvent.Image")));
            this.dialogEvent.Location = new System.Drawing.Point(564, 92);
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(275, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 56);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel.Location = new System.Drawing.Point(1187, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(236, 719);
            this.panel.TabIndex = 8;
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
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 719);
            this.Controls.Add(this.dialogEvent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelStudents);
            this.Controls.Add(this.pictureMap);
            this.Name = "Map";
            this.Text = "Map";
            ((System.ComponentModel.ISupportInitialize)(this.dialogEvent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dialogEvent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panelStudents;
        private System.Windows.Forms.PictureBox pictureMap;
    }
}