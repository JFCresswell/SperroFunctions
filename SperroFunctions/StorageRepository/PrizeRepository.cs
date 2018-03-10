using SperroFunctions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SperroFunctions.Models;

namespace SperroFunctions.StorageRepository
{
    public class PrizeRepository : IPrizeRepository
    {
        // temporary
        private IList<Prize> prizes = new List<Prize>();

        public int Count
        {
            get
            {
                return this.prizes.Count();
            }
        }

        public int ActiveCount
        {
            get
            {
                return this.prizes.Where(p => p.SubmitStatus == PrizeSubmitStatus.Accepted).Count();
            }
        }

        public int PendingCount
        {
            get
            {
                return this.prizes.Where(p => p.SubmitStatus == PrizeSubmitStatus.Pending).Count();
            }
        }

        public void Create(Prize entity)
        {
            this.prizes.Add(entity);
        }

        public void Delete(Prize entity)
        {
            this.prizes.Remove(entity);
        }

        public IEnumerable<Prize> FindActve()
        {
           return this.prizes.Where(p => p.SubmitStatus == PrizeSubmitStatus.Accepted);
        }

        public IEnumerable<Prize> FindAll()
        {
            return this.prizes.AsEnumerable();
        }

        public Prize GetById(int id)
        {
            return this.prizes.Where(p => p.Id == id).FirstOrDefault();
        }

        public void Update(Prize entity)
        {
            var idx = this.prizes.IndexOf(entity);

            if (this.prizes.IndexOf(entity) != -1)
            {
                this.prizes[idx] = entity;
            }
        }
    }
}
