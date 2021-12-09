using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCar()
        {
            float VExpected1 = 6.0f;
            float VExpected2 = 2.0f;
            SpeedyCars.Car auto = new SpeedyCars.Car(0.0f, 2.0f, 1.0f, 2.4f);
            auto.updateVelocity(3.0f, true);
            Assert.AreEqual(VExpected1, auto.getVelocity());
            auto.updateVelocity(4.0f,false);
            Assert.AreEqual(VExpected2, auto.getVelocity());
        }
        [TestMethod]
        public void TestRoad()
        {
            Console.WriteLine("Hoi");
            float VExpected1 = 5.0f;
            float VExpected2 = 20.0f;
            float[] numbers = {5.0f, 30.0f, 50.0f, 80.0f };
            List<float> lijst = new List<float>(numbers);
            SpeedyCars.Road weg = new SpeedyCars.Road(100.0f, lijst);
            Assert.AreEqual(VExpected1, weg.getNextLightDistance(25.0f));
            Assert.AreEqual(VExpected2, weg.getNextLightDistance(60.0f));
        }
    }
}
