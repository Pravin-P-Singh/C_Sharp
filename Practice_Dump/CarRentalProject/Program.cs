

using ClassLibraryForCarRental;
using System;
using System.ComponentModel.Design;

namespace CarRentalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[3]
            {
                new Car("Toyota","Corolla",50,false),
                new Car("Honda", "Civic",60,false),
                new Car("Ford", "Mustang",80, false)
            };

            Console.WriteLine("Welcome to the car rental system..");
            int userChoice = -1;
            do
            {
                Console.WriteLine("1. Rent a car");
                Console.WriteLine("2. Return a car");
                Console.WriteLine("3. View available cars");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Select a choice::");
                userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1: RentCar(cars); break;
                    case 2: ReturnCar(cars); break;
                    case 3: ViewCars(cars); break;
                    case 4: break;
                }
            } while (userChoice != 4);

            Console.WriteLine("Car Rental System Closed! Thank you");
        }

        public static void RentCar(Car[] cars)
        {
            for(int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{i+1} {cars[i].Make} (Rental Price: {cars[i].RentalPrice}/day) - {(cars[i].Rented?"Unavailable":"Available")}");
            }
            Console.WriteLine("Please enter the id of the car that you want to rent:");
            int carIdToRent = int.Parse(Console.ReadLine());
            if (carIdToRent > cars.Length)
            {
                Console.WriteLine("Please enter a valid car id!");
            }
            else
            {
                if (cars[carIdToRent-1].Rented)
                {
                    Console.WriteLine("Sorry, the selected car is not available for rent.");
                }
                else
                {
                    cars[carIdToRent-1].Rented = !cars[carIdToRent-1].Rented;
                    Console.WriteLine($"Rented the {cars[carIdToRent-1].Make} for {cars[carIdToRent-1].RentalPrice}/day.");
                }
            }
        }

        public static void ReturnCar(Car[] cars)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{i + 1} {cars[i].Make} (Rental Price: {cars[i].RentalPrice}/day) - {(cars[i].Rented ? "Unavailable" : "Available")}");
            }
            Console.WriteLine("Please enter the id of the car you want to return: ");
            int carIdToReturn = int.Parse(Console.ReadLine());
            if (carIdToReturn > cars.Length)
            {
                Console.WriteLine("Please enter a valid car id!");
            }
            else {
                if (cars[carIdToReturn-1].Rented)
                {
                    cars[carIdToReturn-1].Rented = !cars[carIdToReturn-1].Rented;
                    Console.WriteLine($"Returned the {cars[carIdToReturn-1].Make}.");
                }
                else
                {
                    Console.WriteLine("Sorry, car is not rented and it cannot be returned.");
                }
            }
        }

        public static void ViewCars(Car[] cars)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"{i + 1} {cars[i].Make} (Rental Price: {cars[i].RentalPrice}/day) - {(cars[i].Rented ? "Unavailable" : "Available")}");
            }
        }

    }
}
