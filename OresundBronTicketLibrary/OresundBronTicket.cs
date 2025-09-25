using Bridge;

namespace OresundBronTicketLibrary
{
    public class OresundBronTicket
    {
        /// <summary>
        /// Details of the vehicle and its standard price
        /// </summary>
        private Vehicle _vehicle;

        /// <summary>
        /// Constructor that initializes the correct prices for the OresundBron Company
        /// </summary>
        static OresundBronTicket() //Det er nyt for mig. Man kan køre ting ved programmets start med en statisk constructor!
        {
            InitializeOresundBronPolicy();
        }

        /// <summary>
        /// Constructor for creating an OresundBron ticket
        /// </summary>
        /// <param name="lisencePlate">The license plate of the vehicle</param>
        /// <param name="date">The date where the vehicle passes toll</param>
        /// <param name="type">The type of vehicle expressed as a string</param>
        /// <exception cref="ArgumentException">The exception thrown if the type is not a car or a mc (motorcycle)</exception>
        public OresundBronTicket(string lisencePlate, DateTime date, string type) //Kopieret fra StoreBæltTicket...
        {
            if (type.ToLower() == "car")
            {
                _vehicle = new Car(lisencePlate, date);
            }
            else if (type.ToLower() == "mc")
            {
                _vehicle = new MC(lisencePlate, date);
            }
            else
            {
                throw new ArgumentException("Type must be either 'Car' or 'MC'");
            }
        }

        /// <summary>
        /// The function that is run in the static constructor to set the prices and names for OresundBron. Can be run at any time but that shoudldn't be necessary.
        /// </summary>
        public static void InitializeOresundBronPolicy() //Nok smartest hvis man kunne ændre policen, men fint for opgaven håber jeg
        {
            Policy.CarBasePrice = 460;
            Policy.MCBasePrice = 235;
            Policy.CarTypeName = "Oresund Car";
            Policy.MCTypeName = "Oresund MC";
            Policy.BroBizzDiscount = 1d - 178d / 460d; //61% reduktion i pris, regnestykket er kun nogle få decimaler fra tilbuddet på motorcykler. Så jeg lader den dække dem begge.
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
        /// The price of the ticket dependent on the vehicle and presence/absence of BroBizz
        /// </summary>
        /// <returns>The price of the OresundBronTicket</returns>
        public double Price()
        {
            return _vehicle.Price();//Der er ikke specificeret nogen yderligere logik for OresundBron
        }



    }
}
