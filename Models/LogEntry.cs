using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eSports.Models
{
    // Uma linha do registo de logs
    public class LogEntry
    {
        public DateTime Date { get; set; }
        public string Action { get; set; } = "";
        public string Details { get; set; } = "";
    }
}
