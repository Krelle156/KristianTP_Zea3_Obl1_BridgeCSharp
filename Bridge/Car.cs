namespace Bridge
{
    public class Car
    {
        /// <summary>
        /// The licence plate of the car. No restrictions on getting and setting.
        /// </summary>
        public string LicencePlate { get; set; }

        /// <summary>
        /// Possibly the date where the car passes tollbooth (Not specified in assignment 1). No restrictions on getting and setting.
        /// </summary>
        public DateTime Date { get; set; }

        //Opgave 1 nævner ikke constructor, men jeg tænker at det er godt at have på forhånd.
        /// <summary>
        /// Constructor for creating a car instance.
        /// </summary>
        /// <param name="licencePlate">The license plate of the car.</param>
        /// <param name="date">TBD possibly the date of this car passing toll</param>
        public Car(string licencePlate, DateTime date)
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
            return 230;
        }

        /// <summary>
        /// A function that returns a string representing the type of vehicle.
        /// </summary>
        /// <returns>A string containing the name of the vehicle's type</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
