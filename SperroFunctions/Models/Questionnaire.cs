using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.Models
{
    public class Questionnaire
    {
        // basic information
        public Customer Customer { get; set; }

        public int Gender { get; set; }

        public int EducationLevel { get; set; }

        public int IncomeRange { get; set; }

        public int HouseholdSize { get; set; }

        public int HouseholdIncomeRange { get; set; }

        public int MaritalStatus { get; set; }

        public int LivingSituation { get; set; }
    }
}
