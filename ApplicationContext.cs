using Newtonsoft.Json;
using Rostelekek_WPF_API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rostelekek_WPF_API
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

public class Worker
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string experience { get; set; }
        public string position { get; set; }
    }
    public class Request
    {
        public string statusCode { get; set; }
        public string message { get; set; }
        public string error { get; set; }
    }
    class Worker1
    {
        public string login { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string experience { get; set; }
        public string position { get; set; }
    }
}
