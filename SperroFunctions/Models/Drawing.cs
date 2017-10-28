using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.Models
{
    public class Drawing
    {
        public int Id { get; set; }

        public int PrizeId { get; set; }

        public int SponsorId { get; set; }
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }


    }
}
