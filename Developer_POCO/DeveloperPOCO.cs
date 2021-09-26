using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Developer_POCO;

namespace KomodoInsurance_POCO
{
    public class Developer : Employee
    {
        public Developer() { }

        public Developer(DeveloperSpecialty developerSpecialty, ExperienceLevel experienceLevel, bool hasAccessToPluralsight /*DateTime pluralsightExpirationDate*/)
        {
            SpecialtyOfDeveloper = developerSpecialty;
            LevelOfExperience = experienceLevel;
            HasAccessToPluralsight = hasAccessToPluralsight;
            //PluralsightExpirationDate = pluralsightExpirationDate;
        }

        public DeveloperSpecialty SpecialtyOfDeveloper { get; set; }
        public ExperienceLevel LevelOfExperience { get; set; }
        public bool HasAccessToPluralsight { get; set; }
        //public DateTime PluralsightExpirationDate { get; set; }
    }
}
