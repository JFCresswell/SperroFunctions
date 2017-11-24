using SperroFunctions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SperroFunctions.Models;

namespace SperroFunctions.StorageRepository
{
    public class CustomerRepository : ICustomerRepository
    {
        // temporary
        private IList<Customer> customers = new List<Customer>();

        public void Create(Customer entity)
        {
            // TODO: check for duplicates, etc. 
            this.customers.Add(entity);
        }

        public void Delete(Customer entity)
        {
            this.customers.Remove(entity);
        }

        public IEnumerable<Customer> FindAll()
        {
            return this.customers.AsEnumerable();
        }

        public Customer GetById(int id)
        {
            return this.customers.Where(c => c.Id == id).FirstOrDefault();
        }

        public void Update(Customer entity)
        {
            int offset = -1;

            for (int idx = 0; idx < this.customers.Count; idx++)
            {
                if (this.customers[idx].Id == entity.Id)
                {
                    offset = idx;
                    break;
                }
            }

            if (offset != -1)
            {
                this.customers[offset] = entity;
            }
        }
    }
}
