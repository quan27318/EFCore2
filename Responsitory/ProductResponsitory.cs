using System;
using System.Collections.Generic;
using EFCore2.Models;
namespace EFCore2.Responsitory
{
    public class ProductRespository : IProductResponsitory
    {
        private readonly ProductDcContext _productDbContext;
        public ProductRespository(ProductDcContext productDcContext)
        {
            _productDbContext = productDcContext;
        }
        public List<Product> GetProducts()
        {
            return _productDbContext.Products.ToList();
        }
        public void Create(Product pro)
        {
            using var transaction = _productDbContext.Database.BeginTransaction();
            try
            {
                _productDbContext.Products.Add(pro);

                _productDbContext.SaveChanges();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }

        }
        public void Update(Product pro)
        {
            using var transaction = _productDbContext.Database.BeginTransaction();
            try
            {
                var productUpdate = _productDbContext.Products.Where(x => x.ProductID == pro.ProductID).FirstOrDefault();
                productUpdate.ProductName = pro.ProductName;
                productUpdate.Manufacture = pro.Manufacture;
                productUpdate.CategoryID = pro.CategoryID;
                _productDbContext.SaveChanges();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }

        }
        public void Delete(int id)
        {
            using var transaction = _productDbContext.Database.BeginTransaction();
            try
            {
                var productRemove = _productDbContext.Products.Where(x => x.ProductID == id).FirstOrDefault();
                _productDbContext.Products.Remove(productRemove);
                _productDbContext.SaveChanges();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }

        }
    }
}