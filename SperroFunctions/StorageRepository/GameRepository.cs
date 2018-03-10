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

        public int Count
        {
            get
            {
                return this.games.Count();
            }
        }

        public void Create(Game entity)
        {
            this.games.Add(entity);
        }

        public void Delete(Game entity)
        {
            this.games.Remove(entity);
        }

        public IEnumerable<Game> FindActve()
        {
            return this.games.Where(g => g.Status == GameApprovalStatus.Approved);
        }

        public IEnumerable<Game> FindAll()
        {
            return this.games.AsEnumerable();
        }

        public IEnumerable<Game> FindSubmitted()
        {
            return this.games.Where(g => g.Status == GameApprovalStatus.Pending);
        }

        public Game GetById(int id)
        {
            return this.games.Where(g => g.Id == id).FirstOrDefault();
        }

        public void Update(Game entity)
        {
            var idx = this.games.IndexOf(entity);

            if (idx != -1)
            {
                this.games[idx] = entity;
            }
        }
    }
}
