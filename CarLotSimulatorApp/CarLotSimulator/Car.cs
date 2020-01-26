using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Car
    {
        
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
        public void MakeEngineNoise(string rev)
        {
            Console.WriteLine("VROOM" + rev);
        }
        public void MakeHonkNoise(string horn)
        {
            Console.WriteLine("Beep" + horn);
        }

    }
}
