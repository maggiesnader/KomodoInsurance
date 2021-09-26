using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomodoInsurance_POCO;

namespace KomodoInsurance_Repo
{
    public class DevTeamRepo
    {
        private List<DevTeam> _ListOfDevTeams = new List<DevTeam>();
        private int _idCounter = default;
       
        //Create
        public bool AddDevTeamToList(DevTeam devTeamToBeAdded)
        {
            if(devTeamToBeAdded != null)
            {
                devTeamToBeAdded.TeamID = ++_idCounter;
                _ListOfDevTeams.Add(devTeamToBeAdded);
                return true;
            }
            return false;
        }

        //Read
        public List<DevTeam> ViewAllDevTeams()
        {
            return _ListOfDevTeams;
        }

        public DevTeam GetDevTeamByTeamName(string name)
        {
            foreach (var devTeam in _ListOfDevTeams)
            {
                if (devTeam.TeamName == name)
                {
                    return devTeam;
                }
            }
            return null;
        }

        public DevTeam GetDevTeamByTeamID(int id)
        {
            foreach (var devTeam in _ListOfDevTeams)
            {
                if (devTeam.TeamID == id)
                {
                    return devTeam;
                }
            }
            return null;
        }

        public DevTeam GetByTeamType(string type)
        {
            foreach (var devTeam in _ListOfDevTeams)
            {
                if (devTeam.TypeOfTeam.ToString() == type)
                {
                    return devTeam;
                }
            }
            return null;
        }

        public Developer GetDevelopersInDevTeamByTeamId(int teamId)
        {
            foreach (var developer in _ListOfDevTeams)
            {
                if (developer.TeamID == teamId)
                {
                    return developer;
                }
            }
            return null;
        }

        //Update
        public bool UpdateExistingDevTeam(int teamId, DevTeam updatedDevTeam)
        {
            DevTeam oldDevTeamInfo = GetDevTeamByTeamID(teamId);

            if (oldDevTeamInfo != null)
            {
                oldDevTeamInfo.TeamName = updatedDevTeam.TeamName;
                oldDevTeamInfo.TypeOfTeam = updatedDevTeam.TypeOfTeam;
            }
            return false;
        }

        //Delete
        public bool RemoveDevTeamFromList(int id)
        {
            DevTeam devTeam = GetDevTeamByTeamID(id);

            if (devTeam == null)
            {
                return false;
            }

            int initialCount = _ListOfDevTeams.Count;
            _ListOfDevTeams.Remove(devTeam);

            if (initialCount > _ListOfDevTeams.Count)
            {
                return true;
            }
            return false;
        }
    }
}
