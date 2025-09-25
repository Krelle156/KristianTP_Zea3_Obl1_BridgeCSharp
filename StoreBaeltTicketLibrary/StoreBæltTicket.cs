using Bridge;

namespace StoreBaeltTicketLibrary
{
    public class StoreBæltTicket
    {
        /// <summary>
        /// Details of the vehicle and its standard price
        /// </summary>
        private Vehicle _vehicle

        /// <summary>
        /// The constuctor for creating a StoreBælt ticket.
        /// </summary>
        /// <param name="lisencePlate">The lisence plate for the vehicle</param>
        /// <param name="date">The date where the vehicle passes toll</param>
        /// <param name="type">The type of the vehicle expressed as a string...</param>
        /// <exception cref="ArgumentException">The exception thrown if the type is not a car or a mc (motorcycle)</exception>
        public StoreBæltTicket(string lisencePlate, DateTime date, string type)
        {
            if(type.ToLower() == "car")
            {
                _vehicle = new Bridge.Car(lisencePlate, date);
            }
            else if(type.ToLower() == "mc")
            {
                _vehicle = new Bridge.MC(lisencePlate, date);
            }
            else
            {
                throw new ArgumentException("Type must be either 'Car' or 'MC'");
            }
        }

        /// <summary>
        /// Enables or disables the BroBizz functionality for the vehicle.
        /// </summary>
        /// <param name="value"><see langword="true"/> to enable BroBizz; <see langword="false"/> to disable it.</param>
        public void SetBroBizz(bool value)
        {
            _vehicle.BroBizz = value;
        }

        /// <summary>
        /// A function for getting the price of the ticket specific to StoreBælt.
        /// </summary>
        /// <returns>The price of the ticket</returns>
        public double Price()
        {
            double basePrice = _vehicle.Price();

            if (_vehicle.VehicleType() == "Car" && (_vehicle.Date.DayOfWeek == DayOfWeek.Saturday || Vehicle.Date.DayOfWeek == DayOfWeek.Sunday))
            {
                basePrice *= 0.85;
            }
            return basePrice;
        }
    }
}
