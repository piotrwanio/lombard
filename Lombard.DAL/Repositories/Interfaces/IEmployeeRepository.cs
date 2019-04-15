using Lombard.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lombard.DAL.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        bool DeleteEmplyee(int id);
        bool AddEmployee(Employee employee);
        bool UpdateEmployee(Employee employee);
    }
}
