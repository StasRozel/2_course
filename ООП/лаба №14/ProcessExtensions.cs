using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба__14
{
    public static class ProcessExtensions
    {
        public static TimeSpan? GetTotalProcessorTime(this Process process)
        {
            try { return process.TotalProcessorTime; }
            catch { return null; }
        }
        
        public static DateTime? GetStartTime(this Process process)
        {
            try { return process.StartTime; }
            catch { return null; }
        }
    }   
}
