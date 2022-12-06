﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Client
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            inputTb.Focus();
            try
            {
                ClientSocket.Exit();
            }
            catch (Exception)
            { }
        }
        private const int Buffer_Size = 2048;
        private byte[] buffer = new byte[Buffer_Size];
        private void startButton_Click(object sender, EventArgs e)
        {
            if (inputTb.Text.Length == 0) return;

            bool valid = checkNickName(this.inputTb.Text);
            if (!valid)
            {
                //this.warnLb.Visible = true;
                MessageBox.Show("Please enter again", "Invalid nickname");
                return;
            }
            this.startButton.Text = "Waiting for server...";
            this.startButton.Enabled = false;
            //this.loadingGif.Visible = true;
            //this.warnLb.Visible = false;
            this.inputTb.Enabled = false;
            joinGame(this.inputTb.Text);

        }

        private async void joinGame(string nickname)
        {
            // reverse this
            AsyncCallback asyncCallback = (param) =>
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
                    this.startButton.Invoke(new Action(() => this.startButton.Text = "Waiting for other to join..."));
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
            try
            {
                if (ClientSocket.isConnected)
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
            catch (Exception)
            {

            }
        }

        private void startGame(string nickname)
        {
            AsyncCallback asyncCallback = (param) =>
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
                Console.WriteLine(text + received);
                if (text.StartsWith("game"))
                {
                    string[] data = text.Split('~');
                    Action action = () =>
                    {
                        MainForm.OpenPlayForm(nickname, data[1], data[2], data[3]);
                    };
                    this.BeginInvoke(action);
                }
                else
                {
                    MessageBox.Show("Cannot start game", "Network error");
                    resetState();
                }
            };
            ClientSocket.clientSocket.BeginReceive(buffer, 0, Buffer_Size, System.Net.Sockets.SocketFlags.None, asyncCallback, null);
        }

        private void resetState()
        {
            this.startButton.Invoke(new Action(() => this.startButton.Text = "Start"));
            this.startButton.Invoke(new Action(() => this.startButton.Enabled = true));
            this.loadingGif.Invoke(new Action(() => this.loadingGif.Visible = false));
            //this.warnLb.Visible = false;
            this.inputTb.Invoke(new Action(() => this.inputTb.Enabled = true));
        }

        private bool checkNickName(string text)
        {
            if (Regex.IsMatch(text, "^[a-zA-Z0-9_]*$"))
                return true;
            return false;
        }

        private void inputTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                startButton.PerformClick();
        }
    }
}
