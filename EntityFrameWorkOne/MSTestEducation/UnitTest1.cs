using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntityFrameWorkOne.Models;
using EntityFrameWorkOne;
namespace MSTestEducation {
    [TestClass]
    public class UnitTest1 {
        //AppDbContext db = null;
        [TestInitialize]
        public void Testinit() {

           // db = new AppDbContext();
            }
        [TestMethod]
        public void TestStudentByID() {
            var al = Program.GetStudentByID(1);
            Assert.IsNotNull(al);
            Assert.AreEqual("Chan", al.Lastname);
        }
        [TestMethod]
        public void TestStudentGetByLastname() {
            var stu = Program.GetStudentByLastname("Chan");
            Assert.IsNotNull(stu);
            Assert.AreEqual("Chan", stu.Lastname);
            var noone = Program.GetStudentByLastname("Chun");
                Assert.IsNull(noone);
            }

        }
    }

