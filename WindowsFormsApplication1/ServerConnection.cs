using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using Newtonsoft.Json.Linq;
namespace WindowsFormsApplication1
{
    enum ServerResponseStatus
    {
        Good,
        Bad,
        Lost
    }
    class ServerConnection
    {
        public string text { get; set; }
        public ServerResponseStatus status { get; set; }
        private RestClient client { get; set; }
        private RestRequest request { get; set; }
        public ServerConnection(string path, Method method, object obj=null)
        {
            string endPoint = @"http://192.168.10.104:5000";
            this.client = new RestClient(endPoint);
            this.request = new RestRequest(path, method);
            request.RequestFormat = DataFormat.Json;
            if (obj != null)
            {
                request.AddBody(obj);
            }
            request.AddHeader("Content-Type", "application/json");
            
        }
        public void Execute()
        {
            var r = this.client.Execute(request);
            if (r.ResponseStatus == ResponseStatus.Completed && r.StatusCode == System.Net.HttpStatusCode.OK)
            {
                this.status = ServerResponseStatus.Good;
                this.text = r.Content;
            }
            else if (r.ResponseStatus == ResponseStatus.Error)
            {
                this.status = ServerResponseStatus.Lost;
                this.text = "Can't establish connection with server";
            }
            else if (r.StatusCode == System.Net.HttpStatusCode.InternalServerError)
            {
                this.status = ServerResponseStatus.Bad;
                this.text = "Wrong login or password";
            }
        }

        public List<Object> getList(string o)
        {
            var jo = JObject.Parse(o);
            string resource = "";
            foreach (var x in jo.Properties())
            {
                resource = x.Name;
            }
            IList<JToken> user_list = jo[resource].Children().ToList();
            Type t = Type.GetType(resource);
            //IList<t> object_list = null;
            foreach (var x in user_list)
            {
                if (resource == "Users")
                {

                }
                //var ur = JsonConvert.DeserializeAnonymousType(x.ToString(), User);
            }
            return null;
        }
    }
}
