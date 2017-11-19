using SperroFunctions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer, int>
    {
        IEnumerable<Prize> FindAll();
    }
}
