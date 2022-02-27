using System;
using System.Collections.Generic;
using EFCore2.Models;
namespace EFCore2.Responsitory
{
    public class CategoryResponsitory : ICategoryResponsitory
    {
        private readonly ProductDcContext _productDbContext;
        private readonly IProductResponsitory _iProductResponsitory;
        public CategoryResponsitory(ProductDcContext productDcContext, IProductResponsitory iProductResponsitory)
        {
            _productDbContext = productDcContext;
            _iProductResponsitory = iProductResponsitory;
        }
        public List<Category> GetCategory()
        {
            return _productDbContext.Categories.ToList();
        }
        public void Create(Category cate)
        {
            using var transaction = _productDbContext.Database.BeginTransaction();
            try
            {
                _productDbContext.Categories.Add(cate);

                _productDbContext.SaveChanges();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }

        }
        public ErrorRespone CreateProductAndCategory(Category cate, Product pro)
        {
            using var transaction = _productDbContext.Database.BeginTransaction();
            try
            {
                _productDbContext.Categories.Add(cate);
                _productDbContext.SaveChanges();
                _productDbContext.Products.Add(pro);
                _productDbContext.SaveChanges();

                transaction.Commit();
                return new ErrorRespone()
                {
                    ErrorCode = 1,
                    ErrorMessage = "Sussces"
                };

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return new ErrorRespone()
                {
                    ErrorCode = 2,
                    ErrorMessage = ex.Message
                };
            }

        }
        public void Update(Category cate)
        {
            using var transaction = _productDbContext.Database.BeginTransaction();
            try
            {
                var cateUpdate = _productDbContext.Categories.Where(x => x.CategoryID == cate.CategoryID).FirstOrDefault();
                cateUpdate.CategoryName = cate.CategoryName;
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
                var cateDelete = _productDbContext.Categories.Where(x => x.CategoryID == id).FirstOrDefault();
                _productDbContext.Categories.Remove(cateDelete);
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