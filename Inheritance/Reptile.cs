using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
		}
		public int numberOfLungs  { get; set; }
		public bool livesInWater { get; set; }
		public string type { get; set; }
		public bool laysEggs { get; set; }
        public void presentReptile()
        {
            Console.WriteLine($"The {type} {generalSpecies} is a {color} reptile with\n" +
                $"{numberOfLegs} legs, {numberOfEyes} eyes and {numberOfLungs} lung.\n" +
                $"It lives in water: {livesInWater}\n" +
                $"It lays eggs: {laysEggs}");
        }
    }
}

