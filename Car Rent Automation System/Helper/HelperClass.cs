using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__3__Grup_calismasi___08._08_.Helper
{
    public static class HelperClass
    {
        public static decimal TotalPriceCalculator(int rentDates, decimal dailyPrice)
        {
            return rentDates * dailyPrice;
        }

        public static string VehicleInfo(string brand, string model, decimal dailyPrice, string fuelType)
        {
            return $"Vehicle Info : Brand -> {brand}, Model -> {model}, DailyPrice : {dailyPrice}, FuelType : {fuelType}";
        }
    }
}
