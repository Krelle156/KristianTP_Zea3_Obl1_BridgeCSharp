namespace Bridge
{
    public class Car : Vehicle
    {
        /// <summary>
        /// Base price for a car, as defined in the Policy class.
        /// </summary>
        protected override double BasePrice => Policy.CarBasePrice;

        /// <summary>
        /// Constructor for creating a car instance.
        /// </summary>
        /// <param name="licencePlate">The license plate of the car.</param>
        /// <param name="date">TBD possibly the date of this car passing toll</param>
        public Car(string licensePlate, DateTime date) : base(licensePlate, date) { }


        /// <summary>
        /// A function that returns a string representing the type of vehicle.
        /// </summary>
        /// <returns>A string containing the name of the vehicle's type</returns>
        public override string VehicleType()
        {
            return Policy.CarTypeName;
        }
    }
}
