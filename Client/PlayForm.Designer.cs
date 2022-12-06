
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
            this.quizLb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.quizLb.Font = new System.Drawing.Font("Bahnschrift", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.quizLb.Location = new System.Drawing.Point(0, 117);
            this.quizLb.Name = "quizLb";
            this.quizLb.Size = new System.Drawing.Size(800, 133);
            this.quizLb.TabIndex = 0;
            this.quizLb.Text = "Waiting for your turn...";
            this.quizLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.noQuesLb.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noQuesLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.noQuesLb.Location = new System.Drawing.Point(247, 12);
            this.noQuesLb.Name = "noQuesLb";
            this.noQuesLb.Size = new System.Drawing.Size(40, 41);
            this.noQuesLb.TabIndex = 5;
            this.noQuesLb.Text = "3";
            this.noQuesLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(113, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Question is";
            // 
            // nicknameLb
            // 
            this.nicknameLb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nicknameLb.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknameLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.nicknameLb.Location = new System.Drawing.Point(541, 45);
            this.nicknameLb.Name = "nicknameLb";
            this.nicknameLb.Size = new System.Drawing.Size(117, 21);
            this.nicknameLb.TabIndex = 3;
            this.nicknameLb.Text = "nickname";
            this.nicknameLb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // playerLb
            // 
            this.playerLb.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
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
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(625, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "You are player:";
            // 
            // skipButton
            // 
            this.skipButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.skipButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(195)))), ((int)(((byte)(176)))));
            this.skipButton.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.skipButton.Location = new System.Drawing.Point(12, 12);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(81, 54);
            this.skipButton.TabIndex = 0;
            this.skipButton.Text = "Skip";
            this.skipButton.UseVisualStyleBackColor = false;
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
            this.aBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(27)))), ((int)(((byte)(60)))));
            this.aBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.aBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(69)))), ((int)(((byte)(89)))));
            this.aBtn.FlatAppearance.BorderSize = 0;
            this.aBtn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.aBtn.Location = new System.Drawing.Point(0, 0);
            this.aBtn.Name = "aBtn";
            this.aBtn.Size = new System.Drawing.Size(400, 100);
            this.aBtn.TabIndex = 0;
            this.aBtn.Text = "A";
            this.aBtn.UseVisualStyleBackColor = false;
            this.aBtn.Click += new System.EventHandler(this.aBtn_Click);
            // 
            // bBtn
            // 
            this.bBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(104)))), ((int)(((byte)(206)))));
            this.bBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.bBtn.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.bBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bBtn.Location = new System.Drawing.Point(400, 0);
            this.bBtn.Name = "bBtn";
            this.bBtn.Size = new System.Drawing.Size(400, 100);
            this.bBtn.TabIndex = 1;
            this.bBtn.Text = "B";
            this.bBtn.UseVisualStyleBackColor = false;
            this.bBtn.Click += new System.EventHandler(this.bBtn_Click);
            // 
            // cBtn
            // 
            this.cBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(137)))), ((int)(((byte)(12)))));
            this.cBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.cBtn.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.cBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cBtn.Location = new System.Drawing.Point(0, 0);
            this.cBtn.Name = "cBtn";
            this.cBtn.Size = new System.Drawing.Size(400, 100);
            this.cBtn.TabIndex = 1;
            this.cBtn.Text = "C";
            this.cBtn.UseVisualStyleBackColor = false;
            this.cBtn.Click += new System.EventHandler(this.cBtn_Click);
            // 
            // dBtn
            // 
            this.dBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(158)))), ((int)(((byte)(0)))));
            this.dBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.dBtn.Font = new System.Drawing.Font("Bahnschrift", 14.25F);
            this.dBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dBtn.Location = new System.Drawing.Point(400, 0);
            this.dBtn.Name = "dBtn";
            this.dBtn.Size = new System.Drawing.Size(400, 100);
            this.dBtn.TabIndex = 2;
            this.dBtn.Text = "D";
            this.dBtn.UseVisualStyleBackColor = false;
            this.dBtn.Click += new System.EventHandler(this.dBtn_Click);
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(69)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quizLb);
            this.Controls.Add(this.ansTopPanel);
            this.Controls.Add(this.ansBotPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayForm";
            this.Text = "PlayForm";
            this.Load += new System.EventHandler(this.PlayForm_Load);
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