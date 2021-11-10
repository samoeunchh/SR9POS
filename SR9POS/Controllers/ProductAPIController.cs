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
        public async Task<IActionResult> GetProduct(string code)
        {
            var product = await (from p in _context.Product
                                 join pp in _context.ProductPrice on p.UnitId equals pp.UnitId
                                 where p.Barcode.Equals(code)
                                 select new
                                 {
                                     p.ProductId,
                                     p.ProductName,
                                     p.Barcode,
                                     p.Cost,
                                     p.OnHand,
                                     pp.Price,
                                     p.UnitId
                                 }).FirstOrDefaultAsync();
            return Ok(product);
        }
    }
}
