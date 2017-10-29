using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.Models
{
    public class MarketplaceSnapshot
    {
        public Guid SnapshotId { get; set; }

        public IList<DrawingEntry> Drawings { get; set; }

        public IList<GameAllocation> GamePointAllocations { get; set; }
    }
}
