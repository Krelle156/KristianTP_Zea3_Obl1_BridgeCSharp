using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace Bridge.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass()]
    public class CarTests
    {
        // Det her føles som overkill... er det virkelig værd at "teste"?

        [TestMethod()]
        public void CarTest()
        {
            DateTime testDate = new DateTime(2015, 11, 11);
            Car testCar = new Car("AHAB185", testDate);
            Assert.AreEqual("AHAB185", testCar.LicensePlate);
            Assert.AreEqual(testDate, testCar.Date);
        }

        [TestMethod()]
        public void PriceTest()
        {
            Car testCar = new Car("AHAB185", DateTime.Now);
            //Antager at prisen forbliver 230, per opgavebeskrivelsen, selvom det virker lidt udynamisk.
            Assert.AreEqual(230, testCar.Price());
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            Car testCar = new Car("AHAB185", DateTime.Now);
            Assert.AreEqual("Car", testCar.VehicleType());
        }
    }
}