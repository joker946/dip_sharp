using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var ai = new AddIssue();
            ai.Show();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var au = new AddUser();
            au.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ap = new AddProject();
            ap.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var lr = new ListReport();
            lr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var lp = new ListProject();
            lp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var li = new ListIssue();
            li.Show();
        }
    }
}
