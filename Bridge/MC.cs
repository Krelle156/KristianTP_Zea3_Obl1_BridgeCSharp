using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    //Hvorfor ikke bare skrive Motorcycle? Må man tage den frihed på denne slags opgaver?
    public class MC : Vehicle
    {
        /// <summary>
        /// Base price for a MC, as defined in the Policy class.
        /// </summary>
        protected override double BasePrice => Policy.MCBasePrice;

        /// <summary>
        /// Constructor for creating a MC instance.
        /// </summary>
        /// <param name="licensePlate">The license plate of the MC.</param>
        /// <param name="date">TBD possibly the date of this MC passing toll</param>
        public MC(string licensePlate, DateTime date) : base(licensePlate, date) { }

        /// <summary>
        /// A function that returns a string representing the type of vehicle.
        /// </summary>
        /// <returns>A string containing the name of the vehicle's type</returns>
        public override string VehicleType()
        {
            return Policy.MCTypeName;
        }
    }
}
