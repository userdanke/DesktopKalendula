using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;

namespace DesktopKalendula
{
    public enum SubtaskState
    {
        ToDo = 0,
        InProgress = 1,
        Complete = 2
    }
    public class SubTasks
    {
        public string parentTaskId { get; set; }
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string name { get; set; }
        public List<string> users { get; set; } = new List<string>();
        public string description { get; set; } = "";
        public TimeSpan hoursDedicated { get; set; } = TimeSpan.Zero;
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime startDate { get; set; }
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime deadline { get; set; }

        public SubtaskState state { get; set; }
    }

    public class CustomDateTimeConverter : IsoDateTimeConverter
    {
        public CustomDateTimeConverter()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
