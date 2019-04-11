using Lombard.DAL.Models;
using Lombard.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lombard.DAL.Repositories.Implementations
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer GetCustomer(int id)
        {
            return new Customer();
        } 
    }
}
