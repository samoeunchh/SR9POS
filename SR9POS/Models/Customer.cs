﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SR9POS.Models
{
    public class Customer
    {
        [Key]
        public Guid CustomerId { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name ="Customer Name")]
        public string CustomerName { get; set; }
        [Phone]
        public string Mobile { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
