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

        private async void startButton_Click(object sender, EventArgs e)
        {
            if (inputTb.Text.Length == 0) return;

            bool valid = checkNickName(this.inputTb.Text);
            if (!valid)
            {
                this.warnLb.Visible = true;
                return;
            }
            this.startButton.Text = "Waiting for other...";
            this.startButton.Enabled = false;
            this.loadingGif.Visible = true;
            this.warnLb.Visible = false;
            this.inputTb.Enabled = false;
            // reverse this
            if (ClientSocket.isConnected)
            {
                MainForm.OpenForm(new PlayForm(inputTb.Text));
            }
            else
            {
                bool isConnected = await ClientSocket.ConnectToServerAsync();
                Console.WriteLine(isConnected);
                if (isConnected)
                {
                    MainForm.OpenForm(new PlayForm(inputTb.Text));
                }
                else {
                    this.startButton.Text = "Start";
                    this.startButton.Enabled = true;
                    this.loadingGif.Visible = false;
                    this.warnLb.Visible = false;
                    this.inputTb.Enabled = true;
                    MessageBox.Show("Cannot connect to Server", "Network Error");
                }
            }
        }

        private bool checkNickName(string text)
        {
            if (Regex.IsMatch(text, "^[a-zA-Z0-9]*$"))
                return true;
            return false;
        }
    }
}
