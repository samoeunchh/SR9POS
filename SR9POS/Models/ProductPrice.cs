using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SR9POS.Models
{
    public class ProductPrice
    {
        [Key]
        public Guid ProductPriceId { get; set; }
        public Guid ProductId { get; set; }
        public Guid UnitId { get; set; }
        public int Price { get; set; }
    }
}
