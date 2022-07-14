using System;
using System.Collections.Generic;
using System.Text;

//Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
//Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
//The methods should take one string parameter: the respective noise property

namespace CarLotSimulator
{
    internal class Car
    {
        public Car()
        {

        }
        public Car(int yearCar, string makeCar, string modelCar, string engineNoiseCar, string honkNoiseCar, bool isDriveableCar)
        {
            Year = yearCar;
            Make = makeCar;
            Model = modelCar;
            EngineNoise = engineNoiseCar;
            HonkNoise = honkNoiseCar;
            IsDriveable = isDriveableCar;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string Engine)
        {
            Console.WriteLine($"{Engine}");
        }
        public void MakeHonkNoise(string Honk)
        {
            Console.WriteLine($"{Honk}");
        }



    }
}
