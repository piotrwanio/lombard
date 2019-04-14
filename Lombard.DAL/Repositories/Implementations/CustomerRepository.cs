using Lombard.DAL.Models;
using Lombard.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lombard.DAL.Repositories.Implementations
{
    public class CustomerRepository : ICustomerRepository
    {
        EFDbContext _context;
        public CustomerRepository(EFDbContext context)
        {
            _context = context;
        }

        public bool AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
