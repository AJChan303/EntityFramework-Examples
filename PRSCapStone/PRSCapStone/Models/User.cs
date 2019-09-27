using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRSCapStone.Models {
    public class User {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        [Required]
        public string Username { get; set; }
        [Required]
        [MaxLength(30)]
        public string  Password { get; set; }
        [Required]
        [MaxLength(30)]
        public string Firstname { get; set; }
        [MaxLength(15)]
        public string Phone { get; set; }
        [MaxLength(255)]
        public string Email { get; set; }
        [Required]
        public bool IsReviewer { get; set; }
        [Required]
        public bool IsAdmin { get; set; }





    }
}
