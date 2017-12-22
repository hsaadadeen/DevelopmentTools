using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogViewer.BackEnd.Entities;

namespace LogViewer.BackEnd
{
    public class bzParser
    {
        public object ParseLogFile(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);

            return (from line in lines
                select line.Split('|')
                into lineSplits
                where lineSplits.Count() >= 4
                select new NlogEntity()
                {
                    LogTime = Convert.ToDateTime(lineSplits[0]), Level = lineSplits[1], CallStack = lineSplits[2], Message = lineSplits[3]
                }).ToList();
        }
    }
}
