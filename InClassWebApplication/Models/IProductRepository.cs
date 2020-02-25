using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InClassWebApplication.Models
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
    }
}
