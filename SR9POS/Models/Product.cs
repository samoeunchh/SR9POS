using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SR9POS.Models
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name ="Product Name")]
        public string ProductName { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        [ForeignKey("Unit")]
        public Guid UnitId { get; set; }
        public int OnHand { get; set; }
        [Required]
        [MaxLength(15)]
        public string Barcode { get; set; }
        public int Cost { get; set; }

        public Category Category { get; set; }
        public Unit Unit { get; set; }
        public List<ProductPrice> ProductPrices { get; set; }
    }
}
