using POC.Core.Entities;
using POC.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace POC.Data
{
    public class OrderRepository : IOrderRepository
    {
        public bool Delete(Order data)
        {
            throw new NotImplementedException();
        }

        public ICollection<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Order data)
        {
            return true;
        }

        public bool Update(Order data)
        {
            throw new NotImplementedException();
        }
    }
}
