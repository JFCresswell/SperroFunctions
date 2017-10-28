using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.Models
{
    public class DispositionTableEntity : BaseTableEntity
    {
        public DateTime DecisionDateAndTime { get; set; }
        public int Decision { get; set; }
        public string ResponseJson { get; set; }
    }
}
