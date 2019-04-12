using Lombard.DAL.Models;
using Lombard.DAL.Repositories.Implementations;
using Lombard.DAL.Repositories.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;


namespace Lombard.DAL.Tests
{
    [TestFixture]
    class EmplyeeRepositoryTests
    {
        IEmployeeRepository employeeRepository;

        [SetUp]
        public void SetUp()
        {
            employeeRepository = new EmployeeRepository();
        }

        [Test]
        public void GetEmployee_ValidTest()
        {
          Employee  result = employeeRepository.GetEmployee(1);
          Assert.IsNotNull(result);
        }

        [Test]
        public void GetEmployee_NotValidTest()
        {
            Employee result = employeeRepository.GetEmployee(-1);
            Assert.IsNull(result);
        }

        [Test]
        public void DeleteEmployee_Succesfull()
        {
            bool result = employeeRepository.DeleteEmplyee(1);
            Assert.IsTrue(result);
        }

        [Test]
        public void DeleteEmployee_NotSuccesfull()
        {
            bool result = employeeRepository.DeleteEmplyee(-1);
            Assert.IsFalse(result);
        }

        [Test]
        public void AddEmployee_Succesfull()
        {
            bool result = employeeRepository.AddEmployee(new Employee());
            Assert.IsTrue(result);
        }

        [Test]
        public void AddEmployee_NotSuccesfull()
        {
            bool result = employeeRepository.AddEmployee(null);
            Assert.IsFalse(result);
        }

        [Test]
        public void UpdateEmployee_Succesfull()
        {
            bool result = employeeRepository.UpdateEmployee(new Employee());
            Assert.IsTrue(result);
        }

        [Test]
        public void UpdateEmployee_NotSuccesfull()
        {
            bool result = employeeRepository.UpdateEmployee(null);
            Assert.IsFalse(result);
        }
    }
}
