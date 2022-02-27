using System.Collections.Generic;
using EFCore2.Models;
namespace EFCore2.Services
{
    public interface ICategory
    {
        public List<Category> GetCategory();
        public void Create(Category cate);
        public void Update(Category cate);
        public void Delete(int id);
        public ErrorRespone CreateProductAndCategory(Category cate, Product pro);
    }
}