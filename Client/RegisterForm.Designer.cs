
namespace Client
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.startButton = new System.Windows.Forms.Button();
            this.warnLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputTb = new System.Windows.Forms.TextBox();
            this.loadingGif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loadingGif)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.AutoSize = true;
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(195)))), ((int)(((byte)(176)))));
            this.startButton.Font = new System.Drawing.Font("Bahnschrift", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(30)))));
            this.startButton.Location = new System.Drawing.Point(275, 336);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(250, 79);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // warnLb
            // 
            this.warnLb.Location = new System.Drawing.Point(250, 290);
            this.warnLb.Name = "warnLb";
            this.warnLb.Size = new System.Drawing.Size(300, 30);
            this.warnLb.TabIndex = 2;
            this.warnLb.Text = "Nickname already exists. Please choose another one";
            this.warnLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.warnLb.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(250, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your Nickname";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputTb
            // 
            this.inputTb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputTb.Location = new System.Drawing.Point(275, 200);
            this.inputTb.MaxLength = 10;
            this.inputTb.Multiline = true;
            this.inputTb.Name = "inputTb";
            this.inputTb.Size = new System.Drawing.Size(250, 40);
            this.inputTb.TabIndex = 4;
            this.inputTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTb_KeyPress);
            // 
            // loadingGif
            // 
            this.loadingGif.BackColor = System.Drawing.Color.Transparent;
            this.loadingGif.ErrorImage = null;
            this.loadingGif.Image = ((System.Drawing.Image)(resources.GetObject("loadingGif.Image")));
            this.loadingGif.InitialImage = null;
            this.loadingGif.Location = new System.Drawing.Point(532, 336);
            this.loadingGif.Name = "loadingGif";
            this.loadingGif.Size = new System.Drawing.Size(80, 80);
            this.loadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingGif.TabIndex = 5;
            this.loadingGif.TabStop = false;
            this.loadingGif.Visible = false;
            this.loadingGif.WaitOnLoad = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(69)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadingGif);
            this.Controls.Add(this.inputTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.warnLb);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.loadingGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label warnLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTb;
        private System.Windows.Forms.PictureBox loadingGif;
    }
}