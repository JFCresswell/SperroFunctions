using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.Responses
{
    public enum ResponseCode : int
    {
        // these responses would conditions that go with a 'success' result; i.e. the HTTP request returns a good result, no 400/500 series result
        // however they could indicate a negative result 

        // pure success
        Success = 0
            
        // higher level 
    }
}
