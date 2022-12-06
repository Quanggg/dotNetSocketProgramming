
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
            this.labelC = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelD = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.skipButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.playerLb = new System.Windows.Forms.Label();
            this.nicknameLb = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // labelC
            // 
            this.labelC.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelC.Location = new System.Drawing.Point(0, 0);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(357, 100);
            this.labelC.TabIndex = 3;
            this.labelC.Text = "label1";
            this.labelC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelD);
            this.panel1.Controls.Add(this.labelC);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 4;
            // 
            // labelD
            // 
            this.labelD.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelD.Location = new System.Drawing.Point(443, 0);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(357, 100);
            this.labelD.TabIndex = 4;
            this.labelD.Text = "label1";
            this.labelD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelB);
            this.panel2.Controls.Add(this.labelA);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 5;
            // 
            // labelB
            // 
            this.labelB.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelB.Location = new System.Drawing.Point(443, 0);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(357, 100);
            this.labelB.TabIndex = 4;
            this.labelB.Text = "label2";
            this.labelB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelA
            // 
            this.labelA.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelA.Location = new System.Drawing.Point(0, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(357, 100);
            this.labelA.TabIndex = 3;
            this.labelA.Text = "label1";
            this.labelA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // playerLb
            // 
            this.playerLb.Location = new System.Drawing.Point(748, 9);
            this.playerLb.Name = "playerLb";
            this.playerLb.Size = new System.Drawing.Size(40, 41);
            this.playerLb.TabIndex = 2;
            this.playerLb.Text = "3";
            this.playerLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.quizLb);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayForm";
            this.Text = "PlayForm";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label quizLb;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.Label nicknameLb;
        private System.Windows.Forms.Label playerLb;
        private System.Windows.Forms.Label label1;
    }
}