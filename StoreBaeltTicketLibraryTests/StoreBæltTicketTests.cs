using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests
{
    [ExcludeFromCodeCoverage]
    [TestClass()]
    public class StoreBæltTicketTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidTypeTest()
        {
            new StoreBæltTicket("AB12345", DateTime.Now, "Jason Bourne");
        }

        [TestMethod()]
        public void PriceTestNotWeekend()
        {
            StoreBæltTicket testTicket = new StoreBæltTicket("AB12345", new DateTime(2025-09-22), "Car");
            Assert.AreEqual(230, testTicket.Price());
        }

        [TestMethod()]
        public void PriceTestWeekendCar()
        {
            StoreBæltTicket testTicket = new StoreBæltTicket("AB12345", new DateTime(2025, 09, 21), "Car");
            Assert.AreEqual(230 * 0.85, testTicket.Price());
        }

        [TestMethod()]
        public void PriceTestWeekendMC()
        {
            StoreBæltTicket testTicket = new StoreBæltTicket("AB12345", new DateTime(2025, 09, 21), "MC");
            Assert.AreEqual(120, testTicket.Price());
        }
    }
}