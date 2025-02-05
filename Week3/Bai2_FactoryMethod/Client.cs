class Client {
	public static void Main(string[] args) {
		Console.WriteLine("***Factory Pattern Demo***\n");
		// Creating a Tiger Factory
		IAnimalFactory tigerFactory =new TigerFactory();
		// Creating a tiger using the Factory Method
		IAnimal aTiger = tigerFactory.CreateAnimal();
		aTiger.AboutMe();
		// Creating a DogFactory
		IAnimalFactory dogFactory = new DogFactory();
		// Creating a dog using the Factory Method
		IAnimal aDog = dogFactory.CreateAnimal();
		aDog.AboutMe();
 	}
}