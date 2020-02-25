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
        public void UpdateProduct(Product product);
        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();
    }
}
