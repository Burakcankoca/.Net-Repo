using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__3__Grup_calismasi___08._08_.Concretes
{
    public struct RentalProcesses
    {
        //Fields
        private Customer _customer;
        private Vehicle _vehicle;
        private int _days;
        private decimal _totalPrice;
        private decimal _dailyPrice;


        //Properties
        public Vehicle Vehicle
        {
            get
            {
                return _vehicle;
            }
            set
            {
                _vehicle = value;
            }
        }
        public Customer Customer
        {
            get
            {
                return _customer;
            }
            set
            {
                _customer = value;
            }
        }
        public int Days
        {
            get
            {
                return _days;
            }
            set
            {
                _days = value;
            }
        }
        public decimal TotalPrice
        {
            get
            {
                return _totalPrice;
            }
            set
            {
                _totalPrice = value;
            }
        }
        public decimal DailyPrice
        {
            get
            {
                return _dailyPrice;

            }
            set
            {
                _dailyPrice = value;
            }
        }

        //Methods
        public string GetRentInfo()
        {
            return $"Customer name : {Customer.Name}, surname : {Customer.Surname}, vehicle : {Vehicle.Brand}, Rent days : {Days}, Total Coast : {Vehicle.DailyPrice * Days}Tl";
        }

    }
}
