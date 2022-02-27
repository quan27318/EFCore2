using System.Collections.Generic;
using EFCore2.Models;
using EFCore2.Responsitory;
namespace EFCore2.Services
{
    public class CategoryServices : ICategory
    {
        private readonly ICategoryResponsitory _ICategoryResponsitory;

        public CategoryServices(ICategoryResponsitory iCategoryResponsitory)
        {
            _ICategoryResponsitory = iCategoryResponsitory;

        }
        public List<Category> GetCategory()
        {
            return _ICategoryResponsitory.GetCategory();
        }
        public void Create(Category cate)
        {
            _ICategoryResponsitory.Create(cate);
        }

        public void Update(Category cate)
        {
            _ICategoryResponsitory.Update(cate);
        }
        public void Delete(int id)
        {
            _ICategoryResponsitory.Delete(id);
        }
        public ErrorRespone CreateProductAndCategory(Category cate, Product pro)
        {
            return _ICategoryResponsitory.CreateProductAndCategory(cate, pro);
        }

    }
}