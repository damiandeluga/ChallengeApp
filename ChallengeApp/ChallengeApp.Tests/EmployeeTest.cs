using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectSetofPoints_ShouldReturnCorrectResult()
        {
            var employee = new Employee("Marian","Kowalski", 33);

            employee.Addscore(5);
            employee.Addscore(6);
            employee.Addscore(8);
            employee.Addscore(6);

            var result = employee.Result;

            Assert.AreEqual(25, result);


            
        }
        [Test]
        public void WhenUserCollectSetofPoints_SomethingHappens()
        {
            var employee = new Employee("Adam", "Kot", 30);

            employee.Addscore(-6);
            employee.Addscore(-1);
            employee.Addscore(-8);
            employee.Addscore(-6);

            var result = employee.Result;

            Assert.AreEqual(-21, result);



        }
        [Test]
        public void WhenUserCollectSetofPoints_ItIsSuccesful()
        {
            var employee = new Employee("Karol", "Nowak", 28);

            employee.Addscore(5);
            employee.Addscore(6);
            employee.Addscore(0);
            employee.Addscore(0);

            var result = employee.Result;

            Assert.AreEqual(11, result);



        }
    }
}