using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRSSystem.Models {
    public class Product {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(80)]
        public String Name { get; set; }


        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Qty { get; set; }

        [MaxLength(8)]
        public string Status { get; set; }

    }
}
