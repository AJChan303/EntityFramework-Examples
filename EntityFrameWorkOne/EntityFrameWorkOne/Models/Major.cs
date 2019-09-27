using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFrameWorkOne.Models {
    public class Major {

        [Key]
        public int Id { get; set; }
        [Required]  
        [StringLength(50)]
        public string Description { get; set; }
        [Required]
        [Range(600, 2400)]
        public int MinSAT { get; set; }

        



        public virtual ICollection<Student> Students { get; set; }
        public Major(string desc , int min) {
            this.Description = desc;
            this.MinSAT = min;

        }
        public Major() {
            
        }
        public override string ToString() {

            return $"id:{this.Id}, Desc: {this.Description}, MinSat: {this.MinSAT}";
        }

    }
}
