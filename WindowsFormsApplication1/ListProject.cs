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
    public partial class ListProject : Form
    {
        public ListProject()
        {
            InitializeComponent();
        }

        private void ListProject_Load(object sender, EventArgs e)
        {
            var req = new ServerConnection("/projects/", Method.GET);
            req.Execute();
            JObject jo = JObject.Parse(req.text);
            IList<JToken> project_list = jo["Projects"].Children().ToList();
            foreach (JToken r in project_list)
            {
                Project p = JsonConvert.DeserializeObject<Project>(r.ToString());
                dataGridView1.Rows.Add(new string[] { p.id.ToString(), p.title, p.date_created, p.url, p.description });
            }
        }
    }
}
