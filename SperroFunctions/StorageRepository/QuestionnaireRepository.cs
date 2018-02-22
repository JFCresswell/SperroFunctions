using SperroFunctions.Interfaces;
using SperroFunctions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.StorageRepository
{
    public class QuestionnaireRepository : IQuestionnaireRepository
    {
        private IList<Questionnaire> questionnaires = new List<Questionnaire>();

        public void Create(Questionnaire entity)
        {
            this.questionnaires.Add(entity);
        }

        public void Delete(Questionnaire entity)
        {
            this.questionnaires.Remove(entity);
        }

        public Questionnaire GetById(int id)
        {
            return this.questionnaires.Where(q => q.Id == id).FirstOrDefault();
        }

        public void Update(Questionnaire entity)
        {
            var idx = this.questionnaires.IndexOf(entity);

            if (idx == -1)
            {
                this.questionnaires[idx] = entity;
            }
        }
     }
}
