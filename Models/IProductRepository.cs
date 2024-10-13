using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface IProductRepository
    {
        IEnumerable<ProductModel> GetAll();
        IEnumerable<ProductModel> GetByValue(string value);
        void Delete(int id);
        void Edit(ProductModel product);
        void Add(ProductModel product);
    }
}
