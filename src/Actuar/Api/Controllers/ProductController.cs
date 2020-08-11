using Domain.Entities;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Api.Controllers
{
    [Route("api/v1/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            try
            {
                IList<Product> response = _productService.GetAll();

                return Ok(response);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpGet("by-id")]
        public IActionResult GetProductById([FromQuery] string id)
        {
            try
            {
                Product response = _productService.GetById(id);

                return Ok(response);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpGet("by-date")]
        public IActionResult GetProductsByDate([FromQuery] DateTime date)
        {
            try
            {
                IList<Product> response = _productService.GetStockInDate(date);

                return Ok(response);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpPost]
        public IActionResult AddProducts([FromBody] Product[] products)
        {
            try
            {
                bool response = _productService.AddProducts(products);

                return Ok(response);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        [HttpDelete]
        public IActionResult RemoveProducts([FromBody] string[] ids)
        {
            try
            {
                bool response = _productService.Remove(ids);

                return Ok(response);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }
    }
}
