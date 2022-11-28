using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AlexsBooks.Models
{
    public class CoverType
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Cover Type")]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
