using SperroFunctions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SperroFunctions.Models;

namespace SperroFunctions.StorageRepository
{
    public class SponsorRepository : ISponsorRepository
    {
        public void Create(Sponsor entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Sponsor entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sponsor> FindAll()
        {
            var sponsors = new List<Sponsor>();

            sponsors.Add(new Sponsor()
            {
                Id = 1,
                Name = "1st Baptist Church",
                Address = new Address()
                {
                    Street1 = "100 Main St.",
                    City = "Anytown",
                    State = "Missouri",
                    PostalCode = "64131",
                    Country = "US"
                },
                Type = SponsorType.Church
            });

            return sponsors.AsEnumerable<Sponsor>();
        }

        public Sponsor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Sponsor entity)
        {
            throw new NotImplementedException();
        }
    }
}
