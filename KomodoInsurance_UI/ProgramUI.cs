using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Developer_POCO;
using KomodoInsurance_POCO;
using KomodoInsurance_Repo;

namespace KomodoInsurance_UI
{
    class ProgramUI
    {
        private EmployeeRepo _employeeRepo = new EmployeeRepo();
        private DeveloperRepo _developerRepo = new DeveloperRepo();
        private DevTeamRepo _devTeamRepo = new DevTeamRepo();
        private DevManagerRepo _devManagerRepo = new DevManagerRepo();

        public void Run()
        {
            SeedList();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display options to user
                DisplayMenu();

                //Get user input
                //Evaluate the users input and act accordingly
                MenuOptions();
            }
        }

        //Main Menu - Display options to user
        private void DisplayMenu()
        {
            Console.WriteLine("Komodo Insurance Team Management\n" +
                "Select a Menu Option:\n" +
                "1. Add individuals\n" +
                "2. Remove individuals\n" +
                "3. Search for individuals\n");
        }

        //Main Menu - Evaluate user input and act accordingly
        private void MenuOptions()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    AddMenuDisplay();
                    AddMenuOptions();
                    break;
                case "2":
                    RemoveMenuDisplay();
                    RemoveMenuOptions();
                    break;
                case "3":
                    SearchMenuDisplay();
                    SearchMenuOptions();
                    break;
            }
        }

        //Add Menu - Display options to user
        private void AddMenuDisplay()
        {
            Console.WriteLine("Komodo Insurance Team Management\n" +
                "Add Individuals\n" +
                "Select a Menu Option:" +
                "1. Add New Employee\n" +
                "2. Add New Developer\n" +
                "3. Add New DevTeam\n" +
                "4. Add Developer To Team");
        }

        //Add Menu - Evaluate user input and act accordingly
        private void AddMenuOptions()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    //create employee
                    CreateNewEmployee();
                    break;
                case "2":
                    //create developer
                    CreateNewDeveloper();
                    break;
                case "3":
                    //create devteam
                    CreateNewDevTeam();
                    break;
                case "4":
                    //add developer to team
                    break;
            }
        }

        //Add Menu - create employee
        private void CreateNewEmployee()
        {
            Console.Clear();
            Employee newEmployee = new Employee();

            //Name
            Console.WriteLine("Enter Employee Name:");
            string name = Console.ReadLine();
            newEmployee.Name = name;

            //Email
            Console.WriteLine("Enter Employee Email:");
            string email = Console.ReadLine();
            newEmployee.EMail = email;

            //PhoneNumber
            Console.WriteLine("Enter Employee Phone Number:");
            string phoneNumber = Console.ReadLine();
            newEmployee.PhoneNumber = phoneNumber;

            //Type
            Console.WriteLine("Enter Employee Type:\n" +
                "1. Staff\n" +
                "2. Intern" +
                "3. TeamMember" +
                "4. Mgmt1" +
                "5. Mgmt2" +
                "6. Exec");
            string employeeTypeString = Console.ReadLine();
            int employeeTypeInt = int.Parse(employeeTypeString);
            newEmployee.TypeOfEmployee = (EmployeeType)employeeTypeInt;

            //Department
            Console.WriteLine("Enter Employee Department:\n" +
                "1. Operations\n" +
                "2. Software Development" +
                "3. Marketing" +
                "4. Sales" +
                "5. Management");
            string departmentString = Console.ReadLine();
            int departmentInt = int.Parse(departmentString);
            newEmployee.NameOfDepartment = (Department)departmentInt;
        }

        //Add Menu - create developer
        private void CreateNewDeveloper()
        {
            Console.Clear();
            Developer newDeveloper = new Developer();

            //Name
            Console.WriteLine("Enter Developer Name:");
            string name = Console.ReadLine();
            newDeveloper.Name = name;

            //Email
            Console.WriteLine("Enter Developer Email:");
            string email = Console.ReadLine();
            newDeveloper.EMail = email;

            //PhoneNumber
            Console.WriteLine("Enter Developer Phone Number:");
            string phoneNumber = Console.ReadLine();
            newDeveloper.PhoneNumber = phoneNumber;

            //Type
            Console.WriteLine("Enter Developer's Employee Type:\n" +
                "1. Staff\n" +
                "2. Intern" +
                "3. TeamMember" +
                "4. Mgmt1" +
                "5. Mgmt2" +
                "6. Exec");
            string employeeTypeString = Console.ReadLine();
            int employeeTypeInt = int.Parse(employeeTypeString);
            newDeveloper.TypeOfEmployee = (EmployeeType)employeeTypeInt;

            //Department
            Console.WriteLine("Enter Developer's Employee Department:\n" +
                "1. Operations\n" +
                "2. Software Development" +
                "3. Marketing" +
                "4. Sales" +
                "5. Management");
            string departmentString = Console.ReadLine();
            int departmentInt = int.Parse(departmentString);
            newDeveloper.NameOfDepartment = (Department)departmentInt;

            //SpecialtyOfDeveloper
            Console.WriteLine("Select Developer Specialty:\n" +
                "1. Front End\n" +
                "2. Back End\n" +
                "3. Full");
            string specialtyString = Console.ReadLine();
            int specialtyInt = int.Parse(specialtyString);
            newDeveloper.SpecialtyOfDeveloper = (DeveloperSpecialty)specialtyInt;

            //LevelOfExperience
            Console.WriteLine("Select Developer's Experience Level\n" +
                "1. Level One" +
                "2. Level Two" +
                "3. Level Three" +
                "4. Level Four" +
                "5. Level Five");
            string experienceString = Console.ReadLine();
            int experienceInt = int.Parse(experienceString);
            newDeveloper.LevelOfExperience = (ExperienceLevel)experienceInt;

            //has access to Pluralsight
            Console.WriteLine("Does this Developer currently have access to Pluralsight?\n" +
                "1. Yes\n" +
                "2. No");

            string userResponse = Console.ReadLine();

            if (userResponse == "1")
            {
                newDeveloper.HasAccessToPluralsight = true;
            }
            else
            {
                newDeveloper.HasAccessToPluralsight = false;
            }

        }

        //Add Menu - create devteam
        private void CreateNewDevTeam()
        {
            Console.Clear();
            DevTeam newDevTeam = new DevTeam();

            //teamname
            Console.WriteLine("Enter the Development Team name:");
            newDevTeam.TeamName = Console.ReadLine();

            //typeofteam
            Console.WriteLine("Enter the type of team being created:\n" +
                "1. Type 1\n" +
                "2. Type 2\n" +
                "3. Type 3\n" +
                "4. Type 4\n");
            string typeString = Console.ReadLine();
            int typeInt = int.Parse(typeString);
            newDevTeam.TypeOfTeam = (TeamType)typeInt;

            //team members
            //ADD THIS AFTER YOU  MAKE THE SEARCH METHODS!!!!
            Console.WriteLine("Add Developers to team:\n" +
                "Enter the Employee ID of the Developers you would like to Add;");
        }

        //***Add Menu - add developer to team
        //ADD THIS AFTER YOU  MAKE THE SEARCH METHODS!!??



        //Remove Menu - Display options to user
        private void RemoveMenuDisplay()
        {
            Console.WriteLine("Komodo Insurance Team Management\n" +
                "Remove Individuals\n" +
                "Select a Menu Option:" +
                /*"1. Remove Employee\n" +
                "2. Remove Developer\n" +
                "3. Remove DevTeam\n" +*/
                "4. Remove Developer from Team");
        }

        //***Remove Menu - Evaluate user input and act accordingly
        private void RemoveMenuOptions()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                //case "1":
                    //remove employee
                   // break;
               // case "2":
                    //remove developer
                   // break;
                //case "3":
                    //remove devteam
                    //break;
                case "4":
                    RemoveDeveloperFromTeam();
                    break;
            }
        }
        //Remove Menu - Remove employee
        //Remove Menu - Remove developer
        //Remove Menu - RemoveDevTeam
        //***Remove Menu - Remove developer from team
        private void RemoveDeveloperFromTeam()
        {
            Console.Clear();
            SearchById();
            //Console.WriteLine("Enter the Employee ID of the Developer you would like to remove from a list:\n");
            int userInput = int.Parse(Console.ReadLine());

            DevTeam newDeveloper = new DevTeam();

            //Console.WriteLine("Enter the Team Name that the Developer needs to be removed from:\n");
            //string userInputTeamName = Console.ReadLine();
            newDeveloper.TeamName = null;
        }




        //
        //Search for Individuals Menu - Display options to user
        private void SearchMenuDisplay()
        {
            Console.WriteLine("Komodo Insurance Team Management\n" +
                "Search for Individuals\n" +
                "Select a Menu Option:" +
                "1. Search for Developer by ID");
        }
        //Search Menu - Evaluate user input and act accordingly
        private void SearchMenuOptions()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    SearchById();
                    break;
            }
        }

        //Search Menu - Search for developer by Id
        private void SearchById()
        {
            Console.Clear();
            //Promt user for Id
            Console.WriteLine("Enter the Employee ID of the Developer:\n");
            //Get input
            int userInput = int.Parse(Console.ReadLine());
            //Find developer by that Id
            Developer developer = _developerRepo.GetDeveloperByEmployeeId(userInput);
            //Display if not null
            if (developer != null)
            {
                Console.WriteLine($"Name: {developer.Name}\n" +
                    $"ID: {developer.ID}");
            }
            else
            {
                Console.WriteLine("There is no developer with that ID.");
            }

        }

        //Search Menu - Search by
        //Search Menu - Search by
        //Search Menu - Search by



        //SEED
        private void SeedList()
        {
            Employee seedEmployee1 = new Employee("Maggie Snader", "snader.maggie@gmail.com", "123-456-7890", EmployeeType.Staff, Department.Operations);

            Developer seedDeveloper1 = new Developer(DeveloperSpecialty.FrontEnd, ExperienceLevel.LevelOne, true);

            DevTeam seedDevTeam1 = new DevTeam("Team Red", TeamType.Type2);

            DevManager seedDevmanager1 = new DevManager("Team Read Manager");


            _employeeRepo.AddEmployeeToList(seedEmployee1);

            _developerRepo.AddDeveloperToList(seedDeveloper1);

            _devTeamRepo.AddDevTeamToList(seedDevTeam1);

            _devManagerRepo.AddDevManagerToList(seedDevmanager1);
        }
    }
}
