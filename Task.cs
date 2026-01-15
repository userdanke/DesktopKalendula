using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DesktopKalendula
{
    public enum TaskState
    {
        ToDo = 0,
        InProgress = 1,
        Complete = 2
    }
    public class Task
    {
        public string id { get; set; } = Guid.NewGuid().ToString();
        public string name { get; set; }
        public List<string> users { get; set; } = new List<string>();
        public string description { get; set; } = "";
        public TimeSpan hoursDedicated { get; set; } = TimeSpan.Zero;
        [JsonConverter(typeof(CustomDateTimeConverter1))]
        public DateTime startDate { get; set; }
        [JsonConverter(typeof(CustomDateTimeConverter1))]
        public DateTime deadline { get; set; }
        public TaskState state { get; set; }
        public List<SubTasks> subTasks { get; set; } = new List<SubTasks>();
    }

    public class CustomDateTimeConverter1 : IsoDateTimeConverter
    {
        public CustomDateTimeConverter1()
        {
            DateTimeFormat = "yyyy-MM-dd";
        }
    }

}
