using Lombard.DAL;
using Lombard.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lombard.DAL.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(int id);
    }
}
