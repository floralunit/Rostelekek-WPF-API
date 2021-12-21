using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rostelekek_WPF_API
{
    public class Root
    {
        public List<string> MyArray { get; set; }
    }

    public class Art
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string date { get; set; }
        public string place { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public List<string> pics { get; set; }
    }

    public class Worker
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    }
}
