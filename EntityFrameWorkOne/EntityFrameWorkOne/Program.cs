using EntityFrameWorkOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameWorkOne {
    public class Program {
        Console.beep();

      
        public static Student GetStudentByLastname(string name) {
            var db = new AppDbContext();
            var students = db.Students.Where(m => m.Lastname == name).ToArray();
            if (students.Count() == 0) {
                return null;
            } else {
                return students[0];
            }
        }
        public static Student GetStudentByID(int id) {
            var db = new AppDbContext();
            return db.Students.Find(id);
        }
        static void Main(string[] args) {
            var context = new AppDbContext();

            var scheds = new Schedule[] {
                new Schedule("Chan", "Paints", 85),
                new Schedule("Chan", "Yarn", 90),
                new Schedule("Chan", "Ball Physics", 99),
                new Schedule("Chan", "Crosshair 101", 87),
                new Schedule("Kyle", "Paints", 95),
                new Schedule("Kyle", "Yarn", 82),
                new Schedule("Kyle", "Ball Physics", 100),
                new Schedule("Moore", "Paints", 83),
                new Schedule("Moore", "Yarn", 87),
                new Schedule("Moore", "Ball Physics", 95),
                new Schedule("Star", "Paints", 88),
                new Schedule("Star", "Yarn", 77),
                new Schedule("Star", "Ball Physics", 90),
                new Schedule("Turner", "Paints", 94),
                new Schedule("Turner", "Yarn", 99),
                new Schedule("Turner", "Ball Physics", 78)
            };


            //foreach (var sch in scheds) {
            //    context.Schedules.Add(sch);
            //}

            //context.SaveChanges();
            //var courses = new Course[] {
            //    new Course("Robot Anatomy","Dr. Roboto", 5,"Robot Breeding"),
            //    new Course("Robot Sex Ed","Dr. Robotnic", 3,"Robot Breeding"),
            //    new Course("Phone Number 101","Peggy Wetherton", 4,"Extreme Faxing"),
            //    new Course("Ball Physics","Tiger Woods", 5,"Golf Science"),
            //    new Course("Attack Moving","Doublelift", 4,"MOBA Elite"),
            //    new Course("Crosshair 101","Elige", 4,"FPS 101"),
            //    new Course("Paints","Bob Ross", 5,"Bob Ross Painting"),
            //    new Course("Yarn","Betty White", 3,"Industrial Knitting"),
            //    new Course("Parachute 101","Bear Grills", 3,"Base Jumping"),
            //    new Course("Tarantino Films","Marty Butt", 4,"Movies")
            //};
            //foreach (var cour in courses) {
            //    context.Courses.Add(cour);

            //}

            //var students = new Student[] {
            //    new Student("John", "Bird", 2.8, 1100, true, "eSports"),
            //    new Student("Patrick", "Star", 1.7, 650, false, "Public Speaking"),
            //    new Student("Jimmy", "Neutron", 5.0, 2400, true, "Theatre"),
            //    new Student("Timmy","Turner", 2.5, 1300, true, "Golf Science"),
            //    new Student("Steve", "Rogers", 4.6,1000,false, "Socialogy")

            //};
            //foreach (var stud in students) {
            //    context.Students.Add(stud);
            //}


            //context.SaveChanges();

            //var major = new Major();
            //major.Id = 0;
            //major.Description = "Nursing";
            //major.MinSAT = 1100;

            //context.Majors.Add(major);
            // major = new Major();
            //major.Id = 0;
            //major.Description = "Accounting";
            //major.MinSAT = 1300;

            //context.Majors.Add(major);
            // major = new Major();
            //major.Id = 0;
            //major.Description = "Public Speaking";
            //major.MinSAT = 5;

            //context.Majors.Add(major);
            // major = new Major();
            //major.Id = 0;
            //major.Description = "Golf Science";
            //major.MinSAT = 1400;

            //context.Majors.Add(major);
            // major = new Major();
            //major.Id = 0;
            //major.Description = "eSports";
            //major.MinSAT = 800;

            //context.Majors.Add(major);
            // major = new Major();
            //major.Id = 0;
            //major.Description = "History";
            //major.MinSAT = 900;

            //context.Majors.Add(major);
            // major = new Major();
            //major.Id = 0;
            //major.Description = "Political Science";
            //major.MinSAT = 1000;

            //context.Majors.Add(major);
            // major = new Major();
            //major.Id = 0;
            //major.Description = "Theatre";
            //major.MinSAT = 200;

            //context.Majors.Add(major);
            // major = new Major();
            //major.Id = 0;
            //major.Description = "Computer Science";
            //major.MinSAT = 1100;
            //context.Majors.Add(major);


            //context.SaveChanges();


            //var majors = new List<Major> {
            //    new Major("Nursing", 1100),
            //    new Major("Acounting", 1300),
            //    new Major("Public Speaking", 6),
            //    new Major("Golf Science", 1400),
            //    new Major("eSports", 800),
            //    new Major("Socialogy", 800),
            //    new Major("History",900),
            //    new Major("Political Science",1000),
            //    new Major("Theater",200 ),
            //    new Major("Computer Science",1500),
            //};
            //context.Majors.AddRange(majors);
            //context.SaveChanges();
            //var major = context.Majors.Find(10);
            //context.Remove(major);

            //var major = context.Majors.Find(2);
            //if(major == null) {
            //    throw new Exception("Not Found");
            //}
            //major.Description = "Robot Breeding";
            //major.MinSAT = 1600;


            //foreach (var majors in context.Majors.ToList()) {
            //    Console.WriteLine(majors);

            //}
            //var classone = context.Majors.Find(1);
            //Console.WriteLine(classone.ToString());
            //foreach (var maj in majors) {
            //    Console.WriteLine($"{maj.Description}");

            //}
            //    var majors = context.Majors.Where(m => m.MinSAT > 1400).OrderByDescending(m => m.MinSAT);
            //    foreach (var maj in majors) {
            //        Console.WriteLine($"Class: {maj.Description}, Min SAT: {maj.MinSAT}");
            //    }
            //}

            //var students = context.Students
            //    .Where(s => s.GPA >= 3)
            //    .OrderByDescending(s => s.Lastname)
            //    .ToArray(); // Students pointing to the property called students in the appdbcontext class

            // var students = context.Students.OrderBy(s => s.Firstname);
            //// var students = context.Students.Where(s => s.SAT >= 1000).OrderByDescending(s => s.SAT).ToList();
            // //var students = context.Students.Average(s => s.SAT);
            // //Console.WriteLine($"Average SAT scores {students}");



            //var students = context.Students.OrderBy(m => m.Major.Description).ToList();
            //foreach (var stud in students) {    //The function after Students is called Extension Method

            //    Console.WriteLine( stud);
            //}
        }
}
}
