using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlindLowVisionProject.Models
{
    public class MockCustomerRepository : ICustomerRepository
    {
        private List<Customer> _customerList;

        public MockCustomerRepository()
        {
            _customerList = new List<Customer>()
            {
                new Customer() { Id = 1, Name = "David", Department = Dept.HR, Email = "david@gmail.com" },
                new Customer() { Id = 2, Name = "Jeff", Department = Dept.IT, Email = "jeff@gmail.com" },
                new Customer() { Id = 3, Name = "Sam", Department = Dept.IT, Email = "sam@gmail.com" },
            };
        }

        public Customer Add(Customer customer)
        {
            customer.Id = _customerList.Max(e => e.Id) + 1;
            _customerList.Add(customer);
            return customer;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customerList;
        }

        public Customer GetCustomer(int Id)
        {
            return _customerList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
