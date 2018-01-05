using SperroFunctions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.Responses
{
    public class SponsorResponse : Response
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Prize> Prizes { get; private set; }
    }
}
