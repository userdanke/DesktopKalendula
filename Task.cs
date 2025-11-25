using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopKalendula
{
    public class Task
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string name { get; set; }
        public List<string> users { get; set; } = new List<string>();
        public string description { get; set; } = "";
        public string hoursDedicated { get; set; } = "";
        public string startDate { get; set; } = "";
        public string deadline { get; set; } = "";
        public string state { get; set; } = "Pendiente";
        public List<SubTasks> subTasks { get; set; } = new List<SubTasks>();
    }

}
