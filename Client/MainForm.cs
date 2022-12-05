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
        public static void OpenForm(Form form)
        {
            control.Clear();

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.Show();
            control.Add(form);
        }
        public static Control.ControlCollection control;
        public MainForm()
        {
            InitializeComponent();
            control = this.mainPanel.Controls;

            OpenForm(new RegisterForm());
        }
    }
}
