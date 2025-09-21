using Bridge;

namespace StoreBaeltTicketLibrary
{
    public class StoreBæltTicket
    {
        /// <summary>
        /// Details of the vehicle and its standard price
        /// </summary>
        public Vehicle Vehicle { get; set; }

        /// <summary>
        /// The constuctor for creating a StoreBælt ticket.
        /// </summary>
        /// <param name="lisencePlate">The lisence plate for the vehicle</param>
        /// <param name="type">The type of the vehicle expressed as a string...</param>
        /// <exception cref="ArgumentException">The exception thrown if the type is not a car or a mc (motorcycle)</exception>
        public StoreBæltTicket(string lisencePlate, DateTime date, string type)
        {
            if(type.ToLower() == "car")
            {
                Vehicle = new Bridge.Car(lisencePlate, date);
            }
            else if(type.ToLower() == "mc")
            {
                Vehicle = new Bridge.MC(lisencePlate, date);
            }
            else
            {
                throw new ArgumentException("Type must be either 'Car' or 'MC'");
            }
        }

        /// <summary>
        /// A function for getting the price of the ticket specific to StoreBælt.
        /// </summary>
        /// <returns>The price of the ticket</returns>
        public double Price()
        {
            double basePrice = Vehicle.Price();

            if (Vehicle.VehicleType() == "Car" && (Vehicle.Date.DayOfWeek == DayOfWeek.Saturday || Vehicle.Date.DayOfWeek == DayOfWeek.Sunday))
            {
                basePrice *= 0.85;
            }
            return basePrice;
        }
    }
}
