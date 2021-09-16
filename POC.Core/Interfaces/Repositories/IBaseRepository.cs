using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Core.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        public ICollection<T> GetAll();
        public T GetById(int id);
        public bool Insert(T data);
        public bool Update(T data);
        public bool Delete(T data);
    }
}
