using SperroFunctions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.Interfaces
{
    public interface ISponsorRepository : IRepository<Sponsor, int>
    {
        IEnumerable<Sponsor> FindAll();
    }
}
