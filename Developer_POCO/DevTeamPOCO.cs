using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Developer_POCO;

namespace KomodoInsurance_POCO
{
    public class DevTeam : Developer
    {
        public DevTeam() { }

        public DevTeam(string teamName, TeamType teamType, List<Developer> teamMembers)
        {
            TeamName = teamName;
            TypeOfTeam = teamType;
            TeamMembers = teamMembers;
        }

        public DevTeam(string teamName, TeamType teamType)
        {
            TeamName = teamName;
            TypeOfTeam = teamType;
            TeamMembers = new List<Developer>();
        }

        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public TeamType TypeOfTeam { get; set; }
        public List<Developer> TeamMembers { get; set; }

        
    }
}
