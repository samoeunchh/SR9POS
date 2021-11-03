using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SR9POS.Data;
using SR9POS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SR9POS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ProductAPIController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("{code}")]
        public async Task<Product> GetProduct(string code)
            => await _context.Product.FirstOrDefaultAsync(x => x.Barcode.Equals(code));
    }
}
