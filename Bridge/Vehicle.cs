
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Vehicle
    {
        /// <summary>
        /// The licence plate of the vehicle. No restrictions on getting and setting.
        /// </summary>
        public string LicensePlate { get; set; }
        /// <summary>
        /// The date of the vehicle passing toll. No restrictions on getting and setting.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Base constructor for the abstract class vehicle. Cannot be called directly.
        /// </summary>
        /// <param name="licensePlate">The licensePlate of the vehicle</param>
        /// <param name="date">The date where the vehicle passes toll</param>
        public Vehicle(string licensePlate, DateTime date)
        {
            if(licensePlate.Length > 7)
            {
                throw new ArgumentException("License plate cannot be longer than 7 characters.");
            }
            LicensePlate = licensePlate;
            Date = date;
        }

        /// <summary>
        /// The price of the vehicle passing toll. Must be implemented in derived classes.
        /// </summary>
        /// <returns>The price of passing toll as a double</returns>
        public abstract double Price();

        /// <summary>
        /// The type of vehicle as a string. Must be implemented in derived classes.
        /// </summary>
        /// <returns>The type of vehicle as a string</returns>
        public abstract string VehicleType();
    }
}
