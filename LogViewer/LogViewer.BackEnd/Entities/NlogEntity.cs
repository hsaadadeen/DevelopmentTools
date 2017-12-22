using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogViewer.BackEnd.Entities
{
    public class NlogEntity
    {
        public DateTime LogTime { get; set; }

        public string Level { get; set; }

        public string CallStack { get; set; }

        public string Message { get; set; }
    }
}
