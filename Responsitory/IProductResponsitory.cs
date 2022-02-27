using System.Collections.Generic;
using System;
using System;
using EFCore2.Models;
namespace EFCore2.Responsitory
{
    public interface IProductResponsitory
    {
        public List<Product> GetProducts();
        public void Create(Product pro);
        public void Update(Product pro);
        public void Delete(int id);
    }
}