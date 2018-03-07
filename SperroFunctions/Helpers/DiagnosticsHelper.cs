using SperroFunctions.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.Helpers
{
    public static class DiagnosticsHelper
    {
        public static List<DiagnosticInformation> Diagnostics (string parms)
        {
            var diagnostics = new List<DiagnosticInformation>();

            var flags = DiagnosticsHelper.Flags(parms);

            foreach (var flag in flags)
            {
                diagnostics.Add(DiagnosticsHelper.Diagnostic(flag));
            }
            return diagnostics;
        }

    private static List<string> Flags (string parms)
        {
            var flags = new List<string>();

            string[] f = parms.Split('|');

            foreach (var s in f)
            {
                flags.Add(s);
            }

            return flags;
        }

        private static DiagnosticInformation Diagnostic(string flag)
        {
            switch (flag)
            {
                default:
                    break;
            }

            return new DiagnosticInformation()
            {
                Timestamp = DateTime.Now,
                Topic = flag,
                Diagnostic = "No diagnostic information available"
            };
        }
    }

}
