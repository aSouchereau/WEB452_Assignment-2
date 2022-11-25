using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AlexsBooks.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        [Required]
        [Range(1,1000)]
        public double ListPrice { get; set; }
        public string ImageUrl { get; set; }

        [Required]
        public int CategoryId { get; set; } // foreign key reference
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [Required]
        public int CoverTypeId { get; set; } // foreign key reference
        [ForeignKey("CategoryId")]
        public CoverType CoverType { get; set; }
    }
}
