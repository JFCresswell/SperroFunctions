using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.Models
{
    public enum GameApprovalStatus : Int16
    {
        NotSubmitted,
        Pending,
        Approved,
        Deferred,    // 
        Rejected
    }
}
