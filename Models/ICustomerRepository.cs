using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface ICustomerRepository
    {
        void Add(CustomersModel provider);
        void Edit(CustomersModel provider);
        void Delete(int customerId);
        IEnumerable<CustomersModel> GetAll();
        IEnumerable<CustomersModel> GetByValue(string searchValue);
    }
}
