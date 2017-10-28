using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.Models
{
    public enum DispositionCode : Int16
    {
        Pending,
        Approved,
        Waivered,  // not at Sperro standard but expected to move to standard
        Rejected
    }
}
