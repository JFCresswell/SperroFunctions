using SperroFunctions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.Interfaces
{
    public interface IQuestionnaireRepository
    {
        Questionnaire GetQuestionnaire(int id);

        void UpdateQuestionnaire(Questionnaire questionnaire);
    }
}
