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
        // temporary
        private IList<Game> games = new List<Game>();

        public void Create(Game entity)
        {
            games.Add(entity);
        }

        public void Delete(Game entity)
        {
            games.Remove(entity);
        }

        public IEnumerable<Game> FindActve()
        {
            return games.Where(g => g.Status == GameApprovalStatus.Approved);
        }

        public IEnumerable<Game> FindAll()
        {
            return games.AsEnumerable();
        }

        public Game GetById(int id)
        {
            return games.Where(g => g.Id == id).FirstOrDefault();
        }

        public void Update(Game entity)
        {
            int offset = -1;

            for (int idx = 0; idx < games.Count; idx++)
            {
                if (games[idx].Id == entity.Id)
                {
                    offset = idx;
                    break;
                }
            }

            if (offset != -1)
            {
                this.games[offset] = entity;
            }
        }
    }
}
