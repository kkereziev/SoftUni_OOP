using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.RawData
{
    public class RunProgram
    {
        public static void Run()
        {
            List<Car> cars = new List<Car>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                GenerateCar(cars, parameters);
            }
            string command = Console.ReadLine();
            SortByCommand(cars, command);
        }

        private static void SortByCommand(List<Car> cars, string command)
        {
            if (command == "fragile")
            {
                List<string> fragile = cars
                    .Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(y => y.Pressure < 1))
                    .Select(x => x.Model)
                    .ToList();
                Console.WriteLine(string.Join(Environment.NewLine, fragile));
            }
            else if (command == "flamable")
            {
                List<string> flamable = cars
                    .Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250)
                    .Select(x => x.Model)
                    .ToList();
                Console.WriteLine(string.Join(Environment.NewLine, flamable));
            }
        }
        private static void GenerateCar(List<Car> cars, string[] parameters)
        {
            string model = parameters[0];
            int engineSpeed = int.Parse(parameters[1]);
            int enginePower = int.Parse(parameters[2]);
            Engine engine = new Engine(engineSpeed, enginePower);

            int cargoWeight = int.Parse(parameters[3]);
            string cargoType = parameters[4];
            Cargo cargo = new Cargo(cargoWeight, cargoType);

            double firstTirePressure = double.Parse(parameters[5]);
            int firstTireAge = int.Parse(parameters[6]);
            double secondTirePressure = double.Parse(parameters[7]);
            int secondTireAge = int.Parse(parameters[8]);
            double thirdTirePressure = double.Parse(parameters[9]);
            int thirdTireAge = int.Parse(parameters[10]);
            double fourthTirePressure = double.Parse(parameters[11]);
            int fourthTireAge = int.Parse(parameters[12]);
            Tire[] tires = new Tire[4]
            {
                    new Tire(firstTireAge,firstTirePressure),
                    new Tire(secondTireAge,secondTirePressure),
                    new Tire(thirdTireAge,thirdTirePressure),
                    new Tire(fourthTireAge,fourthTirePressure),
            };
            cars.Add(new Car(model, engine, cargo, tires));
        }
    }
}
