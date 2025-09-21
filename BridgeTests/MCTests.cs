using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void MCTest()
        {
            DateTime testDate = new DateTime(2020, 1, 1);
            MC testCycle = new MC("MC12345", testDate);
            Assert.AreEqual("MC12345", testCycle.LicensePlate);
            Assert.AreEqual(testDate, testCycle.Date);
        }

        [TestMethod()]
        public void PriceTest()
        {
            MC testMotorCarriage = new MC("MC12345", DateTime.Now);
            Assert.AreEqual(120, testMotorCarriage.Price());
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            MC testMineCraft = new MC("MC12345", DateTime.Now);
            Assert.AreEqual("MC", testMineCraft.VehicleType());
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void LicensePlateTooLong()
        {
            MC testCycle = new MC("MC123456", DateTime.Now);
        }
    }
}