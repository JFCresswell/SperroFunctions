using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.Models
{
    public class Disposition
    {
        public DateTime DecisionDateAndTime { get; set; }

        public int DispositionCode { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
