using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DesktopKalendula
{
    public class Project
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string name { get; set; }
        public string description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public List<string> users { get; set; } = new List<string>();
        public List<Task> tasks { get; set; } = new List<Task>();


    }

}
