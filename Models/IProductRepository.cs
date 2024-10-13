using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface IProductRepository
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetByValue(string value);
    }
}
