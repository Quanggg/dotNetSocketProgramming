﻿
namespace Client
{
    partial class PlayForm
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
            this.quizLb = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.noQuesLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nicknameLb = new System.Windows.Forms.Label();
            this.playerLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.skipButton = new System.Windows.Forms.Button();
            this.ansBotPanel = new System.Windows.Forms.Panel();
            this.ansTopPanel = new System.Windows.Forms.Panel();
            this.aBtn = new System.Windows.Forms.Button();
            this.bBtn = new System.Windows.Forms.Button();
            this.cBtn = new System.Windows.Forms.Button();
            this.dBtn = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.ansBotPanel.SuspendLayout();
            this.ansTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // quizLb
            // 
            this.quizLb.Dock = System.Windows.Forms.DockStyle.Top;
            this.quizLb.Location = new System.Drawing.Point(0, 83);
            this.quizLb.Name = "quizLb";
            this.quizLb.Size = new System.Drawing.Size(800, 95);
            this.quizLb.TabIndex = 0;
            this.quizLb.Text = "Waiting for your turn...";
            this.quizLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.noQuesLb);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.nicknameLb);
            this.topPanel.Controls.Add(this.playerLb);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.skipButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 83);
            this.topPanel.TabIndex = 2;
            // 
            // noQuesLb
            // 
            this.noQuesLb.Location = new System.Drawing.Point(205, 9);
            this.noQuesLb.Name = "noQuesLb";
            this.noQuesLb.Size = new System.Drawing.Size(40, 41);
            this.noQuesLb.TabIndex = 5;
            this.noQuesLb.Text = "3";
            this.noQuesLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Question is";
            // 
            // nicknameLb
            // 
            this.nicknameLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nicknameLb.Location = new System.Drawing.Point(625, 45);
            this.nicknameLb.Name = "nicknameLb";
            this.nicknameLb.Size = new System.Drawing.Size(117, 21);
            this.nicknameLb.TabIndex = 3;
            this.nicknameLb.Text = "nickname";
            this.nicknameLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // playerLb
            // 
            this.playerLb.Location = new System.Drawing.Point(748, 9);
            this.playerLb.Name = "playerLb";
            this.playerLb.Size = new System.Drawing.Size(40, 41);
            this.playerLb.TabIndex = 2;
            this.playerLb.Text = "3";
            this.playerLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "You are player:";
            // 
            // skipButton
            // 
            this.skipButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.skipButton.Location = new System.Drawing.Point(12, 12);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(60, 54);
            this.skipButton.TabIndex = 0;
            this.skipButton.Text = "Skip";
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // ansBotPanel
            // 
            this.ansBotPanel.Controls.Add(this.dBtn);
            this.ansBotPanel.Controls.Add(this.cBtn);
            this.ansBotPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ansBotPanel.Enabled = false;
            this.ansBotPanel.Location = new System.Drawing.Point(0, 350);
            this.ansBotPanel.Name = "ansBotPanel";
            this.ansBotPanel.Size = new System.Drawing.Size(800, 100);
            this.ansBotPanel.TabIndex = 4;
            // 
            // ansTopPanel
            // 
            this.ansTopPanel.Controls.Add(this.bBtn);
            this.ansTopPanel.Controls.Add(this.aBtn);
            this.ansTopPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ansTopPanel.Enabled = false;
            this.ansTopPanel.Location = new System.Drawing.Point(0, 250);
            this.ansTopPanel.Name = "ansTopPanel";
            this.ansTopPanel.Size = new System.Drawing.Size(800, 100);
            this.ansTopPanel.TabIndex = 5;
            // 
            // aBtn
            // 
            this.aBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.aBtn.Location = new System.Drawing.Point(0, 0);
            this.aBtn.Name = "aBtn";
            this.aBtn.Size = new System.Drawing.Size(400, 100);
            this.aBtn.TabIndex = 0;
            this.aBtn.Text = "A";
            this.aBtn.UseVisualStyleBackColor = true;
            this.aBtn.Click += new System.EventHandler(this.aBtn_Click);
            // 
            // bBtn
            // 
            this.bBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.bBtn.Location = new System.Drawing.Point(400, 0);
            this.bBtn.Name = "bBtn";
            this.bBtn.Size = new System.Drawing.Size(400, 100);
            this.bBtn.TabIndex = 1;
            this.bBtn.Text = "B";
            this.bBtn.UseVisualStyleBackColor = true;
            this.bBtn.Click += new System.EventHandler(this.bBtn_Click);
            // 
            // cBtn
            // 
            this.cBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.cBtn.Location = new System.Drawing.Point(0, 0);
            this.cBtn.Name = "cBtn";
            this.cBtn.Size = new System.Drawing.Size(400, 100);
            this.cBtn.TabIndex = 1;
            this.cBtn.Text = "C";
            this.cBtn.UseVisualStyleBackColor = true;
            this.cBtn.Click += new System.EventHandler(this.cBtn_Click);
            // 
            // dBtn
            // 
            this.dBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.dBtn.Location = new System.Drawing.Point(400, 0);
            this.dBtn.Name = "dBtn";
            this.dBtn.Size = new System.Drawing.Size(400, 100);
            this.dBtn.TabIndex = 2;
            this.dBtn.Text = "D";
            this.dBtn.UseVisualStyleBackColor = true;
            this.dBtn.Click += new System.EventHandler(this.dBtn_Click);
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ansTopPanel);
            this.Controls.Add(this.ansBotPanel);
            this.Controls.Add(this.quizLb);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayForm";
            this.Text = "PlayForm";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ansBotPanel.ResumeLayout(false);
            this.ansTopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label quizLb;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel ansBotPanel;
        private System.Windows.Forms.Panel ansTopPanel;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.Label nicknameLb;
        private System.Windows.Forms.Label playerLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label noQuesLb;
        private System.Windows.Forms.Button dBtn;
        private System.Windows.Forms.Button cBtn;
        private System.Windows.Forms.Button bBtn;
        private System.Windows.Forms.Button aBtn;
    }
}