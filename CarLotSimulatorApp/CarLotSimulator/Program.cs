using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var lot = new CarLot();
            

            //DONE Create a seperate class file called Car
            //DONE Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE The methods should take one string parameter: the respective noise property
            var dustinIsCar = new Car();
            dustinIsCar.Make = "Ford";
            dustinIsCar.Model = "fusion";
            dustinIsCar.Year = 2020;
            dustinIsCar.EngieNoise = "vroom";
            dustinIsCar.HonkNiose = "beep";
            dustinIsCar.IsDrivable = true;

            lot.Cars.Add(dustinIsCar);

            var thomasCar = new Car()
            {
               Year = 2015,
               Make = "Ford",
               Model = "Mustang",
               EngieNoise = "vroom",
               HonkNiose = "beep",
               IsDrivable = true
            };

            lot.Cars.Add(thomasCar);

            var otherCar = new Car(2001, "Saab", "9.4", "vrrroom", "beep", true);

            lot.Cars.Add(otherCar);

            dustinIsCar.MakeEngineNoise(dustinIsCar.EngieNoise);
            thomasCar.MakeEngineNoise(thomasCar.EngieNoise);
            otherCar.MakeEngineNoise(otherCar.MakeEngineNoise);

            Console.WriteLine($"Number of car created: {CarLot.numberOfCars}");

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make}");
            }

            //DONE Now that the Car class is created we can instanciate 3 new cars
            //DONE Set the properties for each of the cars
            //DONE Call each of the methods for each car

            //*************BONUS*************//

            // DONE Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //DONE Create a CarLot class
            //DONE It should have at least one property: a List of cars
            //DONE Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.

         //DONE At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
