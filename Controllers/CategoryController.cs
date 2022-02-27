using System.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFCore2.Models;
using EFCore2.Services;
namespace EFCore2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategory _iCategory;
        public CategoryController(ICategory iCategory)
        {
            _iCategory = iCategory;
        }
        [HttpGet("Get Category")]
        public List<Category> GetCategory()
        {
            return _iCategory.GetCategory();
        }
        [HttpPost("Add Category")]
        public HttpStatusCode Create(Category category)
        {
            _iCategory.Create(category);
            return HttpStatusCode.OK;
        }
        [HttpPut]
        public HttpStatusCode Update(Category cate)
        {
            _iCategory.Update(cate);
            return HttpStatusCode.OK;
        }
        [HttpDelete]
        public HttpStatusCode Delete(int id)
        {
            _iCategory.Delete(id);
            return HttpStatusCode.OK;
        }
        [HttpPost("Product and Category")]
        public HttpStatusCode CreateProductAndCategory(CategoryAndProduct catePro)
        {
            var category = catePro.category;
            var product = catePro.product;

            _iCategory.CreateProductAndCategory(category, product);
            return HttpStatusCode.OK;

        }

    }
}