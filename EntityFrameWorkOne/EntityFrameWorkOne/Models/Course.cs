using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace EntityFrameWorkOne.Models {
    public class Course {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Instructor { get; set; }
        public int Credits { get; set; }
        public int? MajorId { get; set; }
        public virtual Major Major { get; set; }
        public Course() {        }
        public Course(string name, string instruct, int cred,string mid) {
            this.Name = name;
            this.Instructor = instruct;
            this.Credits = cred;
            var context = new AppDbContext();
            this.MajorId = (context.Majors.SingleOrDefault(m => m.Description == mid) == null) ? null 
                : (int?)context.Majors.SingleOrDefault(m => m.Description == mid).Id;

        }


    }

}
