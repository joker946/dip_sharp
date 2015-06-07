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
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var project = new Project();
            project.title = titleBox.Text;
            project.expiration_date = expirationBox.Text;
            project.url = urlBox.Text;
            project.description = descBox.Text;
            var req = new ServerConnection("/projects/", Method.POST, project);
            req.Execute();
            if (req.status == ServerResponseStatus.Good)
            {
                MessageBox.Show(req.text);
            }
            else if (req.status == ServerResponseStatus.Lost)
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
