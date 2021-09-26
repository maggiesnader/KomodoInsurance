using KomodoInsurance_POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KomodoInsurance_Repo
{
    public class EmployeeRepo
    {
        private List<Employee> _ListOfEmployees = new List<Employee>();
        private int _idCounter = default;

        //CREATE - ADD
        public bool AddEmployeeToList(Employee employeeToBeAdded)
        {
            if(employeeToBeAdded != null)
            {
                employeeToBeAdded.ID = ++_idCounter;
                _ListOfEmployees.Add(employeeToBeAdded);
                return true;
            }
            return false;
        }


        //READ - VIEW
        public List<Employee> ViewAllEmployees()
        {
            return _ListOfEmployees;
        }

        public Employee GetById(int id)
        {
            foreach(var employee in _ListOfEmployees)
            {
                if (employee.ID == id)
                {
                    return employee;
                }
            }
            return null;
        }

        public Employee GetByType(string employeeType)
        {
            foreach(var employee in _ListOfEmployees)
            {
                if (employee.TypeOfEmployee.ToString() == employeeType)
                {
                    return employee;
                }
                return null;
            }
            return null;
        }

        public Employee GetByDepartment(string department)
        {
            foreach(var employee in _ListOfEmployees)
            {
                if (employee.NameOfDepartment.ToString() == department)
                {
                    return employee;
                }
                return null;
            }
            return null;
        }

        public Employee GetByName(string name)
        {
            foreach (var employee in _ListOfEmployees)
            {
                if (employee.Name == name)
                {
                    return employee;
                }
                return null;
            }
            return null;
        }

        //UPDATE
        public bool UpdateExistingEmployee(int id, Employee updatedEmployeeInfo)
        {
            //find content
            Employee oldEmployeeInfo = GetById(id);

            //update content
            if (oldEmployeeInfo != null)
            {
                oldEmployeeInfo.Name = updatedEmployeeInfo.Name;
                oldEmployeeInfo.EMail = updatedEmployeeInfo.EMail;
                oldEmployeeInfo.PhoneNumber = updatedEmployeeInfo.PhoneNumber;
                oldEmployeeInfo.TypeOfEmployee = updatedEmployeeInfo.TypeOfEmployee;
                oldEmployeeInfo.NameOfDepartment = updatedEmployeeInfo.NameOfDepartment;
                return true;
            }
            return false;
        } 

        //DELETE
        public bool RemoveEmployeeFromList(int id)
        {
            Employee employee = GetById(id);

            if (employee == null)
            {
                return false;
            }

            int initialCount = _ListOfEmployees.Count;
            _ListOfEmployees.Remove(employee);

            if (initialCount > _ListOfEmployees.Count)
            {
                return true;
            }
            return false;
        }
    }
}
