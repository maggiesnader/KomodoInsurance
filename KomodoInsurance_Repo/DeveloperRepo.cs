using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomodoInsurance_POCO;

namespace KomodoInsurance_Repo
{
    public class DeveloperRepo
    {
        private List<Developer> _ListOfDevelopers = new List<Developer>();
        

        //CREATE
        public bool AddDeveloperToList(Developer developerToBeAdded)
        {
            if (developerToBeAdded != null)
            {
                _ListOfDevelopers.Add(developerToBeAdded);
                return true;
            }
            return false;
        }

        //Read
        public List<Developer> ViewAllDevelopers()
        {
            return _ListOfDevelopers;
        }

        public Developer GetBySpecialty(string specialty)
        {
            foreach (var developer in _ListOfDevelopers)
            {
                if (developer.SpecialtyOfDeveloper.ToString() == specialty)
                {
                    return developer;
                }
            }
            return null;
        }

        public Developer GetByExperience(string experience)
        {
            foreach (var developer in _ListOfDevelopers)
            {
                if (developer.LevelOfExperience.ToString()== experience)
                {
                    return developer;
                }
                return null;
            }
            return null;
        }

        public Developer GetDeveloperByEmployeeId(int id)
        {
            foreach (var developer in _ListOfDevelopers)
            {
                if (developer.ID == id)
                {
                    return developer;
                }
            }
            return null;
        }

        public Developer GetDeveloperByName(string name)
        {
            foreach (var developer in _ListOfDevelopers)
            {
                if (developer.Name == name)
                {
                    return developer;
                }
                return null;
            }
            return null;
        }

        public Developer GetDeveloperByPluralsightAccess()
        {
            foreach (var developer in _ListOfDevelopers)
            {
                if (developer.HasAccessToPluralsight == true)
                {
                    return developer;
                }
                return null;
            }
            return null;
        }

        //Update
        public bool UpdateExistingDeveloper(int id, Developer updatedDeveloperInfo)
        {
            Developer oldDeveloperInfo = GetDeveloperByEmployeeId(id);

            if (oldDeveloperInfo != null)
            {
                oldDeveloperInfo.SpecialtyOfDeveloper = updatedDeveloperInfo.SpecialtyOfDeveloper;
                oldDeveloperInfo.LevelOfExperience = updatedDeveloperInfo.LevelOfExperience;
                return true;
            }
            return false;
        }

        //Delete
        public bool RemoveDeveloperFromList(int id)
        {
            Developer developer = GetDeveloperByEmployeeId(id);

            if (developer == null)
            {
                return false;
            }

            int initialCount = _ListOfDevelopers.Count;
            _ListOfDevelopers.Remove(developer);

            if (initialCount > _ListOfDevelopers.Count)
            {
                return true;
            }
            return false;
        }

    }
}
