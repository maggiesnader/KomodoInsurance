using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Developer_POCO;

namespace KomodoInsurance_POCO
{
    public class DevManager : DevTeam
    {
        public DevManager() { }

        public DevManager(string managerTitle)
        {
            ManagerTitle = managerTitle;
        }

        public int ManagerID { get; set; }
        public string ManagerTitle { get; set; }

    }
}
