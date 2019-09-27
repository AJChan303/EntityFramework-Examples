
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace EntityFrameWorkOne.Models {
    public class Student {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Firstname { get; set; }
        [Required]
        [StringLength(30)]
        public string Lastname { get; set; }
        [Range(600, 2400, ErrorMessage = "SAT scores must be 600<=x<=2400")]
        public int SAT { get; set; }
        [Range(0, 5)]
        public double GPA { get; set; }
        public bool IsFulltime { get; set; } = true;

        public int? MajorId { get; set; }
        public virtual Major Major { get; set; }

        public override string ToString() {
            var major = (this.Major == null) ? "Undecided" : this.Major.Description;
            return $"Name: {this.Firstname} {this.Lastname} SAT: {this.SAT}  GPA: {this.GPA} Major {major}";

        }

        public Student() {

        }
        public Student(string first, string last, double gpa, int sat, bool ft, string mid) {
            this.Firstname = first;
            this.Lastname = last;
            this.GPA = gpa;
            this.SAT = sat;
            this.IsFulltime = ft;
            var context = new AppDbContext();
            this.MajorId = context.Majors.SingleOrDefault(m => m.Description == mid) == null
                ? null
                : (int?)context.Majors.SingleOrDefault(m => m.Description == mid).Id;
        }

    }
}
    
