using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForCarRental
{
    public class Car
    {
        private string _make;
        private string _model;
        private decimal _rentalPrice;
        private bool _rented;

        public Car()
        {

        }
        
        public Car(string _make, string _model, decimal _rentalPrice, bool _rented)
        {
            this._make = _make;
            this._model = _model;
            this._rentalPrice = _rentalPrice;
            this._rented = _rented;
        }
        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
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
                _model = value;
            }
        }

        public decimal RentalPrice
        {
            get
            {
                return _rentalPrice;
            }
            set
            {
                _rentalPrice = value;
            }
        }

        public bool Rented
        {
            get
            {
                return _rented;
            }
            set
            {
                _rented = value;
            }
        }

        //methods
        public bool Rent()
        {
            if (!_rented)
            {
                _rented = true;

            }
            else
            {
                Console.WriteLine("Car is already rented!");
                _rented = false;
            }
            return _rented;
        }

        public bool Return()
        {
            if (_rented)
            {
                _rented = false;
                Console.WriteLine("Returned sucessfully.");
            }
            else
            {
                _rented = true;
                Console.WriteLine("Can't return; the car is not rented.");
            }
            return _rented;
        }

        public void PrintCarInfo(Car car)
        {
            Console.WriteLine($"Car Make : {car._make} | Car Model : {car._model} | Car Rental Price : {car._rentalPrice} | Car Availability Status (Rented Now): {car._rented}");
        }
    }
}
