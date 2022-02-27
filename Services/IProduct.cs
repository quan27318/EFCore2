using System.Collections.Generic;
using EFCore2.Models;
namespace EFCore2.Services
{
    public interface IProduct
    {
        public List<Product> GetProducts();
        public void Create(Product pro);
        public void Update(Product pro);
        public void Delete(int id);
    }
}