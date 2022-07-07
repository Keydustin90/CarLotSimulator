using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }

        public Car(int year,
                    string model,
                    string make,
                    string engieNoise,
                    string honkNoise,
                    bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngieNoise = engieNoise;
            HonkNiose = honkNoise;
            IsDrivable = isDrivable;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngieNoise { get; set; }
        public string HonkNiose { get; set; }
        public bool IsDrivable { get; set; }

        public void MakeEngineNoise(string engieNoise)
        {
            Console.WriteLine(engieNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(honkNoise);
        }

        internal void MakeEngineNoise(Action<string> makeEngineNoise)
        {
            Console.WriteLine(makeEngineNoise); 
        }
    }
