using SperroFunctions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.Interfaces
{
    public interface IGameRepository : IRepository<Game, int>
    {
        IEnumerable<Game> FindAll();

        IEnumerable<Game> FindActve();
    }
}
