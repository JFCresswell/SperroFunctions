using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.Models
{
    public class Sponsor
    {
       public SponsorType Type { get; set; }

        public Address Address { get; set; }
        
        public IList<Prize> Prizes { get; private set; }

        public void AddPrize(Prize prize)
        {
            this.Prizes.Add(prize);
        }
    }
}
