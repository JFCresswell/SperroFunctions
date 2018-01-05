using SperroFunctions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.Responses
{
    public class GameResponse : Response
    {
        // consider temporary token
        public int Id { get; set; } 

        public string Title { get; set; }

        public string Description { get; set; }

        public GamePublisher Publisher { get; set; }
    }
}
