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

        public int Count
        {
            get
            {
                return customers.Count();
            }
        }

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
            var idx = this.customers.IndexOf(entity);

            if (idx != -1)
            {
                 this.customers[idx] = entity;
            }
        }
    }
}
