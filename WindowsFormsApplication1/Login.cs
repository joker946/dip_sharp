using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var t = new LoginRequest();
            t.user = textBox1.Text;
            t.password = textBox2.Text;
            var req = new ServerConnection("/login/", Method.POST, t);
            req.Execute();
            if (req.status == ServerResponseStatus.Good)
            {
                var mm = new MainMenu();
                mm.Show();
                this.Hide();
            }
            else if(req.status == ServerResponseStatus.Lost)
            {
                MessageBox.Show(req.text);
            }
            else if (req.status == ServerResponseStatus.Bad)
            {
                MessageBox.Show(req.text);
            }
        }
    }
    
}
