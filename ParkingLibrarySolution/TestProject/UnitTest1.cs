using ParkingLibrary;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        private ParkingCalculator _objParking;
        private PersonType _objPerson;

        [TestInitialize]
        public void StartMyTests()
        {
            _objParking = new ParkingCalculator();
            _objPerson = new PersonType();
        }

        [TestMethod]
        public void TestMethodGeneral()
        {
            _objPerson = PersonType.General;
            Assert.AreEqual(10.0, _objParking.CalculateParkingCharge(_objPerson, 2));
        }

        [TestMethod]
        public void TestMethodStaff()
        {
            _objPerson = PersonType.Staff;
            Assert.AreEqual(30.0, _objParking.CalculateParkingCharge(_objPerson, 2));
        }

        [TestMethod]
        public void TestMethodStudent()
        {
            _objPerson = PersonType.Student;
            Assert.AreEqual(7.5, _objParking.CalculateParkingCharge(_objPerson, 2));
        }

        [TestMethod]
        public void TestMethodNone()
        {
            _objPerson = PersonType.None;
            Assert.AreEqual(0, _objParking.CalculateParkingCharge(_objPerson, 2));
        }
    }
}