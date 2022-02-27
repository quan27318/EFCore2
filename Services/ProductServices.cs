using System.Collections.Generic;
using EFCore2.Models;
using EFCore2.Responsitory;
namespace EFCore2.Services
{
    public class ProductServices : IProduct
    {
        private readonly IProductResponsitory _iResponsitory;
        public ProductServices(IProductResponsitory iResponsitory)
        {
            _iResponsitory = iResponsitory;
        }
        public List<Product> GetProducts()
        {
            return _iResponsitory.GetProducts();
        }
        public void Create(Product pro)
        {
            _iResponsitory.Create(pro);
        }
        public void Update(Product pro)
        {
            _iResponsitory.Update(pro);
        }
        public void Delete(int id)
        {
            _iResponsitory.Delete(id);
        }
    }
}