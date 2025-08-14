using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment__3__Grup_calismasi___08._08_.Enums;
using Assignment__3__Grup_calismasi___08._08_.Exceptions;

namespace Assignment__3__Grup_calismasi___08._08_.Concretes
{
    public class Vehicle
    {
        //Fields
        protected string _brand;
        protected string _model;
        protected decimal _dailyPrice = 200;
        protected FuelType _fuelType;
        private static int _id = 0;
        private Customer _customer;
        
        //constructor
        public Vehicle()
        {
            ++_id;
        }

        //properties
        public int Id = _id;

        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                if (Validations.Validations.CheckHasNumber(value))
                {
                    _brand = value;
                }
                else
                {
                    throw new FullyNumbered("Brand name cant be fully numbered !");
                }
                
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (Validations.Validations.CheckHasNumber(value))
                {
                    _model = value;
                }
                else
                {
                    throw new FullyNumbered("Model name cant be fully numbered !");
                }
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
                if (value <= 0)
                {
                    throw new Exception("Daily price cant be zero or less..");
                }
                else
                {
                    _dailyPrice = value;
                }
                    
            }
        }

        public FuelType FuelType
        {
            get
            {
                return _fuelType;
            }
            set
            {
                if (_fuelType == FuelType.Diesel || _fuelType == FuelType.Eelctric || _fuelType == FuelType.Fueloil || _fuelType == FuelType.Gas)  
                {
                    _fuelType = value;
                }
                else
                {
                    throw new Exception("Fuel type missmatch !!");
                }
                
            }
        }


        public override string ToString()
        {
            return $"Vehicle Brand : {Brand}, ,Model : {Model}, DailyPrice : {DailyPrice}, FuelType : {FuelType}";
        }
    }
}
