namespace Bridge
{
    public class Car : Vehicle
    {
        /// <summary>
        /// Constructor for creating a car instance.
        /// </summary>
        /// <param name="licencePlate">The license plate of the car.</param>
        /// <param name="date">TBD possibly the date of this car passing toll</param>
        public Car(string licensePlate, DateTime date) : base(licensePlate, date) { }

        /// <summary>
        /// A function that gets you the toll levied on this type of vehicle.
        /// </summary>
        /// <returns>A double representing the toll for this type of vehicle.</returns>
        public override double Price()
        {
            return 230;
        }

        /// <summary>
        /// A function that returns a string representing the type of vehicle.
        /// </summary>
        /// <returns>A string containing the name of the vehicle's type</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
