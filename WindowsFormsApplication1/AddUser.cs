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
namespace WindowsFormsApplication1
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = new User();
            user.login_name = loginBox.Text;
            user.first_name = nameBox.Text;
            user.last_name = lastNameBox.Text;
            user.email = emailBox.Text;
            user.password = passwordBox.Text;
            var req = new ServerConnection("/users/", Method.POST, user);
            req.Execute();
            if (req.status == ServerResponseStatus.Good)
            {
                MessageBox.Show(req.text);
            }else if (req.status == ServerResponseStatus.Lost)
            {
                MessageBox.Show(req.text);
            }else if (req.status == ServerResponseStatus.Bad)
            {
                MessageBox.Show(req.text);
            }
        }
    }
}
