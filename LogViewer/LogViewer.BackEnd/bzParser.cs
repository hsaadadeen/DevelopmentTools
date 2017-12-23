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
            List<string> lines = System.IO.File.ReadAllLines(path).ToList();
            var validLines = lines.Where(r => r.Split('|').Count() >= 4).ToList();

            List<NlogEntity> logLines  = new List<NlogEntity>();

            foreach (string line in validLines)
            {
                var lineSplits = line.Split('|');

                if (lineSplits.Count() == 4)
                {
                    var lineIndex = lines.IndexOf(line);
                    var currIndex = lineIndex;
                    while (currIndex < lines.Count && lines[lineIndex].Last() != '|')
                    {
                        lines[lineIndex] += "\n" + lines[++currIndex];
                    }

                    lineSplits = lines[lineIndex].Split('|');
                    logLines.Add(new NlogEntity()
                    {
                        LogTime = Convert.ToDateTime(lineSplits[0]),
                        Level = lineSplits[1],
                        CallStack = lineSplits[2],
                        Message = lineSplits[3]
                    });
                }
                else
                {
                    logLines.Add(new NlogEntity()
                    {
                        LogTime = Convert.ToDateTime(lineSplits[0]),
                        Level = lineSplits[1],
                        CallStack = lineSplits[2],
                        Message = lineSplits[3]
                    });
                }
            }

            return logLines;
        }
    }
}
