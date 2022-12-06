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
            try
            {
                panel.Controls.Clear();
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                form.Show();
                panel.Controls.Add(form);
            }
            catch (Exception)
            {
                panel.Invoke(new Action(() => panel.Controls.Clear()));
                //form.TopLevel = false;
                //form.Dock = DockStyle.Fill;
                //form.Show();
                //form.Invoke(new Action(() => form.TopLevel = false));
                //form.Invoke(new Action(() => form.Dock = DockStyle.Fill));
                //form.Invoke(new Action(() => form.Show()));
                //panel.Invoke(new Action(() => panel.Controls.Add(form)));
            }

        }
        public static Panel panel;
        public MainForm()
        {
            InitializeComponent();
            panel = mainPanel;
            OpenForm(new RegisterForm());
        }

        internal static void OpenPlayForm(string nickname, string v1, string v2, string v3)
        {
            Form form = new PlayForm(nickname, v1, v2, v3);
            try
            {
                panel.Controls.Clear();
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                form.Show();
                panel.Controls.Add(form);
            }
            catch (Exception)
            {
                panel.Invoke(new Action(() => panel.Controls.Clear()));
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                form.Show();
                //form.Invoke(new Action(() => form.TopLevel = false));
                //form.Invoke(new Action(() => form.Dock = DockStyle.Fill));
                //form.Invoke(new Action(() => form.Show()));
                //panel.Invoke(new Action(() => panel.Controls.Add(form)));
            }
        }
    }
}
