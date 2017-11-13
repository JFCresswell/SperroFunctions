using SperroFunctions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.Interfaces
{
    public interface IPrizeRepository : IRepository<Prize, int>
    {
        IEnumerable<Prize> FindAll();

        IEnumerable<Prize> FindActve();
    }
}
