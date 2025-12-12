using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DesktopKalendula
{
    public class Project
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string name { get; set; }
        public string description { get; set; }
        [JsonConverter(typeof(CustomDateTimeConverter2))]
        public DateTime startDate { get; set; }
        [JsonConverter(typeof(CustomDateTimeConverter2))]
        public DateTime endDate { get; set; }
        public List<string> users { get; set; } = new List<string>();
        public List<Task> tasks { get; set; } = new List<Task>();
    }

    public class CustomDateTimeConverter2 : IsoDateTimeConverter
    {
        public CustomDateTimeConverter2()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }

}
