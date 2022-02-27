using System.Collections.Generic;
using System;
using System;
using EFCore2.Models;
namespace EFCore2.Responsitory
{
    public interface ICategoryResponsitory
    {
        public List<Category> GetCategory();
        public void Create(Category cate);
        public void Update(Category cate);
        public void Delete(int id);
        public ErrorRespone CreateProductAndCategory(Category cate, Product pro);
    }
}