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
        private bool allowSkip = true;
        public PlayForm(string nickname,string numOfPlayer, string numOfQues, string playerIdx)
        {
            InitializeComponent();
            this.nicknameLb.Text = nickname;
        }
    }
}
