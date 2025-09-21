using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    /// <summary>
    /// The company's policy settings, such as base prices and discount rates.
    /// </summary>
    public static class Policy
    {
        /// <summary>
        /// The company's base price for a car.Current no restriction on getting and setting.
        /// </summary>
        public static double CarBasePrice { get; set; } = 230;

        /// <summary>
        /// The company's base price for a motorcycle (MC).Current no restriction on getting and setting.
        /// </summary>
        public static double MCBasePrice { get; set; } = 120;

        /// <summary>
        /// The company's discount rate when a BroBizz device is used.Current no restriction on getting and setting.
        /// </summary>
        public static double BroBizzDiscount { get; set; } = 0.90;

        /// <summary>
        /// The string (Why a string though?) used by the system to recognize an object as a car. Currently no restriction on getting and setting.
        /// </summary>
        public static string CarTypeName { get; set; } = "Car";

        /// <summary>
        /// The string used by the system to recognize an object as a motorcycle (MC). Currently no restriction on getting and setting.
        /// </summary>
        public static string MCTypeName { get; set; } = "MC";




    }
}
