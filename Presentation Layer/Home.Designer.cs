using System.Collections.Generic;
using System.Windows.Forms;

namespace MyDiary.Presentation_Layer
{
    partial class Home
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.allEventsPanel = new System.Windows.Forms.Panel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.importanceBtn = new System.Windows.Forms.Button();
            this.modifyEventBtn = new System.Windows.Forms.Button();
            this.removeEventBtn = new System.Windows.Forms.Button();
            this.addEventBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.eventDetailsPanel = new System.Windows.Forms.Panel();
            this.addEventPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.importanceComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.doneBtn = new System.Windows.Forms.Button();
            this.addImageBtn = new System.Windows.Forms.Button();
            this.eventDetailsTextBox = new System.Windows.Forms.TextBox();
            this.eventTitleTextBox = new System.Windows.Forms.TextBox();
            this.newEventDetailsLabel = new System.Windows.Forms.Label();
            this.newEventTitleLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.eventDetailsLabel = new System.Windows.Forms.Label();
            this.rightTopPanel = new System.Windows.Forms.Panel();
            this.personNameLabel = new System.Windows.Forms.Label();
            this.modifiedTimeLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.eventTitleLabel = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.pictureNameLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.eventDetailsPanel.SuspendLayout();
            this.addEventPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.rightTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.allEventsPanel);
            this.leftPanel.Controls.Add(this.buttonsPanel);
            this.leftPanel.Controls.Add(this.label1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(250, 600);
            this.leftPanel.TabIndex = 4;
            // 
            // allEventsPanel
            // 
            this.allEventsPanel.AutoScroll = true;
            this.allEventsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.allEventsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allEventsPanel.Location = new System.Drawing.Point(0, 137);
            this.allEventsPanel.Name = "allEventsPanel";
            this.allEventsPanel.Size = new System.Drawing.Size(250, 463);
            this.allEventsPanel.TabIndex = 4;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonsPanel.Controls.Add(this.importanceBtn);
            this.buttonsPanel.Controls.Add(this.modifyEventBtn);
            this.buttonsPanel.Controls.Add(this.removeEventBtn);
            this.buttonsPanel.Controls.Add(this.addEventBtn);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 87);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(250, 50);
            this.buttonsPanel.TabIndex = 3;
            // 
            // importanceBtn
            // 
            this.importanceBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.importanceBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.importanceBtn.Enabled = false;
            this.importanceBtn.FlatAppearance.BorderSize = 0;
            this.importanceBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.importanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importanceBtn.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importanceBtn.ForeColor = System.Drawing.Color.White;
            this.importanceBtn.Location = new System.Drawing.Point(100, 0);
            this.importanceBtn.Margin = new System.Windows.Forms.Padding(0);
            this.importanceBtn.Name = "importanceBtn";
            this.importanceBtn.Size = new System.Drawing.Size(50, 50);
            this.importanceBtn.TabIndex = 7;
            this.importanceBtn.Text = "I";
            this.importanceBtn.UseVisualStyleBackColor = true;
            // 
            // modifyEventBtn
            // 
            this.modifyEventBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.modifyEventBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.modifyEventBtn.Enabled = false;
            this.modifyEventBtn.FlatAppearance.BorderSize = 0;
            this.modifyEventBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifyEventBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyEventBtn.ForeColor = System.Drawing.Color.White;
            this.modifyEventBtn.Location = new System.Drawing.Point(148, 0);
            this.modifyEventBtn.Margin = new System.Windows.Forms.Padding(0);
            this.modifyEventBtn.Name = "modifyEventBtn";
            this.modifyEventBtn.Size = new System.Drawing.Size(102, 50);
            this.modifyEventBtn.TabIndex = 6;
            this.modifyEventBtn.Text = "Modify";
            this.modifyEventBtn.UseVisualStyleBackColor = true;
            this.modifyEventBtn.Click += new System.EventHandler(this.modifyEventBtn_Click);
            // 
            // removeEventBtn
            // 
            this.removeEventBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.removeEventBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.removeEventBtn.Enabled = false;
            this.removeEventBtn.FlatAppearance.BorderSize = 0;
            this.removeEventBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.removeEventBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeEventBtn.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeEventBtn.ForeColor = System.Drawing.Color.White;
            this.removeEventBtn.Location = new System.Drawing.Point(50, 0);
            this.removeEventBtn.Margin = new System.Windows.Forms.Padding(0);
            this.removeEventBtn.Name = "removeEventBtn";
            this.removeEventBtn.Size = new System.Drawing.Size(50, 50);
            this.removeEventBtn.TabIndex = 5;
            this.removeEventBtn.Text = "-";
            this.removeEventBtn.UseVisualStyleBackColor = true;
            this.removeEventBtn.Click += new System.EventHandler(this.removeEventBtn_Click);
            // 
            // addEventBtn
            // 
            this.addEventBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addEventBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.addEventBtn.FlatAppearance.BorderSize = 0;
            this.addEventBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.addEventBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEventBtn.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEventBtn.ForeColor = System.Drawing.Color.White;
            this.addEventBtn.Location = new System.Drawing.Point(0, 0);
            this.addEventBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addEventBtn.Name = "addEventBtn";
            this.addEventBtn.Size = new System.Drawing.Size(50, 50);
            this.addEventBtn.TabIndex = 4;
            this.addEventBtn.Text = "+";
            this.addEventBtn.UseVisualStyleBackColor = true;
            this.addEventBtn.Click += new System.EventHandler(this.addEventBtn_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 87);
            this.label1.TabIndex = 2;
            this.label1.Text = "My Diary";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.eventDetailsPanel);
            this.rightPanel.Controls.Add(this.rightTopPanel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(250, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(550, 600);
            this.rightPanel.TabIndex = 5;
            // 
            // eventDetailsPanel
            // 
            this.eventDetailsPanel.AutoScroll = true;
            this.eventDetailsPanel.Controls.Add(this.addEventPanel);
            this.eventDetailsPanel.Controls.Add(this.pictureBox);
            this.eventDetailsPanel.Controls.Add(this.eventDetailsLabel);
            this.eventDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventDetailsPanel.Location = new System.Drawing.Point(0, 137);
            this.eventDetailsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.eventDetailsPanel.Name = "eventDetailsPanel";
            this.eventDetailsPanel.Size = new System.Drawing.Size(550, 463);
            this.eventDetailsPanel.TabIndex = 1;
            // 
            // addEventPanel
            // 
            this.addEventPanel.Controls.Add(this.pictureNameLabel);
            this.addEventPanel.Controls.Add(this.closeBtn);
            this.addEventPanel.Controls.Add(this.importanceComboBox);
            this.addEventPanel.Controls.Add(this.label2);
            this.addEventPanel.Controls.Add(this.doneBtn);
            this.addEventPanel.Controls.Add(this.addImageBtn);
            this.addEventPanel.Controls.Add(this.eventDetailsTextBox);
            this.addEventPanel.Controls.Add(this.eventTitleTextBox);
            this.addEventPanel.Controls.Add(this.newEventDetailsLabel);
            this.addEventPanel.Controls.Add(this.newEventTitleLabel);
            this.addEventPanel.Location = new System.Drawing.Point(0, 0);
            this.addEventPanel.Name = "addEventPanel";
            this.addEventPanel.Size = new System.Drawing.Size(550, 463);
            this.addEventPanel.TabIndex = 2;
            this.addEventPanel.Visible = false;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Crimson;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(502, 383);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(28, 29);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // importanceComboBox
            // 
            this.importanceComboBox.DropDownWidth = 120;
            this.importanceComboBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importanceComboBox.FormattingEnabled = true;
            this.importanceComboBox.Items.AddRange(new object[] {
            "Less",
            "Moderate",
            "High"});
            this.importanceComboBox.Location = new System.Drawing.Point(124, 382);
            this.importanceComboBox.Name = "importanceComboBox";
            this.importanceComboBox.Size = new System.Drawing.Size(99, 29);
            this.importanceComboBox.TabIndex = 7;
            this.importanceComboBox.Text = "Moderate";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Importance";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // doneBtn
            // 
            this.doneBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.doneBtn.FlatAppearance.BorderSize = 0;
            this.doneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBtn.Location = new System.Drawing.Point(397, 383);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(93, 29);
            this.doneBtn.TabIndex = 5;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = false;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // addImageBtn
            // 
            this.addImageBtn.AutoSize = true;
            this.addImageBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.addImageBtn.FlatAppearance.BorderSize = 0;
            this.addImageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addImageBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addImageBtn.Location = new System.Drawing.Point(236, 383);
            this.addImageBtn.Name = "addImageBtn";
            this.addImageBtn.Size = new System.Drawing.Size(149, 29);
            this.addImageBtn.TabIndex = 4;
            this.addImageBtn.Text = "Add/Change Image";
            this.addImageBtn.UseVisualStyleBackColor = false;
            this.addImageBtn.Click += new System.EventHandler(this.addImageBtn_Click);
            // 
            // eventDetailsTextBox
            // 
            this.eventDetailsTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDetailsTextBox.Location = new System.Drawing.Point(20, 128);
            this.eventDetailsTextBox.Multiline = true;
            this.eventDetailsTextBox.Name = "eventDetailsTextBox";
            this.eventDetailsTextBox.Size = new System.Drawing.Size(510, 240);
            this.eventDetailsTextBox.TabIndex = 3;
            // 
            // eventTitleTextBox
            // 
            this.eventTitleTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTitleTextBox.Location = new System.Drawing.Point(20, 54);
            this.eventTitleTextBox.Name = "eventTitleTextBox";
            this.eventTitleTextBox.Size = new System.Drawing.Size(510, 29);
            this.eventTitleTextBox.TabIndex = 2;
            // 
            // newEventDetailsLabel
            // 
            this.newEventDetailsLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEventDetailsLabel.Location = new System.Drawing.Point(20, 89);
            this.newEventDetailsLabel.Name = "newEventDetailsLabel";
            this.newEventDetailsLabel.Size = new System.Drawing.Size(82, 33);
            this.newEventDetailsLabel.TabIndex = 1;
            this.newEventDetailsLabel.Text = "Details";
            this.newEventDetailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newEventTitleLabel
            // 
            this.newEventTitleLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEventTitleLabel.Location = new System.Drawing.Point(20, 15);
            this.newEventTitleLabel.Name = "newEventTitleLabel";
            this.newEventTitleLabel.Size = new System.Drawing.Size(82, 33);
            this.newEventTitleLabel.TabIndex = 0;
            this.newEventTitleLabel.Text = "Title";
            this.newEventTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox.Location = new System.Drawing.Point(0, 463);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(550, 275);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // eventDetailsLabel
            // 
            this.eventDetailsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventDetailsLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDetailsLabel.Location = new System.Drawing.Point(0, 0);
            this.eventDetailsLabel.Name = "eventDetailsLabel";
            this.eventDetailsLabel.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.eventDetailsLabel.Size = new System.Drawing.Size(550, 738);
            this.eventDetailsLabel.TabIndex = 0;
            // 
            // rightTopPanel
            // 
            this.rightTopPanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.rightTopPanel.Controls.Add(this.personNameLabel);
            this.rightTopPanel.Controls.Add(this.modifiedTimeLabel);
            this.rightTopPanel.Controls.Add(this.timeLabel);
            this.rightTopPanel.Controls.Add(this.logoutBtn);
            this.rightTopPanel.Controls.Add(this.eventTitleLabel);
            this.rightTopPanel.Controls.Add(this.ExitBtn);
            this.rightTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.rightTopPanel.Location = new System.Drawing.Point(0, 0);
            this.rightTopPanel.Name = "rightTopPanel";
            this.rightTopPanel.Size = new System.Drawing.Size(550, 137);
            this.rightTopPanel.TabIndex = 0;
            // 
            // personNameLabel
            // 
            this.personNameLabel.AutoSize = true;
            this.personNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personNameLabel.ForeColor = System.Drawing.Color.White;
            this.personNameLabel.Location = new System.Drawing.Point(10, 12);
            this.personNameLabel.Name = "personNameLabel";
            this.personNameLabel.Size = new System.Drawing.Size(0, 19);
            this.personNameLabel.TabIndex = 4;
            // 
            // modifiedTimeLabel
            // 
            this.modifiedTimeLabel.AutoSize = true;
            this.modifiedTimeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifiedTimeLabel.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.modifiedTimeLabel.Location = new System.Drawing.Point(271, 71);
            this.modifiedTimeLabel.Name = "modifiedTimeLabel";
            this.modifiedTimeLabel.Size = new System.Drawing.Size(0, 19);
            this.modifiedTimeLabel.TabIndex = 3;
            this.modifiedTimeLabel.Visible = false;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.timeLabel.Location = new System.Drawing.Point(10, 71);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 19);
            this.timeLabel.TabIndex = 2;
            // 
            // logoutBtn
            // 
            this.logoutBtn.AutoSize = true;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.logoutBtn.Location = new System.Drawing.Point(439, 12);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(63, 29);
            this.logoutBtn.TabIndex = 1;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // eventTitleLabel
            // 
            this.eventTitleLabel.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventTitleLabel.ForeColor = System.Drawing.Color.White;
            this.eventTitleLabel.Location = new System.Drawing.Point(0, 87);
            this.eventTitleLabel.Name = "eventTitleLabel";
            this.eventTitleLabel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.eventTitleLabel.Size = new System.Drawing.Size(550, 49);
            this.eventTitleLabel.TabIndex = 0;
            this.eventTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(508, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(30, 30);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // pictureNameLabel
            // 
            this.pictureNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureNameLabel.Location = new System.Drawing.Point(20, 423);
            this.pictureNameLabel.Name = "pictureNameLabel";
            this.pictureNameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pictureNameLabel.Size = new System.Drawing.Size(510, 40);
            this.pictureNameLabel.TabIndex = 5;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.leftPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.eventDetailsPanel.ResumeLayout(false);
            this.addEventPanel.ResumeLayout(false);
            this.addEventPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.rightTopPanel.ResumeLayout(false);
            this.rightTopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel eventDetailsPanel;
        private System.Windows.Forms.Panel rightTopPanel;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button addEventBtn;
        private System.Windows.Forms.Button removeEventBtn;
        private System.Windows.Forms.Button modifyEventBtn;
        private System.Windows.Forms.Button importanceBtn;
        private System.Windows.Forms.Panel allEventsPanel;
        private System.Windows.Forms.Label eventTitleLabel;
        private System.Windows.Forms.Label eventDetailsLabel;
        private System.Windows.Forms.Button logoutBtn;
        private Label timeLabel;
        private Label modifiedTimeLabel;
        private Label personNameLabel;
        private PictureBox pictureBox;
        private Panel addEventPanel;
        private Button closeBtn;
        private ComboBox importanceComboBox;
        private Label label2;
        private Button doneBtn;
        private Button addImageBtn;
        private TextBox eventDetailsTextBox;
        private TextBox eventTitleTextBox;
        private Label newEventDetailsLabel;
        private Label newEventTitleLabel;
        private Label pictureNameLabel;
    }
}