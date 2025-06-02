using System;
using System.ComponentModel.DataAnnotations;

namespace Marshell_Web.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        public bool Active { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}