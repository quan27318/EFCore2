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
    public class ProductController : ControllerBase
    {
        private readonly IProduct _iProduct;
        public ProductController(IProduct iProduct)
        {
            _iProduct = iProduct;
        }
        [HttpGet("Get Product")]
        public List<Product> GetProducts()
        {
            return _iProduct.GetProducts();
        }
        [HttpPost]
        public HttpStatusCode Create(Product pro)
        {
            _iProduct.Create(pro);
            return HttpStatusCode.OK;
        }
        [HttpPut]
        public HttpStatusCode Update(Product pro)
        {
            _iProduct.Update(pro);
            return HttpStatusCode.OK;
        }
        [HttpDelete]
        public HttpStatusCode Detele(int id)
        {
            _iProduct.Delete(id);
            return HttpStatusCode.OK;
        }
    }
}