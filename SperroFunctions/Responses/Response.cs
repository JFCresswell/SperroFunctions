using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.Responses
{
    public class Response
    {
        public ResponseCode Code { get; private set; }

        public string Message { get; private set; }
    }
}
