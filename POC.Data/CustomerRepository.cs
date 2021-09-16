using POC.Core.Entities;
using POC.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        public bool Delete(Customer data)
        {
            throw new NotImplementedException();
        }

        public ICollection<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            var customer = new Customer()
            {
                Id = id,
                Nombre = "Nombre",
                Address = "Address"
            };

            return customer;
        }

        public bool Insert(Customer data)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer data)
        {
            throw new NotImplementedException();
        }
    }
}
