using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var Carlist = new Carlot();

            Car mustang = new Car() { Year = 2004, Make = "Ford", Model = "Mustang" };
            mustang.MakeEngineNoise("VROOOOM");
            mustang.MakeHonkNoise("Beep");
            var Inventory = new Carlot() { Carlist = (Car)mustang };

            

            Car Cherokee = new Car();
            Cherokee.Year = 1974;
            Cherokee.Make = "Jeep";
            Cherokee.Model = "Cherokee";
            Cherokee.MakeEngineNoise("Sputter");
            Cherokee.MakeHonkNoise("Meep");

            Carlist.Add(Cherokee);


            Car Corolla = new Car()
            {
                Year = 2008,
                Make = "Toyota",
                Model = "Corolla"
            };
            Corolla.MakeEngineNoise("whir");
            Corolla.MakeHonkNoise("Clown horn sound");

            Carlist.Add(Corolla);

            foreach( var x in Carlist)
            {
                Console.WriteLine(x);
            }

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

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
