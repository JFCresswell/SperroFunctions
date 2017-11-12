using SperroFunctions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SperroFunctions.Models;

namespace SperroFunctions.StorageRepository
{
    public class GameRepository : IGameRepository
    {
        public void Create(Game entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Game entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Game> FindActve()
        {
            var activeGames = new List<Game>();

            activeGames.Add(new Game()
            {
                Id = 1,
                Title = "Random Run",
                Description = "Total randomness",
                Publisher = new GamePublisher()
            });

            return activeGames.AsEnumerable<Game>();
        }

        public IEnumerable<Game> FindAll()
        {
            throw new NotImplementedException();
        }

        public Game GetById(int id)
        {
            return new Game()
            {
                Id = 2,
                Title = "Temporary game",
                Description = "Just to test interface",
                Publisher = new GamePublisher()
                {
                    CompanyName = "Activision"
                }
            };
        }

        public void Update(Game entity)
        {
            throw new NotImplementedException();
        }
    }
}
