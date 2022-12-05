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
    public partial class MainForm : Form
    {
        public static void OpenPlayForm()
        {
            control.Clear();

            Form playForm = new PlayForm();
            playForm.TopLevel = false;
            playForm.Dock = DockStyle.Fill;
            playForm.Show();
            control.Add(playForm);
        }
        public static Control.ControlCollection control;
        public MainForm()
        {
            InitializeComponent();
            control = this.mainPanel.Controls;

            Form registerForm = new RegisterForm();
            registerForm.TopLevel = false;
            registerForm.Dock = DockStyle.Fill;
            registerForm.Show();
            this.mainPanel.Controls.Add(registerForm);
        }
    }
}
