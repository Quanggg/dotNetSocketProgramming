using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            bool valid = checkNickName(this.inputTb.Text);
            if (!valid)
            {
                this.warnLb.Visible = true;
                return;
            }
            //MainForm.OpenPlayForm();
            this.startButton.Text = "Waiting for other...";
            this.startButton.Enabled = false;
            this.loadingGif.Visible = true;
            this.warnLb.Visible = false;
        }

        private bool checkNickName(string text)
        {
            if (Regex.IsMatch(text, "^[a-zA-Z0-9]*$"))
                return true;
            return false;
        }
    }
}
