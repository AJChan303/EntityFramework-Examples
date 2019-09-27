using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRSCapStone.Models {
    public class Vendor {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        [Required]
        public string Code { get; set; }
        [MaxLength(30)]
        [Required]
        public string Name { get; set; }
        [MaxLength(30)]
        [Required]
        public string Address { get; set; }
        [MaxLength(30)]
        [Required]
        public string City { get; set; }
        [Required]
        [MaxLength(3)]
        public string State { get; set; }
        [Required]
        [MaxLength(10)]
        public string Zip { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; }
        [MaxLength(22)]
        public string Email { get; set; }
    }
}
