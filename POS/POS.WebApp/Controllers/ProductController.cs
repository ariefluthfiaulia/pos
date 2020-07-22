using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using POS.WebApp.Data;
using POS.WebApp.Dtos.Product;
using POS.WebApp.Repo;

namespace POS.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository _repo;
        private readonly IMapper _mapper;

        public ProductController(ProductRepository repo,IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _repo.GetProducts();
            var productsReturn = _mapper.Map<IEnumerable<ProductDto>>(products);
            return Ok(productsReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _repo.GetProduct(id);
            var productReturn = _mapper.Map<ProductDto>(product);
            return Ok(productReturn);
        }

        [HttpPost]
        public async Task<IActionResult> Save(Product product)
        {
            _repo.Add(product);
            await _repo.SaveAll();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, ProductUpdateDto productUpdateDto)
        {
            var product = await _repo.GetProduct(id);

            _mapper.Map(productUpdateDto, product);

            if (await _repo.SaveAll())
            {
                return NoContent();
            }

            throw new Exception($"Updating user {id} failed on save");
        }

    }
}
