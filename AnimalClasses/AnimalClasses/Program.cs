using CustomConsole;

namespace AnimalClasses
{
	internal class Program
	{
		// the Main method has been made async to allow for the use of Task.Delay()
		static async Task Main(string[] args)
		{
			float delayTime = 0.5f;
			
			List<Animal> animals = new List<Animal>
			{
				new Dog("Rover", 3),
				new Cat("Whiskers", 4),
				new Bird("Tweetie", 2)
			};

			while (true)
			{
				// clear screen before printing new info
				Console.Clear();

				foreach (var animal in animals)
				{
					Console.WriteLine($"{animal.Name} is {animal.Age} years old.");

					// wait .5 seconds before making sound
					await Task.Delay(SecondsToMiliseconds(delayTime));

					animal.MakeSound();

					// wait .5 seconds before performing action
					await Task.Delay(SecondsToMiliseconds(delayTime));

					if (animal is Dog) { ((Dog)animal).WagTail(); }

					if (animal is Cat) { ((Cat)animal).ScratchFurniture(); }
					
					if (animal is Bird) { ((Bird)animal).Fly(); }

					// wait .5 seconds before continuing loop
					await Task.Delay(SecondsToMiliseconds(delayTime));

					// print blank line between animals
					ConsoleHelper.PrintBlank();
				}

				ConsoleHelper.HaltProgram("Press any key to restart the sequence...");
			}
		}

		private static int SecondsToMiliseconds(float seconds)
		{
			return (int)(seconds * 1000);
		}
	}
}