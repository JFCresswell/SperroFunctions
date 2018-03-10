using SperroFunctions.DependencyInjection.DependencyInjection;
using SperroFunctions.Interfaces;
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
        public static List<string> Flags (string parms)
        {
            var flags = new List<string>();

            if (!string.IsNullOrEmpty(parms))
            {
                string[] f = parms.Split('|');

                foreach (var s in f)
                {
                    flags.Add(s);
                }
            }

            return flags;
        }
    }

}
