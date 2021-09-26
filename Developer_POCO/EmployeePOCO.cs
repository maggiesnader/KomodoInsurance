using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Developer_POCO;



namespace KomodoInsurance_POCO
{
    public class Employee 
    {
        public Employee() { }

        public Employee(string name, string email, string phoneNumber, EmployeeType typeOfEmployee, Department nameOfDepartment )
        {
            Name = name;
            EMail = email;
            PhoneNumber = phoneNumber;
            TypeOfEmployee = typeOfEmployee;
            NameOfDepartment = nameOfDepartment;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public EmployeeType TypeOfEmployee { get; set; }
        public Department NameOfDepartment { get; set; }

    }
}
