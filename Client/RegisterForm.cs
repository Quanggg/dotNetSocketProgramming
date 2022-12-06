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
            try
            {
                ClientSocket.Exit();
            }
            catch (Exception)
            { }
        }
        private byte[] buffer;
        private const int Buffer_Size = 2048;
        private void startButton_Click(object sender, EventArgs e)
        {
            if (inputTb.Text.Length == 0) return;

            bool valid = checkNickName(this.inputTb.Text);
            if (!valid)
            {
                //this.warnLb.Visible = true;
                return;
            }
            this.startButton.Text = "Waiting for server...";
            this.startButton.Enabled = false;
            this.loadingGif.Visible = true;
            //this.warnLb.Visible = false;
            this.inputTb.Enabled = false;
            joinGame(this.inputTb.Text);

        }

        private async void joinGame(string nickname)
        {
            // reverse this
            AsyncCallback asyncCallback = async (param) =>
            {
                int received = 0;
                try
                {
                    received = ClientSocket.clientSocket.EndReceive(param);
                }
                catch { }
                byte[] receiveBuffer = new byte[received];
                Array.Copy(buffer, receiveBuffer, received);
                string text = Encoding.ASCII.GetString(receiveBuffer);
                if (text.StartsWith("register_success"))
                {
                    this.startButton.Text = "Waiting for other to join...";
                    startGame(nickname);
                }
                else if (text.StartsWith("register_fail"))
                {
                    MessageBox.Show("Please enter again", "Invalid nickname");
                    resetState();
                }
                else
                {
                    MessageBox.Show("Please try again later", "Network error");
                    resetState();
                }
            };
            if (!ClientSocket.isConnected)
            {
                ClientSocket.SendString("register~" + nickname);
                ClientSocket.clientSocket.BeginReceive(buffer, 0, Buffer_Size, System.Net.Sockets.SocketFlags.None, asyncCallback, null);
            }
            else
            {
                bool isConnected = await ClientSocket.ConnectToServerAsync();
                if (isConnected)
                {
                    ClientSocket.SendString("register~" + nickname);
                    ClientSocket.clientSocket.BeginReceive(buffer, 0, Buffer_Size, System.Net.Sockets.SocketFlags.None, asyncCallback, null);
                }
                else
                {
                    MessageBox.Show("Please try again later", "Network error");
                    resetState();
                }
            }
        }

        private void startGame(string nickname)
        {
            AsyncCallback asyncCallback = async (param) =>
            {
                int received = 0;
                try
                {
                    received = ClientSocket.clientSocket.EndReceive(param);
                }
                catch { }
                byte[] receiveBuffer = new byte[received];
                Array.Copy(buffer, receiveBuffer, received);
                string text = Encoding.ASCII.GetString(receiveBuffer);
                if (text.StartsWith("game"))
                {
                    string[] data = text.Split('~');
                    MainForm.OpenForm(new PlayForm(nickname, data[1], data[2], data[3]));
                }
                else 
                {
                    MessageBox.Show("Cannot start game", "Network error");
                    resetState();
                }
            };
        }

        private void resetState()
        {
            this.startButton.Text = "Start";
            this.startButton.Enabled = true;
            this.loadingGif.Visible = false;
            //this.warnLb.Visible = false;
            this.inputTb.Enabled = true;
        }

        private bool checkNickName(string text)
        {
            if (Regex.IsMatch(text, "^[a-zA-Z0-9_]*$"))
                return true;
            return false;
        }
    }
}
