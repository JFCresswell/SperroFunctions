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
        public void Create(Prize entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Prize entity)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public Prize GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Prize entity)
        {
            throw new NotImplementedException();
        }
    }
}
