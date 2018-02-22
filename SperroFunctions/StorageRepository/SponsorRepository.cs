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
        // temporary
        private IList<Sponsor> sponsors = new List<Sponsor>();

        public void Create(Sponsor entity)
        {
            sponsors.Add(entity);
        }

        public void Delete(Sponsor entity)
        {
            this.sponsors.Remove(entity);
        }

        public IEnumerable<Sponsor> FindAll()
        {
            return sponsors.AsEnumerable<Sponsor>();
        }

        public Sponsor GetById(int id)
        {
            return this.sponsors.Where(s => s.Id == id).FirstOrDefault();
        }

        public void Update(Sponsor entity)
        {
            var idx = this.sponsors.IndexOf(entity);

            if (idx == -1)
            {
                this.sponsors[idx] = entity;
            }
        }
    }
}
