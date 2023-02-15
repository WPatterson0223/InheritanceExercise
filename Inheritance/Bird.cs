using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
		}
		public string type { get; set; }
		public bool canFly { get; set; }
		public bool nocturnal { get; set; }
		public bool shortBeak { get; set; }
        public void presentBird()
		{
			Console.WriteLine($"The {type} {generalSpecies} is a {color} bird with\n" +
				$"{numberOfLegs} legs and {numberOfEyes} eyes.\n" +
				$"It can fly: {canFly}\n" +
				$"It is nocturnal: {nocturnal}\n" +
				$"It has a short beak: {shortBeak}");
		}

    }
}

