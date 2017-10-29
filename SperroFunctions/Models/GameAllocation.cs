using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.Models
{
    public class GameAllocation
    {
        public int CustomerId { get; set; }

        public int GameId { get; set; }

        public int PointsAllocated { get; set; }
    }
}
