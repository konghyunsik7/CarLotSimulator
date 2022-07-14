﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var detailedLot = new CarLot();

            //TODO

            //Create a seperate class file called Car - DONE

            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var car1 = new Car()
            {
                Year = 2002,
                Make = "Dodge",
                Model = "Viper",
                EngineNoise = "Vrooom",
                HonkNoise = "Beeeeeeeeeep",
                IsDriveable = true,
            };
            detailedLot.ParkingLot.Add(car1);


            var car2 = new Car();
            car2.Year = 1888;
            car2.Make = "Classic";
            car2.Model = "Junk";
            car2.EngineNoise = "POW";
            car2.HonkNoise = "BOOOOOM";
            car2.IsDriveable = false;
            detailedLot.ParkingLot.Add(car2);

            var car3 = new Car(2050, "RR", "Phantom","Zooooom","MOVE", true);
            detailedLot.ParkingLot.Add(car3);


            foreach (var car in detailedLot.ParkingLot)
            {
                Console.WriteLine($"{car.Year} | {car.Make} | {car.Model}");
                car.MakeEngineNoise(car.EngineNoise);
                car.MakeHonkNoise(car.HonkNoise);
            }





            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
