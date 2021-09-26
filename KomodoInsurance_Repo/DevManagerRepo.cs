using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KomodoInsurance_POCO;

namespace KomodoInsurance_Repo
{
    public class DevManagerRepo 
    {
        private List<DevManager> _ListOfDevManagers = new List<DevManager>();
        private int _idCounter = 1000;

        //CREATE
        public bool AddDevManagerToList(DevManager devManagerToBeAdded)
        {
            if (devManagerToBeAdded != null)
            {
                devManagerToBeAdded.ManagerID = ++_idCounter;
                _ListOfDevManagers.Add(devManagerToBeAdded);
                return true;
            }
            return false;
        }

        //READ
        public List<DevManager> ViewAllDevManagers()
        {
            return _ListOfDevManagers;
        }
        
        public DevManager GetDevManagerByName (string name)
        {
            foreach (var devManager in _ListOfDevManagers)
            {
                if(devManager.Name == name)
                {
                    return devManager;
                }
            }
            return null;
        }

        public DevManager GetDevManagerByID (int id)
        {
            foreach (var devManager in _ListOfDevManagers)
            {
                if (devManager.ManagerID == id)
                {
                    return devManager;
                }
            }
            return null;
        }

        public DevManager GetManagerByTeamID(int teamId)
        {
            foreach (var devManager in _ListOfDevManagers)
            {
                if (devManager.TeamID == teamId)
                {
                    return devManager;
                }
            }
            return null;
        }

        public DevManager GetManagerByTeamName(string teamName)
        {
            foreach (var devManager in _ListOfDevManagers)
            {
                if (devManager.TeamName == teamName)
                {
                    return devManager;
                }
            }
            return null;
        }

        //UPDATE
        public bool UpdateExistingDevManager(int id, DevManager updatedDevManager)
        {
            DevManager oldDevManagerInfo = GetDevManagerByID(id);

            if (oldDevManagerInfo != null)
            {
                oldDevManagerInfo.ManagerID = updatedDevManager.ManagerID;
            }
            return false;
        }

        //DELETE
        public bool RemoveDevManagerFromList(int id)
        {
            DevManager devManager = GetDevManagerByID(id);

            if (devManager == null)
            {
                return false;
            }

            int initialCount = _ListOfDevManagers.Count;
            _ListOfDevManagers.Remove(devManager);

            if (initialCount > _ListOfDevManagers.Count)
            {
                return true;
            }
            return false;
        }
    }
}
