namespace AnimalClasses
{
	public class Animal
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public Animal(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public virtual void MakeSound()
		{
			Console.WriteLine("MakeSound() | The animal makes a generic sound.");
		}
	}

	// Derived Dog class
	public class Dog : Animal
	{
		public Dog(string name, int age) : base(name, age) { }

		public void WagTail()
		{
			Console.WriteLine($"WagTail() | {Name} wags its tail.");
		}

		public override void MakeSound()
		{
			Console.WriteLine($"MakeSound() | {Name} the dog barks.");
		}
	}

	// Derived Cat class
	public class Cat : Animal
	{
		public Cat(string name, int age) : base(name, age) { }

		public void ScratchFurniture()
		{
			Console.WriteLine($"ScratchFurniture() | {Name} the cat scratches the furniture.");
		}

		public override void MakeSound()
		{
			Console.WriteLine($"MakeSound() | {Name} the cat meows.");
		}
	}

	// Derived Bird class
	public class Bird : Animal
	{
		public Bird(string name, int age) : base(name, age) { }

		public void Fly()
		{
			Console.WriteLine($"Fly() | {Name} the bird flies.");
		}

		public override void MakeSound()
		{
			Console.WriteLine($"MakeSound() | {Name} the bird chirps.");
		}
	}
}