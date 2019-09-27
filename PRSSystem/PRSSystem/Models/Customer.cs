using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRSSystem.Models {
    public class Customer {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }


        public DateTime Date { get; set; }
        public decimal CreditLimit { get; set; }
    }
}
