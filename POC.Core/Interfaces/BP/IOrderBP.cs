using POC.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Core.Interfaces.BP
{
    public interface IOrderBP
    {
        public Task<bool> Insert(Order order);
    }
}
