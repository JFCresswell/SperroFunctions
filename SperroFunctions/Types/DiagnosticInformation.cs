using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.Types
{
    public class DiagnosticInformation
    {
        public DateTime Timestamp { get; set; }

        public string Topic { get; set; }

        public string Diagnostic { get; set; }
    }
}
