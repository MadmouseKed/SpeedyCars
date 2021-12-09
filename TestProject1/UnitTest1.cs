using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private const float VExpected1 = 6.0f;
        private const float VExpected2 = 2.0f;
        [TestMethod]
        public void TestCar()
        {
            SpeedyCars.Car auto = new SpeedyCars.Car(0.0f, 2.0f, 1.0f, 2.4f);
            auto.updateVelocity(3.0f, true);
            Assert.AreEqual(VExpected1, auto.getVelocity());
            auto.updateVelocity(4.0f,false);
            Assert.AreEqual(VExpected2, auto.getVelocity());
        }
    }
}
