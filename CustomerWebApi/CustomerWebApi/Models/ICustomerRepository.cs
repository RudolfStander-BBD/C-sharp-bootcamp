using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerWebApi.Models
{
    public interface ICustomerRepository
    {
        void Add(Customer item);
        IEnumerable<Customer> GetAll();
        Customer Find(long key);
        void Remove(long key);
        void Update(Customer item);
    }
}