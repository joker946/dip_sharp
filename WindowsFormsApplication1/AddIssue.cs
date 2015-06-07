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
using Newtonsoft.Json.Linq;
namespace WindowsFormsApplication1
{
    public partial class AddIssue : Form
    {
        public AddIssue()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AddIssue_Load(object sender, EventArgs e)
        {
            var req = new ServerConnection("/projects/", Method.GET);
            req.Execute();
            JObject jo = JObject.Parse(req.text);
            IList<JToken> project_list = jo["Projects"].Children().ToList();
            foreach (var x in project_list){
                Project pr = JsonConvert.DeserializeObject<Project>(x.ToString());
                if (pr.title != null)
                {
                    projectList.Items.Add(pr.title);
                }
            }
            req = new ServerConnection("/users/", Method.GET);
            req.Execute();
            jo = JObject.Parse(req.text);
            IList<JToken> user_list = jo["Users"].Children().ToList();
            foreach (var x in user_list)
            {
                User ur = JsonConvert.DeserializeObject<User>(x.ToString());
                if (ur.login_name != null)
                {
                    userList.Items.Add(ur.login_name);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
