using System;
using System.ComponentModel.DataAnnotations;

namespace SR9POS.Models
{
    public class Category
    {
        [Key]
        public Guid CategoryId { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name ="Category Name")]
        public string CategoryName { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
    }
}
