using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLot = new Carlot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //Dot Notation
            var charger = new Car();
            charger.Make = "Dodge";
            charger.Model = "Challenger";
            charger.Year = 1970;
            charger.IsDriveable = true;
            charger.EngineNoise = "smooth";
            charger.HonkNoise = "honk";

            carLot.ParkingLot.Add(charger);


            //Object initializer syntax
            var chevy = new Car()
            {
                Make = "Chevy",
                Model = "Silverado",
                Year = 2023,
                IsDriveable = true,
                EngineNoise = "vroom",
                HonkNoise = "beep"
            };

            carLot.ParkingLot.Add(chevy);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            var sierra = new Car(2023, "GMC", "Sierra", "click clack", "HONK!", true);
            
            carLot.ParkingLot.Add(sierra);

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            carLot.CheckCars();
        }
    }
}
