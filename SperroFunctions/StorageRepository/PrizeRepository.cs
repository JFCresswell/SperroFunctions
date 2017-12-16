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
            var activePrizes = new List<Prize>();

            activePrizes.Add(new Prize()
            {
                Id = 1,
                ShortDescription = "Chiefs tickets",
                FullDescription = "Tickets on the 50 yard line",
                CashValue = 100.00M,
                Category = PrizeCategory.Merchandise,
                AvailableDate = new DateTime(2017, 12, 1)
            });

            return activePrizes.AsEnumerable<Prize>();
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
            int offset = -1;

            for (int idx = 0; idx < this.prizes.Count; idx++)
            {
                if (this.prizes[idx].Id == entity.Id)
                {
                    offset = idx;
                    break;
                }
            }

            if (offset != -1)
            {
                this.prizes[offset] = entity;
            }
        }
    }
}
