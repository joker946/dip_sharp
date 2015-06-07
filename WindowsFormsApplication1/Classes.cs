using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class LoginRequest
    {
        public string user { get; set; }
        public string password { get; set; }
    }
    public class User
    {
        public int id { get; set; }
        public string login_name { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
    public class Project
    {
        public int id { get; set; }
        public string title { get; set; }
        public string expiration_date { get; set; }
        public string date_created { get; set; }
        public string url { get; set; }
        public string description { get; set; }
    }
    public class Issue
    {
        public int id { get; set; }
        public string name { get; set; }
        public string current_version { get; set; }
        public string date_created { get; set; }
        public string expiration_time { get; set; }
        public string real_expiration_time { get; set; }
        public string status { get; set; }
        public string description { get; set; }
        public string priority { get; set; }
        public string comment { get; set; }
    }
}
