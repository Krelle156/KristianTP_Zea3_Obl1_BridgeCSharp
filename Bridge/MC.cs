using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    //Hvorfor ikke bare skrive Motorcycle? Må man tage den frihed på denne slags opgaver?
    public class MC
    {
        //Kopierede bare fra bil klassen og ændrede hvad der skulle ændres.

        /// <summary>
        /// The licence plate of the MC. No restrictions on getting and setting.
        /// </summary>
        public string LicencePlate { get; set; }

        /// <summary>
        /// Possibly the date where the MC passes tollbooth (Not specified in assignment 3). No restrictions on getting and setting.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Constructor for creating a MC instance.
        /// </summary>
        /// <param name="licencePlate">The license plate of the MC.</param>
        /// <param name="date">TBD possibly the date of this MC passing toll</param>
        public MC(string licencePlate, DateTime date)
        {
            LicencePlate = licencePlate;
            Date = date;
        }

        /// <summary>
        /// A function that gets you the toll levied on this type of vehicle.
        /// </summary>
        /// <returns>A double representing the toll for this type of vehicle.</returns>
        public double Price()
        {
            return 120;
        }

        /// <summary>
        /// A function that returns a string representing the type of vehicle.
        /// </summary>
        /// <returns>A string containing the name of the vehicle's type</returns>
        public string VehicleType()
        {
            return "MC";
        }
    }
}
