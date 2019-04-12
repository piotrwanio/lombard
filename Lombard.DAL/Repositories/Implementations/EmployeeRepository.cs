using Lombard.DAL.Models;
using Lombard.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lombard.DAL.Repositories.Implementations
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public bool AddEmployee(Employee employee)
        {
            if(employee == null) return false;
            return true;
        }

        public bool DeleteEmplyee(int id)
        {
            if (id <= 0) return false;
            return true;
        }

        public Employee GetEmployee(int id)
        {
           if(id > 0)
            {
                return new Employee();
            }
            return null;
        }

        public bool UpdateEmployee(Employee employee)
        {
            if (employee == null) return false;
            return true;
        }
    }
}
