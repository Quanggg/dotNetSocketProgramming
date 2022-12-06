using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class PlayForm : Form
    {
        private const int Buffer_Size = 2048;
        private byte[] buffer = new byte[Buffer_Size];
        private string correctAns, ans0, ans1, ans2, ques;
        public PlayForm(string nickname, string numOfPlayer, string numOfQues, string playerIdx)
        {
            InitializeComponent();
            //this.TopLevel = false;
            //this.Dock = DockStyle.Fill;
            //this.Show();
            //try
            //{
            //    MainForm.panel.Controls.Add(this);
            //}
            //catch (Exception)
            //{
            //    MainForm.panel.Invoke(new Action(() => MainForm.panel.Controls.Add(this)));
            //}

            this.nicknameLb.Text = nickname;
            this.playerLb.Text = playerIdx;
            noQuesLb.Text = numOfQues;
            //listenForQuestion();
        }

        private void listenForQuestion()
        {
            try
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
                    try
                    {
                        if (text.StartsWith("winner"))
                        {
                            string[] data = text.Split('~');
                            checkWinner(data[1]);
                        }
                        else
                        {
                            string[] data = text.Split('~');
                            ques = data[0];
                            string[] ans = new string[4];
                            correctAns = data[1];
                            ans[0] = correctAns;
                            ans[1] = data[2];
                            ans[2] = data[3];
                            ans[3] = data[4];
                            Random rng = new Random();
                            var shuffledAns = ans.OrderBy(a => rng.Next()).ToList();
                            if (!IsHandleCreated)
                                CreateControl();
                            this.BeginInvoke((Action)(() => prepareQuestion(shuffledAns)));
                        }
                    }
                    catch (Exception)
                    {
                    }
                    
                    listenForQuestion();
                };
                ClientSocket.clientSocket.BeginReceive(buffer, 0, Buffer_Size, System.Net.Sockets.SocketFlags.None, asyncCallback, null);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void prepareQuestion(List<string> shuffledAns)
        {
            ansTopPanel.Enabled = true;
            ansBotPanel.Enabled = true;
            aBtn.Text = shuffledAns[0];
            bBtn.Text = shuffledAns[1];
            cBtn.Text = shuffledAns[2];
            dBtn.Text = shuffledAns[3];
            quizLb.Text = ques;
            //ansTopPanel.Invoke(new Action(() => ansTopPanel.Enabled = true));
            //ansBotPanel.Invoke(new Action(() => ansTopPanel.Enabled = true));
            //aBtn.Invoke(new Action(() => aBtn.Text = shuffledAns[0]));
            //bBtn.Invoke(new Action(() => bBtn.Text = shuffledAns[1]));
            //cBtn.Invoke(new Action(() => cBtn.Text = shuffledAns[2]));
            //dBtn.Invoke(new Action(() => dBtn.Text = shuffledAns[3]));
            //quizLb.Invoke(new Action(() => quizLb.Text = ques));

        }
        private void aBtn_Click(object sender, EventArgs e)
        {
            if (aBtn.Text.Equals(correctAns))
            {
                MessageBox.Show("Correct Answer");
                ClientSocket.SendString("my_answer~" + aBtn.Text);
            }
            else
            {
                MessageBox.Show("You are disqualified", "Incorrect Answer");
                MainForm.OpenForm(new RegisterForm());
            }

        }
        private void bBtn_Click(object sender, EventArgs e)
        {
            if (bBtn.Text.Equals(correctAns))
            {
                MessageBox.Show("Correct Answer");
                ClientSocket.SendString("my_answer~" + bBtn.Text);
            }
            else
            {
                MessageBox.Show("You are disqualified", "Incorrect Answer");
                MainForm.OpenForm(new RegisterForm());
            }
        }

        private void cBtn_Click(object sender, EventArgs e)
        {
            if (cBtn.Text.Equals(correctAns))
            {
                MessageBox.Show("Correct Answer");
                ClientSocket.SendString("my_answer~" + cBtn.Text);
            }
            else
            {
                MessageBox.Show("You are disqualified", "Incorrect Answer");
                MainForm.OpenForm(new RegisterForm());
            }
        }

        private void PlayForm_Load(object sender, EventArgs e)
        {
            listenForQuestion();
        }

        private void dBtn_Click(object sender, EventArgs e)
        {
            if (dBtn.Text.Equals(correctAns))
            {
                MessageBox.Show("Correct Answer");
                ClientSocket.SendString("my_answer~" + dBtn.Text);
            }
            else
            {
                MessageBox.Show("You are disqualified", "Incorrect Answer");
                MainForm.OpenForm(new RegisterForm());
            }
        }

        private void checkWinner(string v)
        {
            throw new NotImplementedException();
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            ClientSocket.SendString("skip_turn");
            skipTurn();
        }

        private void skipTurn()
        {
            skipButton.Enabled = false;
        }
    }
}
