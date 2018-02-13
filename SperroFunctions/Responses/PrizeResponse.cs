using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.Responses
{
    public class PrizeResponse : Response
    {
        public int Id { get; set; }

        public string ShortDescription { get; set; }

        public string FullDescription { get; set; }

        public DateTime AvailableDate { get; set; }

        public DateTime AwardedDate { get; set; }

        public Decimal CashValue { get; set; }

    }
}
