using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace EntityFrameWorkOne.Models {
    public class Schedule {
        [Key]
        public int Id { get; set; }
        [Required]
        public int StudentId { get; set; }
        [Required]
        public int CourseId { get; set; }
        public int? Grade { get; set; }
         public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
        public Schedule() {  }

        public Schedule(string lname, string cours, int grade) {
            var context = new AppDbContext();

            this.StudentId = context.Students.SingleOrDefault(s => s.Lastname == lname).Id;


            this.CourseId = context.Courses.SingleOrDefault(c => c.Name == cours).Id;
            this.Grade = grade;
        }

    }
}
