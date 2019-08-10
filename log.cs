using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrammarChecker
{
    class log
    {
        private static log instance;
        private static string gLog;

        private log()
        {
            ClearLog();
        }

        public static log Instance
        {
            get
            {
                if (instance == null)
                    instance = new log();
                return instance;
            }
        }

        public void ClearLog()
        {
            gLog = string.Empty;
        }

        public void AppendLogText(string input)
        {
            gLog += input;
        }

        public void AppendLogLine(string input)
        {
            AppendLogText(input + "\r\n");
        }

        public string GetLogText()
        {
            return gLog;
        }
    }
}
