﻿using Microsoft.AspNetCore.Mvc;
using Shopping.API.Data;
using Shopping.API.Models;

namespace Shopping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return ProductContext.Products;
        }
    }
}
