using System;
using System.ComponentModel.DataAnnotations;

namespace SR9POS.Models
{
    public class Unit
    {
        [Key]
        public Guid UnitId { get; set; }
        [MaxLength(50)]
        [Required]
        [Display(Name ="Unit Name")]
        public string UnitName { get; set; }
        public int Qty { get; set; }
    }
}
